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
        //private bool voteButtonPush = false;
        private Person user;

        public PersonForm(Person Cuser) : base(Cuser)
        {           
            InitializeComponent();
            user = Cuser;
            HideVotes();
            this.InfoAboutParty.Hide();
            partyNameComboBox.Hide();
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

        private void voteButton_Click(object sender, EventArgs e)
        {
            ListOf.Clear();
           
            if (!ListOf.Visible)//check the status of listOf
            {
                ListOf.Show();
                partyListLabel.Show();
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
            ListOf2.Clear();
            if (ListOf.SelectedItems.Count > 0)
            {
                foreach (var item in DataLogicMember.GetMember().Values)
                {
                    if (item.Party.Equals(ListOf.SelectedItems[0].Text.Replace(" ", String.Empty)))
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
                DialogResult dialogResult = MessageBox.Show("You sure that you whant to vote for " + ListOf2.SelectedItems[0].Text+"?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //massge with the price that the user going to pay of
                    DialogResult dialogResult2 = MessageBox.Show("Kim will charge you: " + Convert.ToString(DataLogicPerson.GetChargeBynumberofvote(user.NumOfVotes)) + "$", "", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        //if agree those function update the database by user choice and add one to his num of vote
                        DataLogicPerson.voteToMember(ListOf2.SelectedItems[0].Text);
                        DataLogicPerson.withdrawlFromAccount(user, DataLogicPerson.GetChargeBynumberofvote(user.NumOfVotes));
                        user.NumOfVotes++;
                        
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
            partyNameComboBox.Show();
            this.InfoAboutParty.Show();
            this.InfoAboutParty.Clear();
            List<string> listInfo = DataLogicPerson.InfoForParty(this.partyNameComboBox.Text);
            for (int i = 0; i < listInfo.Count; i++)
            {
                this.InfoAboutParty.Items.Add(listInfo[i]);

                if (i == 0)
                {
                    this.InfoAboutParty.Items[0].ForeColor = Color.Blue;
                }
            }
        }

        private void VoteParty_Click(object sender, EventArgs e)
        {

            if (DataLogicPerson.VoterFee(user) > 0)
            {
                bankTab.ImageIndex = 0;
                DataLogicPerson.voteToParty(this.partyNameComboBox.Text);
                MessageBox.Show("You have voted to " + this.partyNameComboBox.Text + " party");
            }
            else
            {
                MessageBox.Show("Insufficient funds!"); 
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
                for (int i = 0; i < listInfo.Count; i++)
                {
                    this.InfoAboutParty.Items.Add(listInfo[i]);

                    if (i == 0)
                    {
                        this.InfoAboutParty.Items[0].ForeColor = Color.Blue;
                    }
                }
            }
        }
    }
}
