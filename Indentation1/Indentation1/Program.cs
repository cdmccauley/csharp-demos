using System;

namespace Indentation1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            int x, y;

            // initialize for part a
            x = 9;
            y = 11;

            // display values
            Console.Write("x = {0}\ny = {1}\nOutput:\n", x, y);

            // display output for part a
            if (x < 10)
                if (y > 10)
                    Console.WriteLine( "*****" );
                else
                    Console.WriteLine( "#####" );
            Console.WriteLine( "$$$$$\n" );

            // re-assign for part b
            x = 11;
            y = 9;

            // display values
            Console.Write("x = {0}\ny = {1}\nOutput:\n", x, y);

            //display output for part b
            if (x < 10)
                if (y > 10)
                    Console.WriteLine("*****");
                else
                    Console.WriteLine("#####");
            Console.WriteLine("$$$$$\n");

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
