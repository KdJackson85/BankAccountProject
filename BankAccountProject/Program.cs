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
            
                Accounts myAccount = new Accounts();
                myAccount.getBalance();
                Console.ReadKey();
            
        }
    }
}
