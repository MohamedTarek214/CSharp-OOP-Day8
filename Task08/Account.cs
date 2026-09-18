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
        private int AccountId;
        private string AccountHolder;
        private decimal Balance;
        #endregion

        #region Properties
        public int AccountIdProperty
        {
            get
            {
                return AccountId;
            }
            set
            {
                AccountId = value;
            }
        }

        public string AccountHolderProperty
        {
            get
            {

                return AccountHolder;
            }
            set
            {
                AccountHolder = value;
            }
        }

        public decimal BalanceProperty
        {
            get
            {
                return Balance;
            }
            set
            { Balance = value; }
        } 
        #endregion

    }
}
