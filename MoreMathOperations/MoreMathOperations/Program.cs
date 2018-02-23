using System;

namespace MoreMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int number1, number2, number3, sum, average, product, smallest, largest;

            //get input
            Console.Write("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number3 = int.Parse(Console.ReadLine());

            //process input and display results
            sum = number1 + number2 + number3;
            Console.WriteLine("The sum of {0}, {1}, and {2} is {3}", number1, number2, number3, sum);

            average = sum / 3;
            Console.WriteLine("The average of {0}, {1}, and {2} is {3}", number1, number2, number3, average);

            product = number1 * number2 * number3;
            Console.WriteLine("The product of {0}, {1}, and {2} is {3}", number1, number2, number3, product);

            if (number1 < number2 && number1 < number3)
            {
                smallest = number1;
            } else if (number2 < number1 && number2 < number3)
            {
                smallest = number2;
            } else
            {
                smallest = number3;
            }
            Console.WriteLine("The smallest value of {0}, {1}, and {2} is {3}", number1, number2, number3, smallest);

            if (number1 > number2 && number1 > number3)
            {
                largest = number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                largest = number2;
            }
            else
            {
                largest = number3;
            }
            Console.WriteLine("The largest value of {0}, {1}, and {2} is {3}", number1, number2, number3, largest);

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
