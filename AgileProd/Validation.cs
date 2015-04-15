using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AgileProdDAL;

namespace AgileProd
{
    class Validation
    {
        public Validation() { }

        
        public bool CheckIDExist(int id)
        {
            if (DataLogicAdmin.AllPersons().Keys.Contains(id))
                return true;
            return false;
        }

        public bool CheckNameValid(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        public bool CheckAgeValid(int age)
        {
            if (age <= 120 && age >= 18)
                return true;
            return false;
        }

        public bool CheckUserNameValid(string username)
        {
            if (username.Length < 10)
                return true;
            return false;
        }

        public bool CheckPasswordValid(string pass)
        {
            if (pass.Length <= 10)
                return true;
            return false;
        }

        public string NotValid()
        {
            return "one or more fields not valid";
        }
    }
}
