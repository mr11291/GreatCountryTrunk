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
        //because we know there are only two types of messages that could be sent, having a tuple of <sender id, message> is ideal.
        public class TupleList<T1, T2> : List<Tuple<T1, T2>>
        {
            public void Add(T1 item, T2 item2)
            {
                Add(new Tuple<T1, T2>(item, item2));
                
            }
        }

        //private int id;
        private int messageType;
        public int MessageType
        {
            get { return messageType; }
            set { messageType = value; }
        }

        private TupleList<int, int> inbox = null;
        public TupleList<int, int> Inbox
        {
            get { return inbox; }
            set { inbox = value; }
        }
        
        public Message(int id, int message = 0)
        {
            if (message != 1 && message != 2)
            {
                this.messageType = -1;
            }
            else
            {
                this.messageType = message;
            }
        }

        public void addMessage(int id, int message)
        {
            inbox.Add(id, message);
        }
    }
}
