using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgileProdObjectModel
{
    class Admin //does it extendes anything? 
    {
        private string ID;
        private string name;
        private string userName;
        private string password;

        public Admin(string id, string name, string username, string password)
        {
            this.ID = id;
            this.name = name;
            this.userName = username;
            this.password = password;
        }

    }
}
