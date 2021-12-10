using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Comment
    {
        private int ID;

        private string Content;

        private int Account_Id;

        private Account Account;

        private int Post_Id;

        private Post Post;

        private bool Status;

        public int Id   // property
        {
            get { return ID; }   // get method
            set { ID = value; }  // set method
        }

        public string content   // property
        {
            get { return Content; }   // get method
            set { Content = value; }  // set method
        }

        public int account_Id
        {
            get { return Account_Id; }   // get method
            set { Account_Id = value; }  // set method
        }

        public Account account
        {
            get { return Account; }   // get method
            set { Account = value; }  // set method
        }

        public int post_Id   // property
        {
            get { return Post_Id; }   // get method
            set { Post_Id = value; }  // set method
        }

        public Post post
        {
            get { return Post; }   // get method
            set { Post = value; }  // set method
        }

        public bool status
        {
            get { return Status; }   // get method
            set { Status = value; }  // set method
        }
    }
}
