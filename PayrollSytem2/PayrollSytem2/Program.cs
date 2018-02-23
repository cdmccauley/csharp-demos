using System;

namespace PayrollSystem2
{
    class Program
    {
        // map month names to integers
        enum MonthNames { January = 1, February, March, April, May, June, July, August, September, October, November, December }

        static void Main(string[] args)
        {
            // declarations
            Employee[] employees = new Employee[5];
            Date tempDate;

            // construct employees
            employees[0] = new SalariedEmployee("John", "Smith", "111-11-1111", "5/1/1970", 800.00M);
            employees[1] = new HourlyEmployee("Karen", "Price", "222-22-2222", "10/2/1980", 16.75M, 40.0M);
            employees[2] = new CommissionEmployee("Sue", "Jones", "333-33-3333", "6/3/1990", 10000.00M, .06M);
            employees[3] = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", "1/4/1965", 5000.00M, .04M, 300.00M);
            employees[4] = new HourlyEmployee("Michael", "DeSanto", "555-55-5555", "7/9/1985", 20.00M, 45.0M);

            // display payroll
            for (MonthNames month = MonthNames.January; month <= MonthNames.December; ++month)
            {
                Console.WriteLine("{0} payroll:", month);
                foreach (Employee selectedEmployee in employees)
                {
                    tempDate = (Date)selectedEmployee.BirthDate;
                    if (tempDate.Month == (int)month) // eligible for birth month bonus
                        Console.WriteLine("{0}, {1} earned {2:C}.", selectedEmployee.LastName, selectedEmployee.FirstName, selectedEmployee.Earnings() + 100.00M);
                    else // regular pay
                        Console.WriteLine("{0}, {1} earned {2:C}.", selectedEmployee.LastName, selectedEmployee.FirstName, selectedEmployee.Earnings());
                }
                Console.WriteLine();
            }

            // hold console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
