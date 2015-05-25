using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgileProdObjectModel;
using AgileProdDAL;

namespace AgileProd
{
    public partial class CreatePersonForm : Form
    {
        LoginForm login = null;

        public CreatePersonForm(LoginForm loginForm)
        {
            login = loginForm;
            InitializeComponent();
            idBox.Text = Convert.ToString(generateID());

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == String.Empty || ageBox.Text == String.Empty || usernameBox.Text == String.Empty || passwordBox.Text == String.Empty)
            {
                toolTip1.Show(String.Empty, pictureBox1, 0);
                toolTip1.Show("Please fill out every part of the form!", pictureBox1, 130, 10, 2500);
            }
            else if (Convert.ToInt32(ageBox.Text) < 1)
            {
                toolTip1.Show(String.Empty, pictureBox1, 0);
                toolTip1.Show("Age cannot contain a letter and cant be smaller then 1", pictureBox1, 130, 10, 3500);
            }
            else
            {
                String id = idBox.Text;
                String name = nameBox.Text;
                String age = ageBox.Text;
                String usern = usernameBox.Text;
                String passw = passwordBox.Text;
                DataLogicPerson.createPerson(Convert.ToInt32(id), name, Convert.ToInt32(age), usern, passw);
                Bank account = new Bank(generateBalance(), Convert.ToInt32(id), name);
                DataLogicBank.getBankDictionary().Add(account.Id, account);        
                login.username.Text = usernameBox.Text;
                login.password.Text = passwordBox.Text;
                this.Close();
            }
        }

        private int generateID()
        {
            Random rand = new Random();
            int id = rand.Next(100000000, 999999999);
            while (DataLogicPerson.getPersonDictionary().Keys.Contains(id))
            {
                id = rand.Next(100000000, 999999999);
            }
            return id;
        }

        public int generateBalance()
        {
            Random rand = new Random();                      //initialize new sudo random
            int amount = rand.Next(0, 100000);               //generate a random number

            return amount;                                  //return the amount


        }//generateBalance()
    }
}
