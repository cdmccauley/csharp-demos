using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fTemp, cTemp;

            Random randomNumbers = new Random();
            int n;

            do
            {
                n = randomNumbers.Next(-3, 12);
                Console.WriteLine(n);
            } while (n != 11);

            Console.Write("Enter temperature in Fahrenheit: ");
            fTemp = Convert.ToDouble(Console.ReadLine());

            cTemp = (5.0 / 9.0 * (fTemp - 32.0));
            Console.WriteLine("{0} degrees Fahrenheit is {1:F} degrees Celsius", fTemp, cTemp);

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
