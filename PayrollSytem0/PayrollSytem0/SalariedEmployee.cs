using System;

namespace PayrollSystem0
{
    class SalariedEmployee : Employee // derivative class
    {
        // declarations
        private decimal weeklySalary;

        // constructor
        public SalariedEmployee(string first, string last, string ssn, string bday, decimal salary) : base(first, last, ssn, bday)
        {
            WeeklySalary = salary;
        }

        // properties
        public decimal WeeklySalary
        {
            get => weeklySalary;
            private set
            {
                weeklySalary = (value >= 0) ? value :
                    throw new ArgumentOutOfRangeException("WeeklySalary", value, "WeeklySalary must be >= 0");
            }
        }

        // Earnings() implementation
        public override decimal Earnings()
        {
            return WeeklySalary;
        }

        // ToString() override
        public override string ToString()
        {
            return string.Format("salaried employee: {0}\n{1}: {2:C}", base.ToString(), "weekly salary", WeeklySalary);
        }
    }
}