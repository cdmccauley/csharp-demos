using System;

namespace SquaresAndCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            int x = 0;

            // process and display results
            Console.WriteLine("Number\tSquare\tCube");
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 1;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 2;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 3;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 4;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 5;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 6;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 7;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 8;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 9;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));
            x = 10;
            Console.WriteLine("{0}\t{1}\t{2}", x, (x * x), (x * x * x));

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
