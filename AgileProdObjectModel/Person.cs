using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Person
    {
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

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private bool isVoting;
        public bool IsVoting
        {
            get { return isVoting; }
            set { isVoting = value; }
        }

        public Person(int id, string name, int age, string userName, string password, bool isVoting)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.userName = userName;
            this.password = password;
            this.isVoting = isVoting;
        }

        public Person(){}

    }
}
