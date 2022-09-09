using System;

namespace DiceRollPOP // Note: actual namespace depends on the project name.
{
    internal class DiceRollPOP
    {
        static int Roll()
        {
            return new Random().Next(1, 7);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Roll());
        }
    }
}