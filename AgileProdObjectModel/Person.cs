using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Person
    {
        //Varaiables
        private int id;
        private string name;
        private int age;
        private string userName;
        private string password;
        private bool isVoting;
        private int numOfVotes;

        //Setters Getters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsVoting
        {
            get { return isVoting; }
            set { isVoting = value; }
        }
        public int NumOfVotes
        {
            get { return numOfVotes; }
            set { numOfVotes = value; }
        }

        //Constructor
        public Person(int id, string name, int age, string userName, string password, bool isVoting)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.userName = userName;
            this.password = password;
            this.isVoting = isVoting;
            this.numOfVotes = 0;
        }

        //Public Constructor
        public Person(){}
    }
}
