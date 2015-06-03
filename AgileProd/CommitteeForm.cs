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
    
    public partial class CommitteeForm : BaseForm
    {
        private Head user;
        private static int HeadId;//keep the id of the new head of party
        private static String Partyname;//keep the name of the new party

        //constractor of committee
        public CommitteeForm(Head user): base(user)
        {
            
            this.user = user;
            tabMenu.TabPages[0].Text = "Committee";//change the name of the tab
            InitializeComponent();
            //hise all the tabs and text box
            HideVoets();
            HideAddParty();
            listOfParties.Hide();

            if (DataLogicCommittee.getPraimeries() == true)
            {
                voteToMemberButton.Location = new Point(5, 5);
                addPartyButton.Location = new Point(5, 35);
                deletePartyButton.Location = new Point(5, 65);
                finishPraimeriesButton.Location = new Point(5, 95);
                partyLeaderIdLabel.Location = new Point(110, 10);
                paryLeaderIdTextBox.Location = new Point(223, 7);
                partyNameLabel.Location = new Point(110, 35);
                partyNameTextBox.Location = new Point(223, 32);
                EnterButton.Location = new Point(370, 7);
                EnterButton2.Location = new Point(370, 32);

                voteToMemberButton.Show();
                addPartyButton.Show();
                deletePartyButton.Show();
                finishPraimeriesButton.Show();
                
                voteToPartyButton.Hide();
                endElectionsButton.Hide();
            }
            else
            {
                voteToPartyButton.Location = new Point(5, 5);
                endElectionsButton.Location = new Point(5, 35);
                listOfParties.Location = new Point(113, 25);

                voteToPartyButton.Show();
                endElectionsButton.Show();

                voteToMemberButton.Hide();
                addPartyButton.Hide();
                deletePartyButton.Hide();
                finishPraimeriesButton.Hide();
            }





        }

        //all the active of vote button
        private void VoteButton_Click(object sender, EventArgs e)
        {
            HideAddParty();
            if(!ListOf.Visible)//check the status of listOf
            {
                ListOf.Show();
                partyListLabel.Show();
            }
            else
            {
                ListOf.Hide();
                partyListLabel.Hide();
                if (ListOf2.Visible)
                {
                    memberListLabel.Hide();
                    ListOf2.Hide();
                }
            }
                
            FeelListOf();// feel the list by party name
        }

        // feel the list by party name
        private void FeelListOf()
        {
            ListOf.Clear();
            foreach (var item in DataLogicCommittee.GetPartyList())//get all the partymember and add it to the list
            { 
                ListOf.Items.Add(item.Key);
            }
        }

        //show all the members in the in the chosen party
        private void ListOf_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOf2.Show();
            memberListLabel.Show();
            ListOf2.Clear();
            if (ListOf.SelectedItems.Count > 0)
            {
                foreach (var item in DataLogicMember.GetMember().Values)
                {
                    if (item.Party.Equals(ListOf.SelectedItems[0].Text.Trim()))
                    {
                        ListOf2.Items.Add(item.Name);//add the member to list  
                    }
                }
                MessageBox.Show("Please click on a party member you would like to vote for");
            }

        }

        //vote to the chosen member
        //This function is when user push to vote for a member
        private void ListOf2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user.NumOfVotes == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to vote?", "Attention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ListOf2.SelectedItems.Count > 0)
                    {
                        if (DataLogicPerson.getVotingFeeByNumOfVotes(user.NumOfVotes) < DataLogic.getBalance(user))
                        {
                            DataLogicPerson.voteToMember(ListOf2.SelectedItems[0].Text);
                            MessageBox.Show("You have successfuly voted for " + ListOf2.SelectedItems[0].Text);
                            user.NumOfVotes++;
                        }
                    }
                }
            }
            else
            {
                if (ListOf2.SelectedItems.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to pay " + DataLogicPerson.getVotingFeeByNumOfVotes(user.NumOfVotes) + "$ to vote?", "Attention", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        if (DataLogicPerson.getVotingFeeByNumOfVotes(user.NumOfVotes) < DataLogic.getBalance(user))
                        {
                            DataLogicPerson.voteToMember(ListOf2.SelectedItems[0].Text);
                            DataLogicPerson.withdrawlFromAccount(user, DataLogicPerson.getVotingFeeByNumOfVotes(user.NumOfVotes));
                            MessageBox.Show("You have successfuly voted for " + ListOf2.SelectedItems[0].Text);
                            bankTab.ImageIndex = 0;
                            user.NumOfVotes++;
                            
                        }
                        else
                        {
                            MessageBox.Show("Insufficiant Funds");
                        }
                    }
                }
            }   
        }

        //when click to add party
        private void AddPartyButton_Click(object sender, EventArgs e)
        {
            if (!(partyLeaderIdLabel.Visible))
            {
                partyLeaderIdLabel.Show();
                paryLeaderIdTextBox.Show();
                EnterButton.Show();
                HideVoets();
            }
            else
            {
                partyLeaderIdLabel.Hide();
                paryLeaderIdTextBox.Hide();
                paryLeaderIdTextBox.Clear();
                EnterButton.Enabled = true;
                EnterButton.Hide();
                if (EnterButton2.Visible)
                {
                    partyNameLabel.Hide();
                    partyNameTextBox.Hide();
                    partyNameTextBox.Clear();
                    EnterButton2.Enabled = true;
                    EnterButton2.Hide();
                }
            }
                       
        }  

        //get from text box the id of the new head party
        private void EnterB_Click_1(object sender, EventArgs e)
        {
            String input;
            input = paryLeaderIdTextBox.Text;

            if (input.Equals(String.Empty) || input.Any(char.IsLetter) || !(DataLogicPerson.getPersonDictionary().Keys.Contains(Convert.ToInt32(input))))
            {
                MessageBox.Show("Please use a valid ID");
            }
            else if (DataLogicMember.GetMember().Keys.Contains(Convert.ToInt32(input)))
            {
                MessageBox.Show("This ID belongs to an existing party member");
            }
            else
            {
                HeadId = Convert.ToInt32(input);
                EnterButton.Text = "OK";
                partyNameLabel.Show();
                partyNameTextBox.Show();
                EnterButton2.Show();
                EnterButton.Enabled = false;
            }
        }

        //get the name of the new party
        private void EnterB2_Click_1(object sender, EventArgs e)
        {

            Partyname = partyNameTextBox.Text;
            if (Partyname.Equals(String.Empty))
            {
                MessageBox.Show("You cant use an empty name");

            }
            else
            {
                EnterButton2.Text = "OK";
                EnterButton2.Enabled = false;
                if (!(DataLogicCommittee.GetPartyList().Keys.Contains(Partyname)))
                {
                    DataLogicCommittee.AddParty(Partyname, HeadId);
                }
                else
                {
                    MessageBox.Show("This name is already in use");
                    EnterButton2.Enabled = true;
                }
            }  
        }

        private void HideVoets()
        {
            ListOf.Hide();
            ListOf2.Hide();
            partyListLabel.Hide();
            memberListLabel.Hide();
        }

        private void HideAddParty()
        {
            partyLeaderIdLabel.Hide();
            paryLeaderIdTextBox.Hide();
            EnterButton.Hide();
            partyNameLabel.Hide();
            partyNameTextBox.Hide();
            EnterButton2.Hide();

        }

        //start the elction and finish the primeris
        private void button1_Click(object sender, EventArgs e)
        {
            HideVoets();
            HideAddParty();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to end the Praimeries? ", "Attenction!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EndingPrimariesPage logo = new EndingPrimariesPage();
                logo.ShowDialog();
                DataLogicCommittee.ChangePraimeryStatus();
                finishPraimeriesButton.Enabled = false;
                voteToMemberButton.Enabled = false;
                addPartyButton.Enabled = false;
                deletePartyButton.Enabled = false;
            }     
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Party_Click(object sender, EventArgs e)
        {
            if (!(Application.OpenForms.OfType<DeletPartyForm>().Any()))
            {
                    DeletPartyForm newform = new DeletPartyForm();
                    newform.ShowDialog();
            }
        }

        private void End_Election_Click(object sender, EventArgs e)
        {
            //End_Election function at DataLgicCommittee
        }

        private void VoteToParty_Click(object sender, EventArgs e)
        {
            HideVoets();
            HideAddParty();
            listOfParties.Show();
            partyListLabel.Show();
            foreach (var item in DataLogicCommittee.GetPartyList())//get all the party members and add it to the list
            {
                listOfParties.Items.Add(item.Key);
            }
            MessageBox.Show("Please click on the party that you want to vote for");
           

            
        }

        private void lvotetoparty2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfParties.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listOfParties.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("You sure that you want to vote for " + listOfParties.Items[intselectedindex].Text + "?", "Attention!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Would you like to pay " + DataLogicPerson.getVotingFeeByNumOfVotes(user.NumOfVotes) + "$ to vote?", "Attention!", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        if (DataLogicPerson.getVotingFeeByNumOfVotes(user.NumOfVotes) < DataLogicPerson.getBalance(user))
                        {
                            DataLogicPerson.voteToParty(listOfParties.SelectedItems[0].Text);
                            if (user.NumOfVotes > 0)
                            {
                                DataLogicPerson.withdrawlFromAccount(user, DataLogicPerson.getVotingFeeByNumOfVotes(user.NumOfVotes));
                                bankTab.ImageIndex = 0;
                                MessageBox.Show("You have successfuly voted for " + listOfParties.Items[intselectedindex].Text);
                            }
                            else
                            {
                                MessageBox.Show("You have successfuly voted for " + listOfParties.Items[intselectedindex].Text);

                            }
                            user.NumOfVotes++;
                        }
                        else
                        {
                            MessageBox.Show("Insufficiant funds!");
                        }
                    }
                }
            }
        }   
    }
}
