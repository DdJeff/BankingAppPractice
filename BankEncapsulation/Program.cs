using System;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double deposit)
        {
            balance = deposit;
        }

        public double GetBalence()
        {
            return balance;
        }

        public double Withdrawal(double withdrawal)
        {
                balance = balance - withdrawal; //taking out monies

                return balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            {
                Console.WriteLine(myAccount.GetBalence());
                myAccount.Deposit(100.00);

                Console.WriteLine();
                Console.WriteLine(myAccount.GetBalence());

                Console.WriteLine();
                myAccount.Withdrawal(50.00);

                Console.WriteLine();
                Console.WriteLine(myAccount.GetBalence());

            }
        }
    }
}
