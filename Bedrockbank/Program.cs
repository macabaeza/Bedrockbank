﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedrockbank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to Bedrock bank ****");
            string option;
            do
            {


                Console.WriteLine("1.Create an account");
                Console.WriteLine("2. Deposite into an account");
                Console.WriteLine("3. Print account");
                Console.WriteLine("0.Exit");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("What is the name of the account?");
                        var accountName = Console.ReadLine();
                        var account1 = Bank.createAccount(accountName, 123343, AccountType.Checking);
                        Console.WriteLine("Account Name: {0}, Number: {1}, Type of Account:{2}, Balance: {3:c}",
               account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance);
                        break;
                    case "2":
                        break;
                    case "3":
                       // PrintAccounts();
                        break;
                    case "0":
                        Console.WriteLine("Good bye!");
                        return;
                    default:
                        break;
                }
            } while (option != "0");


        }

        //static void PrintAccounts()
        //{
        //    foreach (var account in Bank.accounts)
        //    {
        //        Console.WriteLine("Id:{0}, Name:{1}",
        //            account.AccountNumber, account.AccountName);
        //    }
        //}
    }
}
            
        

        
    
