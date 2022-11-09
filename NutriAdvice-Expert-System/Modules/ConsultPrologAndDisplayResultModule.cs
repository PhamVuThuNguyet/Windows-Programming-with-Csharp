using NutriAdvice.Classes;
using NutriAdvice.Forms;
using Prolog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace NutriAdvice.Modules
{
    public partial class ConsultPrologAndDisplayResultModule : UserControl
    {
        public List<Recipe> RecipeList = new();
        public Recipe prescription = new();

        private string userDietAction;
        public string UserDietAction
        {
            set { userDietAction = value; }
            get { return userDietAction; }
        }

        private double userDietIntake;
        public double UserDietIntake
        {
            set { userDietIntake = value; }
            get { return userDietIntake; }
        }

        private string userFoodType;
        public string UserFoodType
        {
            set { userFoodType = value; }
            get { return userFoodType; }
        }

        public void ConsultProlog()
        {
            dgvDisplayRecipes.Rows.Clear();
            RecipeList.Clear();
            prescription = new Recipe();

            var prolog = new PrologEngine(persistentCommandHistory: false);

            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NutriAdvice-Expert-System\Prolog\Recipes_List.pl";

            if (!File.Exists(filename))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NutriAdvice-Expert-System\Prolog\";
                FileInfo file = new(path);
                file.Directory.Create();
                MessageBox.Show("No File, Downloading .. ");
                using (WebClient wc = new())
                {
                    wc.DownloadFileAsync(
                        new Uri("https://raw.githubusercontent.com/PhamVuThuNguyet/Windows-Programming-with-Csharp/master/NutriAdvice-Expert-System/Prolog/Recipes_List.pl"),
                        filename
                    );
                }
                MessageBox.Show("Complete, please click again");
            }

            string query = @"contains(" + '"' + userFoodType.ToString() + '"' + "," + '"' + userDietAction.ToString() + '"' + ", R, CS, L, I, C, M).";

            var solutions = prolog.GetAllSolutions(filename, query);
            string nameRecipe = "";

            // Get each solution list
            for (int i = 0; i < solutions.Count; i++)
            {
                if (i == 0)
                {
                    nameRecipe = solutions[i][0].Value;

                    prescription.SetName(solutions[i][0].Value);
                    prescription.SetCalories(solutions[i][1].Value);
                    prescription.SetLink(solutions[i][2].Value);

                    prescription.AddIngredient(solutions[i][3].Value, solutions[i][4].Value, solutions[i][5].Value);
                }
                else
                {
                    if (nameRecipe.Equals(solutions[i][0].Value))
                    {
                        prescription.AddIngredient(solutions[i][3].Value, solutions[i][4].Value, solutions[i][5].Value);
                    }
                    else
                    {
                        RecipeList.Add(prescription);
                        prescription = new Recipe();
                        nameRecipe = solutions[i][0].Value;
                        prescription.SetName(solutions[i][0].Value);
                        prescription.SetCalories(solutions[i][1].Value);
                        prescription.SetLink(solutions[i][2].Value);

                        prescription.AddIngredient(solutions[i][3].Value, solutions[i][4].Value, solutions[i][5].Value);
                    }
                }
            }

            for (int i = 0; i < RecipeList.Count; i++)
            {
                if (RecipeList[i].GetName() != "" && RecipeList[i].GetCalories() != "")
                {
                    dgvDisplayRecipes.Rows.Add(RecipeList[i].GetName(), RecipeList[i].GetCalories());
                }
            }
        }

        public ConsultPrologAndDisplayResultModule()
        {
            InitializeComponent();
        }

        private void DgvDisplayRecipes_CellClick(object sender, EventArgs e)
        {
            Form2 showData = new(RecipeList, dgvDisplayRecipes.CurrentCell.RowIndex);
            showData.GetRecipeIngredientData();
            showData.Show();
        }
    }
}
