using System;

namespace Grouping4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;

            if (y == 8)
            {
                if (x == 5)
                    Console.WriteLine("@@@@@");
            }
            else
            {
                Console.WriteLine("#####");
                Console.WriteLine("$$$$$");
                Console.WriteLine("&&&&&");
            }

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
