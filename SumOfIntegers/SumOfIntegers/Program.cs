using System;

namespace SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            int sumTo, sumOf = 0;

            // get input
            do
            {
                Console.Write("Enter a positive integer: ");
                sumTo = Convert.ToInt32(Console.ReadLine());
            } while (sumTo < 1);

            // process
            for (int i = 1; i <= sumTo; i += 2)
                sumOf = sumOf + i;

            // display output
            Console.WriteLine("The sum of all odd numbers from 1 to {0} is {1}.", sumTo, sumOf);

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
