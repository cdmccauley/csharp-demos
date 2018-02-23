using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            int number1, number2;
            int sum, product, difference, quotient;

            // get input
            Console.Write("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            // process input and display results
            sum = number1 + number2;
            Console.WriteLine("The sum of {0} and {1} is {2}", number1, number2, sum);
            product = number1 * number2;
            Console.WriteLine("The product of {0} and {1} is {2}", number1, number2, product);
            difference = number1 - number2;
            Console.WriteLine("The difference of {0} and {1} is {2}", number1, number2, difference);
            quotient = number1 / number2;
            Console.WriteLine("The quotient of {0} and {1} is {2}", number1, number2, quotient);

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
