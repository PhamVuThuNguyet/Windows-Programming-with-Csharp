namespace NutriAdvice.Classes
{
    public class Ingredient
    {
        private string name;
        private string quantity;
        private string amount;

        public Ingredient()
        {
            name = "";
            quantity = "";
            amount = "";
        }

        public Ingredient(string name, string quantity, string amount)
        {
            this.name = name;
            this.quantity = quantity;
            this.amount = amount;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(string quantity)
        {
            this.quantity = quantity;
        }

        public string GetAmount()
        {
            return amount;
        }

        public void SetAmount(string amount)
        {
            this.amount = amount;
        }
    }
}
