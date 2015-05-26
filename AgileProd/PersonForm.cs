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
    public partial class PersonForm : BaseForm
    {
        private Person user;

        public PersonForm(Person Cuser) : base(Cuser)
        {           
            InitializeComponent();
            user = Cuser;
            HideVotes();

            this.InfoAboutParty.Hide();
            partyNameComboBox.Hide();
            sittingPutin.Hide();
            happySittingPutin.Hide();
            suspiciusPutin.MouseDoubleClick += suspiciusPutin_MouseDoubleClick;
            

            if (!(DataLogicPerson.getPraimeries()))
            {
                voteButton.Hide();
                retrunToPartyButton.Location = new Point(5, 65);
                var templist = DataLogicAdmin.AllParties();

                this.partyNameComboBox.DataSource = new BindingSource(templist, null);
                this.partyNameComboBox.DisplayMember = "Key";
                this.partyNameComboBox.ValueMember = "Value";

                user.memento = DataLogicPerson.GetMemento(user.Id);
                
                try
                {
                    if (user.memento.PartyName != null)
                    {
                        retrunToPartyButton.Visible = true;
                    }
                }
                catch { }
            }
            else
            {
                dancingPutinTimer = new Timer();
                dancingPutinTimer.Interval = 16000;
                dancingPutinTimer.Tick += new EventHandler(dancingPutinTimer_Tick);

                partyInfoButton.Hide();
                VoteParty.Hide();
                voteButton.Location = new Point(5, 5);
                retrunToPartyButton.Location = new Point(5, 35);
                ListOf.Location = new Point(239, 32);
                partyListLabel.Location = new Point(236, 10);
                suspiciusPutin.Location = new Point(295, 10);
                try
                {
                    if (user.memento.PartyName != null)
                    {
                        retrunToPartyButton.Visible = true;
                    }
                }
                catch { }
            }
        }

        void suspiciusPutin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dancingPutinTimer.Start();
            DancingPuting.Enabled = true;
            DancingPuting.Show();
            username.BringToFront();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            ListOf.Clear();
            
            if (!ListOf.Visible)//check the status of listOf
            {
                ListOf.Show();
                partyListLabel.Show();
                suspiciusPutin.Show();
            }
            else
            {
                ListOf.Hide();
                partyListLabel.Hide();
                suspiciusPutin.Hide();
                ListOf2.Hide();
                MemberListLabel.Hide();
            }

            FillListOf();// fill the list by party name
        }

        private void FillListOf()
        {
            
            foreach (var item in DataLogicCommittee.GetPartyList())//get all the partymember and add it to the list
            {
                ListOf.Items.Add(item.Key);
            }
        }

        private void HideVotes()
        {
            ListOf.Hide();
            ListOf2.Hide();
            partyListLabel.Hide();
            MemberListLabel.Hide();
        }

        private void ListOf_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListOf2.Clear();
            ListOf2.Show();
            MemberListLabel.Show();
            if (ListOf.SelectedItems.Count > 0)
            {
                foreach (var item in DataLogicMember.GetMember().Values)
                {
                    if (item.Party.Equals(ListOf.SelectedItems[0].Text.Trim()))
                    {
                        ListOf2.Items.Add(item.Name);//add the member to list
                    }
                }
                MessageBox.Show("Click on the member that you want to vote for");
            }

        }

        //This function is when user push to vote for a member
        private void ListOf2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ListOf2.SelectedItems.Count > 0)
            {
                //massge with the name of the member 
                DialogResult dialogResult = MessageBox.Show("You sure that you want to vote for " + ListOf2.SelectedItems[0].Text+"?", "Attention!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //massge with the price that the user going to pay of
                    DialogResult dialogResult2 = MessageBox.Show("You will have to pay " + Convert.ToString(DataLogicPerson.GetChargeBynumberofvote(user.NumOfVotes)) + "$ as a voters fee", "Attention", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        if (DataLogicPerson.GetChargeBynumberofvote(user.NumOfVotes) < DataLogicPerson.getBalance(user))
                        {
                            DataLogicPerson.voteToMember(ListOf2.SelectedItems[0].Text);
                            if (user.NumOfVotes > 0)
                            {
                                DataLogicPerson.withdrawlFromAccount(user, DataLogicPerson.GetChargeBynumberofvote(user.NumOfVotes));
                                bankTab.ImageIndex = 0;
                            }
                            user.NumOfVotes++; 
                        }
                        else
                        {
                            MessageBox.Show("Insufficient funds!");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void InfoParty_Click(object sender, EventArgs e)
        {
            if (!(InfoAboutParty.Visible))
            {
                updateInfoBoxes();
            }
            else
            {
                this.InfoAboutParty.Clear();
                partyNameComboBox.Hide();
                this.InfoAboutParty.Hide();
                happySittingPutin.Hide();
                sittingPutin.Hide();
            }
        }

        private void VoteParty_Click(object sender, EventArgs e)
        {
            if (InfoAboutParty.Visible)
            {
                if (DataLogicPerson.VoterFee(user) > 0)
                {
                    sittingPutin.Hide();
                    happySittingPutin.Show();
                    bankTab.ImageIndex = 0;
                    DataLogicPerson.voteToParty(this.partyNameComboBox.Text);
                    MessageBox.Show("You have voted for " + this.partyNameComboBox.Text + " party");
                }
                else
                {
                    happySittingPutin.Hide();
                    sittingPutin.Show();
                    MessageBox.Show("Insufficient funds!");
                }
            }
            else
            {
                updateInfoBoxes();
            }
        }

        private void BtnBckLastPrty_Click(object sender, EventArgs e)
        {
            DataLogicAdmin.addMember(user.Id, user.Name, user.Age, user.UserName, user.Password, user.IsVoting, user.NumOfVotes, user.memento.PartyName, user.memento.location, DataLogicPerson.getBalance(user));
            MessageBox.Show("Welcome to " + user.memento.PartyName + " party");
        }

        private void partyNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (partyNameComboBox.Visible)
            {
                this.InfoAboutParty.Show();
                this.InfoAboutParty.Clear();
                List<string> listInfo = DataLogicPerson.InfoForParty(this.partyNameComboBox.Text);
                for (int i = 0, j = 0; i < listInfo.Count(); i++)
                {

                    if (i == 0)
                    {
                        this.InfoAboutParty.Items.Add(listInfo[j + 1]);
                        i++;

                    }
                    else
                    {
                        this.InfoAboutParty.Items.Add(listInfo[i]);

                    }

                }
            }
        }

        private void updateInfoBoxes()
        {
            sittingPutin.Show();
            partyNameComboBox.Show();
            this.InfoAboutParty.Show();
            this.InfoAboutParty.Clear();

            List<string> listInfo = DataLogicPerson.InfoForParty(this.partyNameComboBox.Text);

            
            for (int i=0,j=0; i < listInfo.Count(); i++)
            {
                
                if(i==0)
                {
                    this.InfoAboutParty.Items.Add(listInfo[j + 1]);
                    i++;
             
                }
                else
                {
                    this.InfoAboutParty.Items.Add(listInfo[i]);

                }
                
            }
        }

        private void dancingPutinTimer_Tick(object sender, EventArgs e)
        {
            DancingPuting.Enabled = false;
            DancingPuting.Hide();
        }

        private void suspiciusPutin_DoubleClickfun()
        {
            dancingPutinTimer.Start();
            DancingPuting.Enabled = true;
            DancingPuting.Show();
            username.BringToFront();
        }

    }
}
