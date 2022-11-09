using NutriAdvice.Classes;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace NutriAdvice.Forms
{
    public partial class Form2 : Form
    {
        public List<Recipe> LocalRecipeList;
        public Recipe Localreceta;
        public int location;
        public string RecipeWebsiteLink;

        public Form2(List<Recipe> RecipeList, int index)
        {
            InitializeComponent();

            LocalRecipeList = RecipeList;
            location = index;
        }

        public void GetRecipeIngredientData()
        {
            DisplayRecipeLink.Text = LocalRecipeList[location].GetName().ToString();
            for (int j = 0; j < LocalRecipeList[location].GetIngredientList().Count; j++)
            {
                dgvDisplayRecipeIngredients.Rows.Add(
                    LocalRecipeList[location].GetIngredientList()[j].GetName(),
                    LocalRecipeList[location].GetIngredientList()[j].GetAmount(),
                    LocalRecipeList[location].GetIngredientList()[j].GetQuantity()
                    );
                RecipeWebsiteLink = LocalRecipeList[location].GetLink();
            }
        }

        private void DisplayRecipeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo { FileName = RecipeWebsiteLink, UseShellExecute = true };
            Process.Start(psi);
        }
    }
}
