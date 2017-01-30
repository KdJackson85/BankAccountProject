using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Reserve : Accounts
    {
        //Fields
        private double reserveBalance;
        private double reserveInterest;
        private string accountTypeReserve;

        //Properties

        public double ReserveBalance
        {
            get { return reserveBalance; }
            set { this.reserveBalance = value; }
        }

        public double ReserveInterest
        {
            get { return reserveInterest; }
            set { this.reserveInterest = value; }
        }

        //Constructors

        public Reserve() : base()
        {
            this.reserveBalance = 8750;
            this.accountTypeReserve = "Reserve";


        }

        //Methods


        public override double depositMethod(double depositAmount)
        {
            Console.WriteLine("How much would you like to deposit?");
            depositAmount = double.Parse(Console.ReadLine());
            this.reserveBalance += depositAmount;
            return base.depositMethod(depositAmount);
        }

        public override double withdrawMethod(double withdrawAmount)
        {
            try
            {
                Console.WriteLine("How much would you like to withdraw?");
                withdrawAmount = double.Parse(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid expression.");

            }
            if (reserveBalance <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Insufficient funds. Unable to withdraw.");
                Console.WriteLine();

                return reserveBalance;
            }
            else
            {
                this.reserveBalance -= withdrawAmount;
                return base.depositMethod(withdrawAmount);
            }
        }


        public override void DisplayAccountStats()
        {
            Console.WriteLine();
            Console.WriteLine("Account type: " + accountTypeReserve);
            Console.WriteLine("Current Balance: " + "$" + reserveBalance);
            Console.WriteLine();

        }
    }
}
