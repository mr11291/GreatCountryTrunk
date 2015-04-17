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
            //Member temp = new Member(1, "name", 12, "user", "pa", true, "shloofim", 1);
            
            Member tempmem = DataLogicMember.LoginMember(username.Text, password.Text);
            Person tempper = DataLogicPerson.LoginPerson(username.Text, password.Text);
            if(DataLogicAdmin.LoginAdmin(username.Text,password.Text))
            {
                AdminForm newForm = new AdminForm();
                this.Hide();
                newForm.Show();
                return;
            }
            else if(tempmem!=null)
            {
                MemberForm f = new MemberForm(tempmem);
                this.Hide();
                f.Show();
                return;
            }
            else if(tempper!=null)
            {
                PeopleForm p = new PeopleForm(tempper);
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
