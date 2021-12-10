using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class AccountType
    {
        private int ID;

        private string AccountTypeName;

        private bool Status;

        List<Account> Accounts { get; set; }

        public int Id   // property
        {
            get { return ID; }   // get method
            set { ID = value; }  // set method
        }

        public string accounttypeName   // property
        {
            get { return AccountTypeName; }   // get method
            set { AccountTypeName = value; }  // set method
        }

        public bool status   // property
        {
            get { return Status; }   // get method
            set { Status = value; }  // set method
        }
    }
}
