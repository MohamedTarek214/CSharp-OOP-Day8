using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public struct Account
    {
        #region Attributes
        private int accountId;
        private string accountHolder;
        private decimal balance;
        #endregion

        #region Properties
        public int AccountId
        {
            get
            {
                return accountId;
            }
            set
            {
                accountId = value;
            }
        }

        public string AccountHolder
        {
            get
            {

                return accountHolder;
            }
            set
            {
                accountHolder = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            { balance = value; }
        } 
        #endregion

    }
}
