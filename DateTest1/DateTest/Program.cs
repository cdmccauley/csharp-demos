using System;

namespace DateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //// declarations
            //Date currentDate = new Date(26, 1, 2018);
            //Date birthDate = new Date(9, 6, 1985);
            //Date midterm2018 = new Date(6, 11, 2018);

            //// output
            //Console.WriteLine("This app was created on {0}.\n", currentDate.DisplayDate());
            //Console.WriteLine("The app creator was born on {0}.\n", birthDate.DisplayDate());
            //Console.WriteLine("Remember to vote in the midterm elections on {0}!\n", midterm2018.DisplayDate());

            int row = 10;
            int column;

            while (row >= 1)
            {
                column = 1;

                while (column <= 10)
                {
                    Console.Write(row % 2 == 1 ? "<" : ">");
                    ++column;
                }

                --row;
                Console.WriteLine();
            }

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
