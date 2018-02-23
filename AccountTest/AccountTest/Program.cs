using System;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            Account[] accounts = new Account[6];
            decimal actionAmount;

            // construct accounts
            accounts[0] = new CheckingAccount(1000M, 1.50M);
            accounts[1] = new SavingsAccount(50M, .06M);
            accounts[2] = new CheckingAccount(50M, 1.50M);
            accounts[3] = new SavingsAccount(100M, .06M);
            accounts[4] = new CheckingAccount(100M, 1.50M);
            accounts[5] = new SavingsAccount(1000M, .06M);

            // interact with each account automatically applying interest earned to savings accounts
            foreach (Account selectedAccount in accounts)
            {
                if (selectedAccount is CheckingAccount)
                    Console.Write("Checking ");
                else
                    Console.Write("Savings ");
                Console.Write("account balance: {0:C}\nEnter amount to withdraw: $", selectedAccount.AccountBalance);
                actionAmount = Convert.ToDecimal(Console.ReadLine());
                selectedAccount.DebitAccount(actionAmount);
                Console.WriteLine("Account balance: {0:C}", selectedAccount.AccountBalance);
                if (selectedAccount is CheckingAccount)
                {
                    Console.Write("Enter amount to deposit: $");
                    actionAmount = Convert.ToDecimal(Console.ReadLine());
                    selectedAccount.CreditAccount(actionAmount);
                    Console.WriteLine("Account balance: {0:C}\n", selectedAccount.AccountBalance);
                }
                else
                {
                    SavingsAccount accountInterest = (SavingsAccount)selectedAccount;

                    Console.WriteLine("Savings account has grown by {0:C}.", accountInterest.CalculateInterest());
                    selectedAccount.CreditAccount(accountInterest.CalculateInterest());
                    Console.WriteLine("Account balance: {0:C}\n", selectedAccount.AccountBalance);
                }
            }

            // hold
            Console.WriteLine("End of program, press any key to exit...");
            Console.ReadKey();
        }
    }
}
