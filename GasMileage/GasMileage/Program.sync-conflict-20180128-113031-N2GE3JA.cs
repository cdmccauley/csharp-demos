using System;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles, totalMiles, gallons, totalGallons, counter;
            double average, totalAverage;

            miles = 0;
            totalMiles = 0;
            gallons = 0;
            totalGallons = 0;
            counter = 0;

            Console.WriteLine("Enter miles or -1 to quit: ");
            miles = Convert.ToInt32(Console.ReadLine());
            if (miles != -1)
            {
                Console.WriteLine("Enter gallons or -1 to quit: ");
                gallons = Convert.ToInt32(Console.ReadLine());
            }

            while (miles != -1 && gallons != -1)
            {
                average = (double)miles / (double)gallons;
                Console.WriteLine("Tank: {0:F} MPG", (decimal)average);
                totalMiles += miles;
                totalGallons += gallons;
                totalAverage += average;
                counter++;
                Console.WriteLine("Enter miles or -1 to quit: ");
                miles = Convert.ToInt32(Console.ReadLine());
                if (miles != -1)
                {
                    Console.WriteLine("Enter gallons or -1 to quit: ");
                    gallons = Convert.ToInt32(Console.ReadLine());
                }
            }
            totalAverage = ((double)totalMiles / (double)totalGallons) / (double)counter;

            Console.WriteLine("All tanks: {0:F} MPG", (decimal)totalAverage);

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
