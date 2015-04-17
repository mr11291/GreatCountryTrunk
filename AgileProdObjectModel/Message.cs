using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Message
    {
        //this is a sub class of class Message.
        //the idea is to have a list of tuples as a message container.
        //because we want to know who sent the message, having a tuple of <sender id, message> is ideal.
        //public class TupleList<T1, T2> : List<Tuple<T1, T2>>
        //{
        //    public void Add(T1 item, T2 item2)
        //    {
        //        Add(new Tuple<T1, T2>(item, item2));

        //    }
        //}

        //Variables
        //private TupleList<int, string> inbox = null;
        //private Tuple<int, string> inbox;

        int senderId;
        string messageIn = null;

        //Setters Getters
        public string MessageIn
        {
            get { return messageIn; }
            set { messageIn = value; }
        }
        public int SenderId
        {
            get { return senderId; }
            set { senderId = value; }
        }

        //Constructor
        public Message(int id, string message = null)
        {
            this.senderId = id;
            this.messageIn = message;
        }

        //returns the whole message as a tuple
        public Tuple<int, string> getFullMessage()
        {
            return new Tuple<int, string>(this.senderId, this.messageIn);
        }
    
    }
}
