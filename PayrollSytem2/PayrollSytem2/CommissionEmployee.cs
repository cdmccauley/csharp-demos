using System;

namespace PayrollSystem2
{
    class CommissionEmployee : Employee // derivative class
    {
        // declarations
        private decimal grossSales;
        private decimal commissionRate;

        // constructor
        public CommissionEmployee(string first, string last, string ssn, string bday, decimal sales, decimal rate) : base(first, last, ssn, bday)
        {
            GrossSales = sales;
            CommissionRate = rate;
        }

        // properties
        public decimal GrossSales
        {
            get => grossSales;
            private set => grossSales = (value >= 0) ? value : throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >= 0");
        }

        public decimal CommissionRate
        {
            get => commissionRate;
            private set => commissionRate = (value > 0 && value < 1) ? value : throw new ArgumentOutOfRangeException("CommissionRate", value, "CommissionRate must be > 0 and < 1");
        }

        // Earnings() implementation
        public override decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }

        // ToString() override
        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", "commission employee", base.ToString(), "gross sales", GrossSales, "commission rate", CommissionRate);
        }
    }
}
