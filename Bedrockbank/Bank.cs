﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedrockbank
{
   public static class Bank
    {

        #region variables
        private static BankModel db = new BankModel();

        #endregion

        public static Customer findCustomer(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new ArgumentNullException
                    ("email address cannot be empty.");
            }
           return db.Customers.Where(
               c => c.CustomerEmail == emailAddress)
               .FirstOrDefault();
        }
        public static Customer CreateCustomer(string name, string emailAddress)
        {
            var customer = new Customer
            {
                CustomerName = name,
                CustomerEmail = emailAddress
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }
        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="accountName">Name for your account</param >
        /// <param name="ssn">Your Social Security number</param>
        /// <param name="typeofAccount"> your Type of your account</param>
        /// <returns> A new account</returns>
       
            /// // i need to create an account associated to a Customer
        public static Account createAccount(string accountName, int ssn,
            AccountType typeofAccount, Customer customer)

        {
            var account = new Account
            {
                AccountName = accountName,
                SSN = ssn,
                TypeofAccount = typeofAccount,
                Customer = customer
                
            };
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }
      
    }
}
