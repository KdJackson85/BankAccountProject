using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings : Accounts
    {
        //Fields
        private double savingsBalance;
        private double savingsInterest;
        private string accountTypeSavings;

        //Properties

        public double SavingsBalance
        {
            get { return savingsBalance; }
            set { this.savingsBalance = value; }
        }

        public double SavingsInterest
        {
            get { return savingsInterest; }
            set { this.savingsInterest = value; }
        }

        //Constructors

        public Savings() :base()
        {
            this.savingsBalance = 1250;
            this.accountTypeSavings = "Savings";


        }

        //Methods


        public override double depositMethod(double depositAmount)
        {
            Console.WriteLine("How much would you like to deposit?");
            depositAmount = double.Parse(Console.ReadLine());
            this.savingsBalance += depositAmount;
            return base.depositMethod(depositAmount);
        }

        public override double withdrawMethod(double withdrawAmount)
        {
            Console.WriteLine("How much would you like to withdraw?");
            withdrawAmount = double.Parse(Console.ReadLine());
            if (savingsBalance <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Insufficient funds. Unable to withdraw.");
                Console.WriteLine();

                return savingsBalance;
            }
            else
            {
                this.savingsBalance -= withdrawAmount;
                return base.depositMethod(withdrawAmount);
            }
        }


        public override void DisplayAccountStats()
        {
            Console.WriteLine();
            Console.WriteLine("Account type: " + accountTypeSavings);
            Console.WriteLine("Current Balance: " + "$" + savingsBalance);
            Console.WriteLine();
        }
    }
}
