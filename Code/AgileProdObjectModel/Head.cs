using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Head:Person
    {
        /*
         * Committee class is more of a representation of a state, created only to seperate a regular person and a committee member
         */

        //Constructor of person
        public Head(int id, string name, int age, string userName, string password, bool isVoting)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.UserName = userName;
            this.Password = password;
            this.IsVoting = isVoting;
        }
    }
}
