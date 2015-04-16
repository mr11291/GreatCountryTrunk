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
        public class TupleList<T1, T2> : List<Tuple<T1, T2>>
        {
            public void Add(T1 item, T2 item2)
            {
                Add(new Tuple<T1, T2>(item, item2));
                
            }
        }

        //Variables
        
        private TupleList<int, int> inbox = null;

        //Setters Getters
        public TupleList<int, int> Inbox
        {
            get { return inbox; }
            set { inbox = value; }
        }      

        //Constructor
        public Message(int id, int message = 0)
        {
            //if (message != 1 && message != 2)
            //{
            //    this.
            //}
            //if (message != 1 && message != 2)
            //{
            //    this.messageType = -1;
            //}
            //else
            //{
            //    this.messageType = message;
            //}
        }

        //adds a new message to the inbox;
        public void addMessage(int id, int message)
        {
            inbox.Add(id, message);
        }

        //returns the whole message as a tuple
        public Tuple<int,int> getFullMessage(int index)
        {
            return inbox[index];
        }

        //returns the message it self
        public int getMessage(int index)
        {
            return inbox[index].Item2;
        }

        //returns the id of the sender
        public int getSenderId(int index)
        {
            return inbox[index].Item1;
        }

        //checks if inbox is empty
        public bool isEmpty()
        {
            if (this.inbox == null)
            {
                return true;
            }
            return false;
        }
    }
}
