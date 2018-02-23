using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * answer to assignment question:
             * the difficulty in calculating 20! is that a 32 bit integer does not have enough space to hold the result
             */

            // declarations
            Int64 factorialResult;
            int rangeStart = 1, rangeEnd = 5;

            // process and display output
            for ( int factorialOf = rangeStart; factorialOf <= rangeEnd; ++factorialOf )
            {
                factorialResult = factorialOf;

                for ( int i = factorialOf; i > 1; ) // i is decremented during calculation
                    factorialResult = factorialResult * --i;

                Console.WriteLine("{0}! = {1:N0}", factorialOf, factorialResult);
            }

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
