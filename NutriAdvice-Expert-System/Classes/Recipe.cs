using System.Collections.Generic;

namespace NutriAdvice.Classes
{
    public class Recipe
    {
        private string name;
        private string link;
        private string calories;
        private readonly List<Ingredient> ingredientsList = new();

        public Recipe()
        {
            name = "";
            link = "";
            calories = "";
            ingredientsList.Clear();
        }

        public Recipe(string name, string link, string calories)
        {
            this.name = name;
            this.link = link;
            this.calories = calories;
            ingredientsList.Clear();
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetLink()
        {
            return link;
        }

        public void SetLink(string link)
        {
            this.link = link;
        }

        public string GetCalories()
        {
            return calories;
        }

        public void SetCalories(string calories)
        {
            this.calories = calories;
        }

        public Ingredient GetIngredient(int indice)
        {
            return ingredientsList[indice];
        }

        public void AddIngredient(string name, string quantity, string amount)
        {
            ingredientsList.Add(new Ingredient(name,quantity,amount));
        }

        public List<Ingredient> GetIngredientList()
        {
            return ingredientsList;
        }

        public void CleanIngredientList()
        {
            ingredientsList.Clear();
        }
    }
}
