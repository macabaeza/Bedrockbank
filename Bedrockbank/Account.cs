﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedrockbank
{
    public enum AccountType
    {
        Savings,
        Checking,
        CD
    }

    /// <summary>
    /// This is about a
    /// Bank account
    /// </summary>
    public class Account
    {
        #region Variables
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties

        /// <summary>
        /// Name of the account
        /// </summary>
        [StringLength(10, ErrorMessage = "Account name cannot be more than 10 character length.")]
        public string AccountName { get; set; }
        /// <summary>
        /// Account number for the account
        /// </summary>
        [Key]
        public int AccountNumber { get; private set; }
        public int SSN { get; set; }
        public double Balance { get; private set; }
        public AccountType TypeofAccount { get; set; }
        // building a virtual relationship with Account assosiated to one Customer 
        // do not need to have customer Id here in account.cs
        public virtual Customer Customer { get; set; }
        #endregion
        #region Constructor
        public Account()
        {
            // lastAccountNumber = lastAccountNumber + 1;
            // AccountNumber = lastAccountNumber;
            AccountNumber = ++lastAccountNumber;
        }
        #endregion
        #region Methods
        public double Deposite (double amount)
        {
            // Balance = Balance + amount;
            Balance += amount;
            return Balance;
        }

        #endregion
    }
}
