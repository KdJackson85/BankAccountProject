using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking myChecking = new Checking();
            Savings mySavings = new Savings();
            Reserve myReserve = new Reserve();
            
                Accounts myAccount = new Accounts();
               
                Console.ReadKey();
            
        }
    }
}
