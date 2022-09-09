using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Dice
    {
        private int sidesNo;
        private int number;

        public void InputSidesNo()
        {
            Console.Write("Input number of dice sides: ");
            int sides = int.Parse(Console.ReadLine());
            SetSides(sides);
        }

        private void SetSides(int sides)
        {
            sidesNo = sides;
        }

        public int GetSides()
        {
            return sidesNo;
        }

        public void Roll()
        {
            int random = new Random().Next(1, GetSides());
            SetRoll(random);
        }

        private void SetRoll(int _number)
        {
            number = _number;
        }

        public int GetRoll()
        {
            return number;
        }
    }

    class Guessing
    {
        private bool isTrue;

        private void SetStatus(bool status)
        {
            isTrue = status;
        }

        public void Guess(int rightNumber)
        {
            Console.Write("Enter your number: ");
            int guessNumber = int.Parse(Console.ReadLine());
            SetStatus(CheckNumber(guessNumber, rightNumber));
        }

        private bool CheckNumber(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool GetStatus()
        {
            return isTrue;
        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            dice.InputSidesNo();
            dice.Roll();

            Guessing guessing = new Guessing();
            guessing.Guess(dice.GetRoll());
            Console.WriteLine("Your guessing is "+ guessing.GetStatus());
            Console.WriteLine("Right Number: "+ dice.GetRoll());
        }
    }
}