using System;

namespace AccountTest
{
    class CheckingAccount : Account // derivative of account
    {
        // declarations
        private decimal transactionFee;

        // properties
        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            private set
            {
                transactionFee = value;
            }
        }

        // constructor
        public CheckingAccount(decimal initialBalance, decimal initialFee) : base(initialBalance)
        {
            TransactionFee = initialFee;
        }

        // Account CreditAccount() override
        override public void CreditAccount(decimal creditTotal)
        {
            if (creditTotal <= TransactionFee)
                Console.WriteLine("Fee exceeds deposit amount.");
            else
                base.CreditAccount(creditTotal - TransactionFee);
        }

        // Account DebitAccount() override
        override public void DebitAccount(decimal debitTotal)
        {
            if (debitTotal > 0)
                base.DebitAccount(debitTotal + TransactionFee);
        }
    }
}
