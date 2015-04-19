using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgileProdDAL;
using AgileProdObjectModel;
using System.IO;

namespace AgileProd
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {         
            Member tempMember = DataLogicMember.LoginMember(username.Text, password.Text);
            Person tempPerson = DataLogicPerson.LoginPerson(username.Text, password.Text);
            Admin tempAdmin = DataLogicAdmin.LoginAdmin(username.Text, password.Text);
            if(tempAdmin != null)
            {
                AdminForm newForm = new AdminForm(tempAdmin);
                this.Hide();
                newForm.Show();
                return;
            }
            else if(tempMember != null)
            {
                MemberForm f = new MemberForm(tempMember);
                this.Hide();
                f.Show();
                return;
            }
            else if(tempPerson!=null)
            {
                PeopleForm p = new PeopleForm(tempPerson);
                this.Hide();
                p.Show();
                return;
            }
        }
        
        private void lblCreateVol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm currentForm = new LoginForm();
            CreateVoterForm cvf = new CreateVoterForm(DataLogicAdmin.AllPersons(),currentForm,null);
            cvf.Show();
            this.Hide();
        }
   
    }
}
