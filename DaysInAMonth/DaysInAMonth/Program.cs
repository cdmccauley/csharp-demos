using System;

namespace DaysInAMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            int year, month, days;

            // get input
            Console.Write("Enter a year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a month: ");
            month = Convert.ToInt32(Console.ReadLine());

            // process
            if (month == 2)
            {
                if (year % 4 == 0)
                {
                    days = 29;
                    if (year / 100 == (double)year / 100.0)
                    {
                        days = 28;
                        if (year / 400 == (double)year / 400.0)
                        {
                            days = 29;
                        }
                    }
                }
                else
                {
                    days = 28;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                days = 30;
            }
            else
            {
                days = 31;
            }

            // output
            Console.WriteLine("There are {0} days in {1}/{2}.", days, month, year);

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
