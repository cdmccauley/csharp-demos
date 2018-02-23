using System;

namespace DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            SetOfDice twoD6 = new SetOfDice(2, 6); // create 2 dice with 6 sides each
            const int NUM_ROLLS = 36000;

            // roll dice and display results
            twoD6.RollDice(NUM_ROLLS);
            Console.WriteLine(twoD6.ToString());

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
