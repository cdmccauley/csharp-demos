using System;

namespace AccountTest
{
    class SavingsAccount : Account // derivative of Account
    {
        // declarations
        private decimal interestRate;

        // properties
        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            private set
            {
                if (value > 0 && value <= 1)
                    interestRate = value;
                else
                {
                    interestRate = 0;
                    Console.WriteLine("Invalid interest rate entered. Interest rate set at {0}%", InterestRate);
                }
            }
        }

        // constructor
        public SavingsAccount(decimal initialBalance, decimal initialInterest) : base(initialBalance)
        {
            InterestRate = initialInterest;
        }

        // return investment returns
        public decimal CalculateInterest()
        {
            return (base.AccountBalance * InterestRate);
        }
    }
}
