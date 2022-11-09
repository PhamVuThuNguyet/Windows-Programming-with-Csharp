using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriAdvice.Classes;
using Prolog;
using NutriAdvice.Forms;
using System.IO;
using System.Net;

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

            string filename = "D:\\Csharp Project\\NutriAdvice-Expert-System\\Prolog\\Recipes_List.pl";

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
                    if(nameRecipe.Equals(solutions[i][0].Value))
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
