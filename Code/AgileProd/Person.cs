using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProd
{
    public class Person
    {
        public int id;
        public string name;
        public int age;
        public string userName;
        public string password;

        public Person(int id,string name,int age,string userName,string password)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.userName = userName;
            this.password = password;
        }
        public Person() { }

        public void DeleteMe(int id)
        {
            //for (int i = 0; i < Variables.people.Count; i++)
            //{
            //    if (Variables.people[i].id == id)
            //        Variables.people.Remove(Variables.people[i]);
            //}
            Variables.people.Remove(id);
        }
    }
}
