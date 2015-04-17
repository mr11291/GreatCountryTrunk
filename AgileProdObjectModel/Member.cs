﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Member:Person
    {
        private string party;
        public string Party
        {
            get { return party; }
            set { party = value; }
        }

        private int location;
        public int Location
        {
            get { return location; }
            set { location = value; }
        }

        private string slogan;
        public string Slogan
        {
            get { return slogan; }
            set { slogan = value; }
        }

        public Member(int id, string name, int age, string userName, string password, bool isVoting, string party, int location)
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
