using System;
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
        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="accountName">Name for your account</param >
        /// <param name="ssn">Your Social Security number</param>
        /// <param name="typeofAccount"> your Type of your account</param>
        /// <returns> A new account</returns>
        public static Account createAccount(string accountName, int ssn,AccountType typeofAccount)

        {
            var account = new Account
            {
                AccountName = accountName,
                SSN = ssn,
                TypeofAccount = typeofAccount
            };
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }
      
    }
}
