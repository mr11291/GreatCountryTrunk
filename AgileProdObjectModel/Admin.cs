using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgileProdObjectModel
{
    public class Admin
    {

        //Varaiables
        private int id;
        private string name;
        private string userName;
        private string password;

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

        //Consturctor
        public Admin(int id, string name, string username, string password)
        {
            //Varaiables
            this.id = id;
            this.name = name;
            this.userName = username;
            this.password = password;
        }
    }
}
