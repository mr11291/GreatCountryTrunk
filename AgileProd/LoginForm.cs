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
            Head tempHead = DataLogicCommittee.LoginCommittee(username.Text, password.Text);
            Member tempMember = DataLogicMember.LoginMember(username.Text, password.Text);
            Person tempPerson = DataLogicPerson.LoginPerson(username.Text, password.Text);
            Admin tempAdmin = DataLogicAdmin.LoginAdmin(username.Text, password.Text);
            DataLogicMember.selectPartyLeader();
            if(tempAdmin != null)
            {
                AdminForm newForm = new AdminForm(tempAdmin);
                this.Hide();
                newForm.Show();
                return;
            }
            else if(tempHead !=null)
            {
                CommitteeForm newForm= new CommitteeForm(tempHead);
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
                PersonForm newfrom = new PersonForm(tempPerson);
                this.Hide();
                newfrom.Show();
                return;
            }
            else
            {
                inputWarning.Show();
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

        private void enteradmin_Click(object sender, EventArgs e)
        {
            Admin tempAdmin = DataLogicAdmin.LoginAdmin("mr11291", "12345");
            DataLogicMember.selectPartyLeader();
            AdminForm newForm = new AdminForm(tempAdmin);
            this.Hide();
            newForm.Show();
            return;
        }

        private void enterperson_Click(object sender, EventArgs e)
        {
            Person tempPerson = DataLogicPerson.LoginPerson("bet", "12345");
            DataLogicMember.selectPartyLeader();
            PersonForm newfrom = new PersonForm(tempPerson);
            this.Hide();
            newfrom.Show();
            return;
        }

        private void entercommittee_Click(object sender, EventArgs e)
        {
            Head tempHead = DataLogicCommittee.LoginCommittee("guy","guy");
            DataLogicMember.selectPartyLeader();
            CommitteeForm newForm = new CommitteeForm(tempHead);
            this.Hide();
            newForm.Show();
            return;
        }



   
    }
}
