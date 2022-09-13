using System;

namespace Dice // Note: actual namespace depends on the project name.
{
    class Dice
    {
        private int _sidesNo;
        private int _number;

        public void InputSidesNo()
        {
            Console.Write("Input number of dice sides: ");
            int sides = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            SetSides(sides);
        }

        private void SetSides(int sides)
        {
            _sidesNo = sides;
        }

        public int GetSides()
        {
            return _sidesNo;
        }

        public void Roll()
        {
            int random = new Random().Next(1, GetSides());
            SetRoll(random);
        }

        private void SetRoll(int number)
        {
            this._number = number;
        }

        public int GetRoll()
        {
            return _number;
        }
    }

    class Guessing
    {
        private bool _isTrue;

        private void SetStatus(bool status)
        {
            _isTrue = status;
        }

        public void Guess(int rightNumber)
        {
            Console.Write("Enter your number: ");
            int guessNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            SetStatus(CheckNumber(guessNumber, rightNumber));
        }

        private bool CheckNumber(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool GetStatus()
        {
            return _isTrue;
        }
    }
    
    
    internal class MainProgram
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