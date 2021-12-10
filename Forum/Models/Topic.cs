using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Topic
    {
        private int ID { get; set; }

        private string TopicName { get; set; }

        private bool Status { get; set; }

        List<Topic> Topics { get; set; }

        public int Id   // property
        {
            get { return ID; }   // get method
            set { ID = value; }  // set method
        }

        public string topicname   // property
        {
            get { return TopicName; }   // get method
            set { TopicName = value; }  // set method
        }

        public bool status   // property
        {
            get { return Status; }   // get method
            set { Status = value; }  // set method
        }

    }
}
