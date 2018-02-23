using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            Int64 a = 0, b = 1, c = 0, target;

            // get input
            Console.Write("Enter a number: ");
            target = Convert.ToInt32(Console.ReadLine());

            // begin output
            Console.Write("{0}\n{1}\n", a, b);

            // continue output
            while ((a + b) <= target)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
