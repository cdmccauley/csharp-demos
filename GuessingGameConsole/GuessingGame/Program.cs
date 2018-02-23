using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            Random randomNumbers = new Random();
            int cpuNumber, playerNumber, counter = 0;
            string sentinel = "continue";

            // generate number
            cpuNumber = randomNumbers.Next(1, 101);

            // play game
            do
            {
                Console.Write("Enter a guess: ");
                playerNumber = Convert.ToInt32(Console.ReadLine());

                ++counter;

                if (playerNumber < cpuNumber)
                    Console.WriteLine("Too low.\n");
                if (playerNumber > cpuNumber)
                    Console.WriteLine("Too high.\n");
                if (playerNumber == cpuNumber)
                {
                    Console.WriteLine("You win with {0} guesses!\n", counter);
                    sentinel = "exit";
                }
            } while (sentinel != "exit");

            // hold console
            Console.Write("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
