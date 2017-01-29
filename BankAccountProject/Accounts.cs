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
        private double deposit;
        private double withdrawal;
        private double balance;
        private string accountType;
        private string firstName;
        private string lastName;


        //Constructors//

        public Accounts()
        {
            this.balance = (1000.00);
        }

        public Accounts(double deposit, double withdrawal, double interest)
        {
            this.deposit = deposit;
            this.withdrawal = withdrawal; 
            this.balance = (1000.00);
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

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
        }

        public string FullName
        {
            get { return this.firstName + "" + this.lastName; }
        }




        //Methods

        public virtual string chooseAccount()
        {
            Console.WriteLine("Which account would you like to access today?\nChecking, Savings, or Reserve?");
            string accountType = Console.ReadLine();
            accountType = accountType.ToLower();
            return accountType; 
            
        }

        public virtual double depositMethod(double depositAmount)
        {
            this.balance += depositAmount;
            return balance;
        }

        public virtual double withdrawMethod(double withdrawAmount)
        {
            this.balance -= withdrawAmount;
            return balance;
        }



    }

}


