using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Accounts
    {
        //***Fields***
        protected double deposit;
        protected double withdrawal;
        protected double interest;
        protected double balance;


        //Constructors//

        public Accounts()
        {
            double balance = (1000.00);
        }

        public Accounts(double deposit, double withdrawal, double interest)
        {
            this.deposit = deposit;
            this.withdrawal = withdrawal;
            this.interest = interest;
            double startingBalance = (1000.00);
        }

        //Properties//

        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public double Withdrawal
        {
            get { return this.withdrawal; }
            set { this.withdrawal = value; }
        }

        public double Interest
        {
            get { return this.interest; }
            set { this.interest = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }




        //Methods

        public void getBalance()
        {
            bool cycleAccount = true;
            balance = (1000.00);

            do
            {
                Console.WriteLine("Which type of action would you like to perform? Deposit or Withdraw?");
                string userInput = (Console.ReadLine());
                userInput = userInput.ToLower();
                if (userInput == "deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    deposit = double.Parse(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine("your current balance is: " + balance);

                    Console.WriteLine();
                    continue;
                }
                else if (userInput == "withdraw")
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    withdrawal = double.Parse(Console.ReadLine());

                    if (balance <= 0)
                    {
                        Console.WriteLine("Insufficient funds. Unable to withdraw.");
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        balance -= withdrawal;
                        Console.WriteLine("Your current balance is: " + balance);
                        Console.WriteLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("invalid response");
                    Console.WriteLine();

                }
            } while (cycleAccount == true);
        }

    }

}
