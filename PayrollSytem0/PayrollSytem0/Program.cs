using System;

namespace PayrollSystem0
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            Employee[] employees = new Employee[5];

            // construct employees
            employees[0] = new SalariedEmployee("John", "Smith", "111-11-1111", "5/1/1970", 800.00M);
            employees[1] = new HourlyEmployee("Karen", "Price", "222-22-2222", "10/2/1980", 16.75M, 40.0M);
            employees[2] = new CommissionEmployee("Sue", "Jones", "333-33-3333", "6/3/1990", 10000.00M, .06M);
            employees[3] = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", "1/4/1965", 5000.00M, .04M, 300.00M);
            employees[4] = new PieceWorker("Michael", "DeSanto", "555-55-5555", "7/9/1985", 20.00M, 39);

            foreach (Employee selectedEmployee in employees)
                Console.WriteLine("{0}\nEarnings: {1:C}\n", selectedEmployee.ToString(), selectedEmployee.Earnings());

            // hold console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}