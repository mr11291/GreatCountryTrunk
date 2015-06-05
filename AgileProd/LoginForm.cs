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
            DataLogic.Ifenter();
            InitializeComponent();
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
                AdminFormV2 newForm = new AdminFormV2(tempAdmin);
                snd.Stop();
                this.Hide();
                newForm.Show();
                DataLogic.UpdateEntery(tempAdmin.Id);
                return;
            }
            else if(tempHead !=null)
            {
                CommitteeForm newForm= new CommitteeForm(tempHead);
                snd.Stop();
                this.Hide();
                newForm.Show();
                DataLogic.UpdateEntery(tempHead.Id);
                return;
            }
            else if(tempMember != null)
            {
                MemberForm f = new MemberForm(tempMember);
                snd.Stop();
                this.Hide();
                f.Show();
                DataLogic.UpdateEntery(tempMember.Id);
                return;
            }
            else if(tempPerson!=null)
            {
                PersonForm newfrom = new PersonForm(tempPerson);
                snd.Stop();
                this.Hide();
                newfrom.Show();
                DataLogic.UpdateEntery(tempPerson.Id);
                return;
            }
            else
            {
                wrongInput();
                return;
            }
        }
        
        private void enteradmin_Click(object sender, EventArgs e)
        {
            Admin tempAdmin = DataLogicAdmin.LoginAdmin("mr11291", "12345");
            DataLogicMember.selectPartyLeader();
            AdminFormV2 newForm = new AdminFormV2(tempAdmin);
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

        private void infoBox1_Click(object sender, EventArgs e)
        {
            userNameTip.Show("", this, 145, 193);
            userNameTip.Show("Please enter your username or register to the system", this, 145, 193, 5000);
        }

        private void infoBox2_Click(object sender, EventArgs e)
        {
            passwordTip.Show("", this, 145, 193);
            passwordTip.Show("Please enter your password or register to the system", this, 145, 193, 5000);
        }

        private void wrongInput()
        {
            passwordTip.Show("", this, 145, 193);
            passwordTip.Show("Ether your password or username are incorrect", this, 145, 193, 5000);
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            snd.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CreatePersonForm form = new CreatePersonForm(this);
            form.Show();
        }

     
        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            //WriteDictionariesToDataBase update = new WriteDictionariesToDataBase();
            
        }



    }
}
