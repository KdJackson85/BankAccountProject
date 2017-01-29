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
        private double checkBalance;
        private double interest;

        //Properties

        public double CheckBalance
        {
            get { return checkBalance; }
            set { this.checkBalance = value; }
        }

        public double Interest
        {
            get { return interest; }
            set { this.interest = value; }
        }

        //Constructors

        public Checking()
        {

        }
        
    }


}
