using System;

namespace DiceRollOOP // Note: actual namespace depends on the project name.
{
    class Dice
    {
        private int number = 0;

        public void Roll()
        {
            number = new Random().Next(1, 7);
        }

        public int GetNumber()
        {
            return number;
        }
    }

    internal class DiceRollOOP
    {
        private static void Main(string[] args)
        {
            Dice dice = new Dice();
            dice.Roll();
            Console.WriteLine("Roll: " + dice.GetNumber());
        }
    }
}