using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int number;

            // get input
            Console.Write("Enter a whole number: ");
            number = int.Parse(Console.ReadLine());

            // process input and display result
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even.", number);
            }
            else
            {
                Console.WriteLine("{0} is odd.", number);
            }

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
