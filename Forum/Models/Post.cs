using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Post
    {
        private int ID;

        private string PostName;

        private string Content;

        private int Topic_Id;

        private Topic Topic;

        private int Account_Id;

        private Account Account;

        List<Comment> Comments { get; set; }

        public int Id   // property
        {
            get { return ID; }   // get method
            set { ID = value; }  // set method
        }

        public string postname   // property
        {
            get { return PostName; }   // get method
            set { PostName = value; }  // set method
        }

        public string content   // property
        {
            get { return Content; }   // get method
            set { Content = value; }  // set method
        }

        public int topic_Id   // property
        {
            get { return Topic_Id; }   // get method
            set { Topic_Id = value; }  // set method
        }

        public Topic topic   // property
        {
            get { return Topic; }   // get method
            set { Topic = value; }  // set method
        }

        public int account_Id   // property
        {
            get { return Account_Id; }   // get method
            set { Account_Id = value; }  // set method
        }

        public Account account   // property
        {
            get { return Account; }   // get method
            set { Account = value; }  // set method
        }



    }
}
