using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Accounts

    {
        //Fields
        private double checkingBalance;
        private double checkingInterest;
        private string accountTypeChecking;

        //Properties

        public double CheckingBalance
        {
            get { return checkingBalance; }
            set { this.checkingBalance = value; }
        }

        public double CheckingInterest
        {
            get { return checkingInterest; }
            set { this.checkingInterest = value; }
        }

        //Constructors

        public Checking() :base()
        {
            this.checkingBalance = 500;
            this.accountTypeChecking = "Checking";
            

        }

        //Methods

       
        public override double depositMethod(double depositAmount)
        {
            Console.WriteLine("How much would you like to deposit?");
            depositAmount = double.Parse(Console.ReadLine());
            this.checkingBalance += depositAmount;
            return base.depositMethod(depositAmount);
        }

        public override double withdrawMethod(double withdrawAmount)
        {
            Console.WriteLine("How much would you like to withdraw?");
            withdrawAmount = double.Parse(Console.ReadLine());
            if (checkingBalance <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Insufficient funds. Unable to withdraw.");
                Console.WriteLine();

                return checkingBalance;
            }
            else
            {
                this.checkingBalance -= withdrawAmount;
                return base.depositMethod(withdrawAmount);
            }
        }


        public override void DisplayAccountStats()
        {
            Console.WriteLine();
            Console.WriteLine("Account type: " + accountTypeChecking);
            Console.WriteLine("Current Balance: " + "$" + checkingBalance);
            Console.WriteLine();
        }


    }


}
