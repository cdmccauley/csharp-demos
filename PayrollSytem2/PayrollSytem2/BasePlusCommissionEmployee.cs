using System;

namespace PayrollSystem2
{
    class BasePlusCommissionEmployee : CommissionEmployee // derivative class
    {
        // declarations
        private decimal baseSalary;

        // constructor
        public BasePlusCommissionEmployee(string first, string last, string ssn, string bday, decimal sales, decimal rate, decimal salary) 
            : base(first, last, ssn, bday, sales, rate)
        {
            BaseSalary = salary;
        }

        // properties
        public decimal BaseSalary
        {
            get => baseSalary;
            private set => baseSalary = (value >= 0) ? value : throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
        }

        // Earnings() implementation
        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }

        // ToString() override
        public override string ToString()
        {
            return string.Format("base-salaried {0}; base salary: {1:C}", base.ToString(), BaseSalary);
        }
    }
}
