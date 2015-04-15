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
    public partial class PeopleForm : Form
    {

        private bool voteButtonPush = false;
        private Person user;

        /*
         * This is the constructor of PeopleForm
         * this constructor initialzes all info boxes.
         */
        public PeopleForm(Person currentPerson)
        {
            InitializeComponent();
            user = currentPerson;
            partyList.Hide();               //hide party list 
            AnchorSettings();               //Anchor Style <- this feature locks propetires to chosen borders
            initializeInfo(currentPerson);  //initializing info in info area
            
        }//PeopleForm(currentPerosn)

        /*
         * voteButtonClick is a click button action of button "Vote"
         * clicking this button will check first check if you are a registered voter 
         * and handle the voting proccess
         */
        private void voteButton_Click(object sender, EventArgs e)
        {
            if (!voteButtonPush)                            //if this button wasn't pushed yet
            {
                if (voterCheckBox.Checked)                      //if voter check box is CHECKED
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
                        voterCheckBox.Checked = true;           //check registration checkbox
                        voteButton_Click(sender, e);            //rerun click event
                    }
                    else if (dialogResult == DialogResult.No)   //in case user doesnt want to register as a voter
                    {
                        voterCheckBox.Checked = false;          //keep registration checkbox unchecked
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

        }//voteButton_Click

        /*
         * Text box initialization
         */
        private void initializeInfo(Person currentPerson)
        {
            nameBox.Text = currentPerson.Name;
            idBox.Text = Convert.ToString(currentPerson.Id);
            ageBox.Text = Convert.ToString(currentPerson.Age);
            balanceBox.Text = Convert.ToString(DataLogic.getBalance(currentPerson));
            if (currentPerson.IsVoting == false)
            {
                voterCheckBox.Checked = false;
                return;
            }
            else
            {
                voterCheckBox.Checked = true;
                return;
            }
        }//initializeInfo(Person)

        /*
         * "Update info" buton click event
         */
        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            UpdateInfoForm update = new UpdateInfoForm(this.user, this);
            this.Hide();
            update.Show();
            return;
        }//updateInfoButton_Click

        /*
         * This function sets anchor setting 
         */
        private void AnchorSettings()
        {
            nameBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            idBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            idLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ageBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ageLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            balanceBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            balanceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void partyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
