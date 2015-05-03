using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Member:Person
    {
        //Varaiables
        private string party;
        private int location;
        private string slogan;

        //Setters Getters
        public int Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Party
        {
            get { return party; }
            set { party = value; }
        }
        public string Slogan
        {
            get { return slogan; }
            set { slogan = value; }
        }

        //Constructor
        public Member(int id, string name, int age, string userName, string password, bool isVoting, string party, int location,string slogen=null)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.UserName = userName;
            this.Password = password;
            this.party = party;
            this.location = location;
            this.IsVoting = isVoting;
            this.slogan = null;
        }
    }
}
