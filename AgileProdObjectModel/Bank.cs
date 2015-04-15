using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Bank
    {
        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Bank(int balance, int id, string name)
        {
            this.balance = balance;
            this.id = id;
            this.name = name;
        }

        public int withdrawl (int amount)
        {
            if (this.balance - amount >= 0)
            {
                this.balance = this.balance = amount;
            }

            return this.balance;
        }

        public int deposit(int amount)
        {
            this.balance = this.balance + amount;
            return this.balance;
        }
    }
}
