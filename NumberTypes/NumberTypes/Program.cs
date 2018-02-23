using System;

namespace NumberTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int target, result, accumulator;
            string sentinel;

            do
            {
                // set accumulator
                accumulator = 0;

                // get input
                Console.Write("Enter a number: ");
                target = Convert.ToInt32(Console.ReadLine());

                // find and accumulate factors
                for (int i = 1; i < target; i++)
                {
                    result = target % i;
                    if (result == 0)
                    {
                        accumulator += i;
                    }
                }

                // test number type
                if (accumulator == 1)
                {
                    Console.WriteLine("{0} is a prime number.", target);
                }
                else if (accumulator < target)
                {
                    Console.WriteLine("{0} is a deficient number.", target);
                }
                if (accumulator == target)
                    Console.WriteLine("{0} is a perfect number.", target);
                if (accumulator > target)
                    Console.WriteLine("{0} is an abundant number.", target);

                // option to exit
                Console.Write("Press ENTER to continue or type 'q' to quit: ");
                sentinel = Console.ReadLine();

            } while (sentinel != "q");
        }
    }
}
