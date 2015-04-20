using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Bank
    {
        //Varaiables
        private int id;
        private string name;
        private int balance;
        
        //Getters Setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //Constructor
        public Bank(int balance, int id, string name)
        {
            this.balance = balance;
            this.id = id;
            this.name = name;
        }

        //Withdrawal from account function
        public int withdrawl (int amount)
        {
            if (this.balance - amount >= 0)             //if withdrawal action wouldn't resoult in overdraft
            {
                this.balance = this.balance - amount;
                return amount;                          //if withdrawal successeeded return the amount that was withdrawaled
            }
            return 0;                                   //if withdrawal failed, return 0
        }

        //Deposit to account function
        public int deposit(int amount)
        {
            this.balance = this.balance + amount;
            return this.balance;
        }
    }
}
