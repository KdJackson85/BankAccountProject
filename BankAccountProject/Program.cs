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
            //Objex
            Checking myChecking = new Checking();
            Savings mySavings = new Savings();
            Reserve myReserve = new Reserve(); 
            Accounts myAccount = new Accounts();

            Console.WriteLine("Welcome to The First National Bank of Keith!");
            Console.WriteLine();
            //bool used in do-while loop
            bool cycleAccount = true;
            //do-while loop cycles through program
            do
            {
                Console.WriteLine("Which account would you like to access today?\nChecking, Savings, or Reserve?");
                string accountType = Console.ReadLine();
                accountType = accountType.ToLower();
                if (accountType == "checking") //Checking account functions
                {
                    myChecking.DisplayAccountStats();
                    Console.WriteLine("What action would you like to take?\nWithdraw funds\nDeposit funds");
                    Console.WriteLine();
                    string checkingAction = Console.ReadLine();
                    checkingAction = checkingAction.ToLower();
                    if (checkingAction == "withdraw")
                    {
                        myChecking.withdrawMethod(0);
                        myChecking.DisplayAccountStats();
                    }
                    else if(checkingAction =="deposit")
                    {
                        myChecking.depositMethod(0);
                        myChecking.DisplayAccountStats();
                    }
                    else 
                    {
                        Console.WriteLine("Error: Invalid response.");
                        Console.WriteLine();
                    }
                
                }
              
                else if(accountType=="savings")  //Savings Account functions
                {
                    mySavings.DisplayAccountStats();
                    Console.WriteLine("What action would you like to take?\nWithdraw funds\nDeposit funds");
                    Console.WriteLine();
                    string savingsAction = Console.ReadLine();
                    savingsAction = savingsAction.ToLower();
                    if (savingsAction == "withdraw")
                    {
                        mySavings.withdrawMethod(0);
                        mySavings.DisplayAccountStats();
                    }
                    else if (savingsAction == "deposit")
                    {
                        mySavings.depositMethod(0);
                        mySavings.DisplayAccountStats();
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid response.");
                        Console.WriteLine();
                    }
 
                }
                else if(accountType=="reserve")  //Reserve Account functions
                {
                    myReserve.DisplayAccountStats();
                    Console.WriteLine("What action would you like to take?\nWithdraw funds\nDeposit funds");
                    Console.WriteLine();
                    string reserveAction = Console.ReadLine();
                    reserveAction = reserveAction.ToLower();
                    if (reserveAction == "withdraw")
                    {
                        myReserve.withdrawMethod(0);
                        myReserve.DisplayAccountStats();
                    }
                    else if (reserveAction == "deposit")
                    {
                        myReserve.depositMethod(0);
                        myReserve.DisplayAccountStats();
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid response.");
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Error: Invalid response.");
                    Console.WriteLine();
                }

            } while (cycleAccount == true);


                Console.ReadKey();
            
        }
    }
}
