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
        public class TupleList<item1, item2, item3> : List<Tuple<int, string, int>>
        {
            public void Add(int item1, string item2, int item3)
            {
                Add(new Tuple<int, string, int>(item1, item2, item3)); 
            }
            public void Remove(int index)
            {
                Remove(index);
            }
        }

        //Varaiables
        private TupleList<int, string, int> inbox = null;
        private int count = 0;

        //Setters Getters
        public TupleList<int, string, int> Inbox
        {
            get { return inbox; }
            set { inbox = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        //Constructor
        public Message(int id, string text, int money = 0)
        {
            inbox = new TupleList<int, string, int>();
            inbox.Add(id, text, money);
            count++;
        }

        //Functions that handle in-class actions
        public void addMessage(int id, string text, int money)
        {
            inbox.Add(id, text, money);
            count++;
        }
        public void removeMessage(int index)
        {
            inbox.Remove(index);
            count--;
        }
    }
}
