using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Account
    {
        private int ID;

        private string Username;

        private string Email;

        private string Fullname;

        private string Password;

        private DateTime Birthday;

        private int AccountType_Id;

        private AccountType AccountType;

        List<Comment> Comments { get; set; }

        List<Post> Posts { get; set; }

        private bool Status;

        public int Id   // property
        {
            get { return ID; }   // get method
            set { ID = value; }  // set method
        }

        public string username   // property
        {
            get { return Username; }   // get method
            set { Username = value; }  // set method
        }

        public string email   // property
        {
            get { return Email; }   // get method
            set { Email = value; }  // set method
        }

        public string fullname   // property
        {
            get { return Fullname; }   // get method
            set { Fullname = value; }  // set method
        }

        public string password   // property
        {
            get { return Password; }   // get method
            set { Password = value; }  // set method
        }

        public DateTime birthday   // property
        {
            get { return Birthday; }   // get method
            set { Birthday = value; }  // set method
        }

        public int accounttype_Id
        {
            get { return AccountType_Id; }   // get method
            set { AccountType_Id = value; }  // set method
        }

        public AccountType accounttype
        {
            get { return AccountType; }   // get method
            set { AccountType = value; }  // set method
        }

        public bool status
        {
            get { return Status; }   // get method
            set { Status = value; }  // set method
        }
    }
}
