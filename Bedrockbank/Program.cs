using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            Customer customer;
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

                        customer = VerifyCustomer();
                        try
                        {
                            Console.Write("What is the name of the account?");
                            var accountName = Console.ReadLine();

                            var account1 = Bank.createAccount(accountName, 123343,
                                AccountType.Checking, customer);
                            Console.WriteLine("Account Name: {0}, Number: {1}, Type of Account:{2}, Balance: {3:c},customer:{4}",
                   account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance, account1.Customer);

                        }

                        catch (DbEntityValidationException dx)
                        {
                            Console.WriteLine("Failed creating an account - {0}", dx.Message);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                       
                        break;
                    case "2":
                        customer = VerifyCustomer();
                        Console.Write("How much do you want to deposit?");
                        var amount = Console.ReadLine();
                        int convertedAmount;
                        if(int.TryParse(amount, out convertedAmount)== true)
                        {


                        }

                        break;
                    case "3":
                        customer = VerifyCustomer();
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

        private static Customer VerifyCustomer()
        {
            Console.Write(" What is your email addrees?");
            var emailAddress = Console.ReadLine();

            var customer = Bank.findCustomer(emailAddress);
            if (customer == null)
            {
                Console.Write(" What is your name?");
                var name = Console.ReadLine();
                customer = Bank.CreateCustomer(name, emailAddress);
            }

            return customer;
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
            
        

        
    
