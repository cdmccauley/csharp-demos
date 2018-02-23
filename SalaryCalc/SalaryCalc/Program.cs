using System;

namespace SalaryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            int employee = 1;
            decimal payRate, hoursWorked = 0.0m, grossPay;

            // get input
            Console.Write("Enter pay rate for employee {0} or -1 to quit: ", employee);
            payRate = Convert.ToDecimal(Console.ReadLine());
            if (payRate != -1)
            {
                Console.Write("Enter hours worked for employee {0} or -1 to quit: ", employee);
                hoursWorked = Convert.ToDecimal(Console.ReadLine());
            }

            // process input
            while (payRate != -1 && hoursWorked != -1)
            {
                if (hoursWorked > 40.0m)
                {
                    hoursWorked -= 40.0m;
                    grossPay = (40.0m * payRate);
                    grossPay += (hoursWorked * (payRate + (payRate * 0.5m)));
                }
                else
                {
                    grossPay = (hoursWorked * payRate);
                }
                // display output
                Console.WriteLine("Employee {0} earned ${1:F} this week.\n", employee, grossPay);
                employee++;

                // get more input
                Console.Write("Enter pay rate for employee {0} or -1 to quit: ", employee);
                payRate = Convert.ToDecimal(Console.ReadLine());
                if (payRate != -1)
                {
                    Console.Write("Enter hours worked for employee {0} or -1 to quit: ", employee);
                    hoursWorked = Convert.ToDecimal(Console.ReadLine());
                }
            }

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
