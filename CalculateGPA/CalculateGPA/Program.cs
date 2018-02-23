using System;

namespace CalculateGPA
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            int grades = 0, average;

            // get input
            for (int i = 1; i <= 4; ++i)
            {
                do
                {
                    Console.Write("Enter a grade: ");
                    grades += Convert.ToInt32(Console.ReadLine());
                } while (grades < 0 && grades > 100);
            }

            // process input
            average = grades / 4;

            // display output
            if (average >= 90)
                Console.WriteLine("4");
            if (average >= 80 && average < 90)
                Console.WriteLine("3");
            if (average >= 70 && average < 80)
                Console.WriteLine("2");
            if (average >= 60 && average < 70)
                Console.WriteLine("1");
            if (average < 60)
                Console.WriteLine("0");

            // hold console
            Console.WriteLine("\nPress any key to close console window...");
            Console.ReadKey();
        }
    }
}
