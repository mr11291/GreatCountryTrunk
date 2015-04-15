using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProd
{
    public class Member:Person
    {
        string group;
        int location;
        public Member(int id, string name, int age, string userName, string password, string group, int location)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.userName = userName;
            this.password = password;
            this.group = group ;
            this.location = location;
        }

    }
}
