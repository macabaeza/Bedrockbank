using System;
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
            // Creating a instance of Account
            var account1 = new Account();
            account1.AccountName = "My checking";
            account1.TypeofAccount = AccountType.Checking;
            //account1.Balance = 100000000;
           // account1.AccountNumber = 123456 ;
            account1.Deposite(300.00);
            Console.WriteLine("Account Name: {0}, Number: {1}, Type of Account:{2}, Balance: {3:c}",
            account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance);

            var account2 = new Account();
            account2.AccountName = "My savings";
            account2.TypeofAccount = AccountType.Savings;
            //account1.Balance = 100000000;
            // account1.AccountNumber = 123456 ;
            account2.Deposite(100.00);
            Console.WriteLine("Account Name: {0}, Number: {1}, Type of Account:{2}, Balance: {3:c}",
            account2.AccountName, account2.AccountNumber, account2.TypeofAccount, account2.Balance);


        }
    }
}
