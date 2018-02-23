using System;

namespace DateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            Date testDate0 = new Date(2, 27, 2018);
            Date testDate1 = new Date(2, 28, 1904);
            Date testDate2 = new Date(12, 30, 1985);

            // call Date.AddDays() which will call Date.NextDay()
            Console.WriteLine("\ntestDate0: {0}", testDate0.ToString());
            testDate0.AddDays(3);
            Console.WriteLine("\ntestDate1: {0}", testDate1.ToString());
            testDate1.AddDays(3);
            Console.WriteLine("\ntestDate2: {0}", testDate2.ToString());
            testDate2.AddDays(3);

            // hold console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
