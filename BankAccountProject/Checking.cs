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
            

        }

        //Methods

        public override string chooseAccount()
        {
            Console.WriteLine("Which account would you like to access today?\nChecking, Savings, or Reserve?");
            string accountTypeChecking = Console.ReadLine();
            accountTypeChecking = accountTypeChecking.ToLower();
            return accountTypeChecking;

        }

        public override double depositMethod(double depositAmount)
        {
            Console.WriteLine("How much would you like to deposit?");
            depositAmount = double.Parse(Console.ReadLine());
            this.checkingBalance += depositAmount;
            return base.depositMethod(depositAmount);
        }

        public override double withdrawMethod(double withdrawAmount)
        {
            Console.WriteLine("How much would you like to deposit?");
            withdrawAmount = double.Parse(Console.ReadLine());
            this.checkingBalance += withdrawAmount;
            return base.depositMethod(withdrawAmount);
        }
        

    }


}
