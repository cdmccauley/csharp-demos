using System;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            NegativeNumberException negativeNumError = new NegativeNumberException("Negative numbers not valid.");
            bool error;
            decimal miles = 0, gallons = 0, mpg;

            // get input for miles till valid, prevent 0, throw and handle for negative, and handle FormatExceptions
            do
            {
                error = false;
                try
                {
                    Console.Write("Enter miles traveled: ");
                    miles = Convert.ToDecimal(Console.ReadLine());
                    if (miles == 0)
                        Console.WriteLine("Input must be greater than 0.");
                    else if (miles < 0)
                        throw negativeNumError;
                }
                catch (Exception e)
                {
                    error = true;
                    Console.WriteLine(e.Message);
                }
            } while (miles <= 0 || error);

            // get input for gallons till valid, prevent 0, throw and handle for negative, and handle FormatExceptions
            do
            {
                error = false;
                try
                {
                    Console.Write("Enter gallons used: ");
                    gallons = Convert.ToDecimal(Console.ReadLine());
                    if (gallons == 0)
                        Console.WriteLine("Input must be greater than 0.");
                    else if (gallons < 0)
                        throw negativeNumError;
                }
                catch (Exception e)
                {
                    error = true;
                    Console.WriteLine(e.Message);
                }
            } while (gallons <= 0 || error);

            // process input
            mpg = miles / gallons;

            // display output
            Console.WriteLine("\n{0} miles traveled using {1} gallons is {2:0.##} miles per gallon.", miles, gallons, mpg);

            // hold console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
