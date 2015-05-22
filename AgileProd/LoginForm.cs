using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using AgileProdDAL;
using AgileProdObjectModel;

namespace AgileProd
{
    public partial class LoginForm : Form
    {
        private SoundPlayer snd = new SoundPlayer(Properties.Resources.KoreanAnthem);
        
        public LoginForm()
        {
            InitializeComponent();
            enteradmin.Hide();
            entercommittee.Hide();
            entermember.Show();
            enterperson.Show();
            playAnthem();
            snd.Play();
        }

        private void playAnthem()
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.KoreanAnthem);
            snd.Play();
        }

        private void stopAnthem()
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.KoreanAnthem);
            snd.Stop();
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
                snd.Stop();
                this.Hide();
                newForm.Show();
                return;
            }
            else if(tempHead !=null)
            {
                CommitteeForm newForm= new CommitteeForm(tempHead);
                snd.Stop();
                this.Hide();
                newForm.Show();
                return;
            }
            else if(tempMember != null)
            {
                MemberForm f = new MemberForm(tempMember);
                snd.Stop();
                this.Hide();
                f.Show();
                return;
            }
            else if(tempPerson!=null)
            {
                PersonForm newfrom = new PersonForm(tempPerson);
                snd.Stop();
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
            Person tempPerson = DataLogicPerson.LoginPerson("lfavq", "pass896243744");
            DataLogicMember.selectPartyLeader();
            PersonForm newfrom = new PersonForm(tempPerson);
            this.Hide();
            newfrom.Show();
            return;
        }

        private void entercommittee_Click(object sender, EventArgs e)
        {
            Head tempHead = DataLogicCommittee.LoginCommittee("nxeda", "pass507194715");
            DataLogicMember.selectPartyLeader();
            CommitteeForm newForm = new CommitteeForm(tempHead);
            this.Hide();
            newForm.Show();
            return;
        }

        private void entermember_Click(object sender, EventArgs e)
        {
            Member tempMem = DataLogicMember.LoginMember("ejwwr", "pass174465695");
            DataLogicMember.selectPartyLeader();
            MemberForm newForm = new MemberForm(tempMem);
            this.Hide();
            newForm.Show();
            return;
        }
    }
}
