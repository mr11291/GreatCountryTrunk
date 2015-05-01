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
        private bool voteButtonPush = false;
        private Person user;

        public PersonForm(Person Cuser) : base(Cuser)
        {
            InitializeComponent();
            user = Cuser;
            partyList.Hide();
            var templist = DataLogicAdmin.AllParties();      //get list of all parties
            AddToParty.Items.Add("select...");
            foreach (var item in templist.Keys)         //add parties to list
            {
                AddToParty.Items.Add(item);
            }
            AddToParty.SelectedIndex = 0;                //initialize selection
            AddToParty.Show();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            if (!voteButtonPush)                            //if this button wasn't pushed yet
            {
                if (user.IsVoting)                      //if voter check box is CHECKED
                {
                    var templist = DataLogicAdmin.AllParties();      //get list of all parties
                    partyList.Items.Add("select...");
                    foreach (var item in templist.Keys)         //add parties to list
                    {
                        partyList.Items.Add(item);
                    }
                    partyList.SelectedIndex = 0;                //initialize selection
                    partyList.Show();                           //display parties to user
                    voteButtonPush = true;
                    return;                                     //finish click even
                }
                else                                            //if voter check box is UNCHECKED
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to register as a Voter?", "Not a voter yet?", MessageBoxButtons.YesNo); //suggest registering as a voter
                    if (dialogResult == DialogResult.Yes)       //if user decided to register as a voter
                    {
                        DataLogicPerson.registerVoter(user);         //check registration checkbox
                        voteButton_Click(sender, e);            //rerun click event
                    }
                    else if (dialogResult == DialogResult.No)   //in case user doesnt want to register as a voter
                    {
                        //voterCheckBox.Checked = false;          //keep registration checkbox unchecked
                        return;                                 //finish click button event
                    }
                }
                return;
            }
            else                                            //if this button was already pushed
            {
                if (partyList.SelectedIndex == 0)
                {
                    partyList.Items.Clear();
                    partyList.Hide();                           //hide party list 
                    voteButtonPush = false;                     //reset vote button push value
                }
                else
                {
                    if (DataLogicPerson.VoterFee(user) > 0)
                    {
                        user.NumOfVotes += 1;
                        DataLogicPerson.voteToParty(partyList.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Insufficient funds!");
                    }
                }
                return;                                     //finish click event
            }
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            UpdateInfoForm update = new UpdateInfoForm(this.user, this);
            this.Hide();
            update.Show();
            return;
        }

        private void rvkbtn_Click(object sender, EventArgs e)
        {
            DataLogicPerson.revokeVoter(user);
        }

        private void addtoprty_Click(object sender, EventArgs e)
        {
            DataLogicPerson.addToParty(user, AddToParty.SelectedItem.ToString(), 0);
        }
    }
}
