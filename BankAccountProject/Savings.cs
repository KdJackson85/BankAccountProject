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

        //Properties

        public double SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = value; }
        }

        public double SavingsInterest
        {
            get { return this.savingsInterest; }
            set { this.savingsInterest = value; }
        }

    }
}
