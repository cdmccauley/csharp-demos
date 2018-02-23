using System;
using System.Collections.Generic;

namespace AccountTest
{
    class Account
    {
        // declarations
        private decimal accountBalance;

        // properties
        public decimal AccountBalance
        {
            get
            {
                return accountBalance;
            }
            private set
            {
                if (value >= 0)
                    accountBalance = decimal.Round(value, 2);
                else
                    Console.WriteLine("Starting balance must be non-negative.");
            }
        }

        // constructor
        public Account(decimal initialBalance)
        {
            AccountBalance = initialBalance;
        }

        // increment account balance
        virtual public void CreditAccount(decimal creditTotal)
        {
            if (creditTotal > 0)
                AccountBalance += creditTotal;
            else
                Console.WriteLine("Amount to credit must be greater than {0:C}.", 0);
        }

        // decrement account balance
        virtual public void DebitAccount(decimal debitTotal)
        {
            if (AccountBalance - debitTotal > 0)
                AccountBalance -= debitTotal;
            else
                Console.WriteLine("Debit amount exceeded account balance.");
        }
    }
}