using System;

namespace PayrollSystem2
{
    class HourlyEmployee : Employee // derivative class
    {
        // declarations
        private decimal wage;
        private decimal hours;

        // constructor
        public HourlyEmployee(string first, string last, string ssn, string bday, decimal hourlyWage, decimal hoursWorked) 
            : base(first, last, ssn, bday)
        {
            Wage = hourlyWage;
            Hours = hoursWorked;
        }

        // properties
        public decimal Wage
        {
            get => wage;
            private set => wage = (value >= 0) ? value : throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");
        }

        public decimal Hours
        {
            get => hours;
            private set => hours = (value >= 0 && value <= 168) ? value : throw new ArgumentOutOfRangeException("Hours", value, "Hours must be >= 0 and <= 168");
        }

        // Earnings implementation
        public override decimal Earnings()
        {
            return (Hours <= 40) ? Wage * Hours : (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }

        // ToString() override
        public override string ToString()
        {
            return string.Format("hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), "hourly wage", Wage, "hours worked", Hours);
        }
    }
}
