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
    public partial class MemberForm : BaseForm
    {
        Button addMem = null;
        TextBox id = null;
        Member currMember;
        
        public MemberForm(Member currentMember): base(currentMember)
        {
            InitializeComponent();
            this.currMember = currentMember;
            initializeSettingsInfo();
            fillPartyColleague();
            bankTab.ImageIndex = -1;
            partyList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            partyList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            lblWelcome.Hide();
            btnAddMem.Hide();
            id.Show();
            addMem.Show();
            addMem.Text = "Add";
            addMem.BackColor = Color.Orange;
            addMem.Location = new Point(id.Location.X, id.Location.Y + id.Height);
            this.Controls.Add(id);
            this.Controls.Add(addMem);
        }

        private void quitPartyButton_Click(object sender, EventArgs e)//the Quit Party button
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to quit the party? ", "ARE YOU LEAVING US?!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int msg = DataLogicMember.QuitParty(currMember);
                if (msg == 1)
                { 
                    MessageBox.Show("Your request for leaving the party has accepted. Thank's for your service");
                    this.Hide();
                    DataLogicAdmin.AllPersons()[currMember.Id].memento = new Memento(currMember.Party, currMember.Location);
                    DataLogicMember.InsertToMemento(currMember.Id, DataLogicAdmin.AllPersons()[currMember.Id].memento);
                    return;
                }
                else { MessageBox.Show("Error " + msg); }
            }
        }

        private void slogenChangeButton_Click(object sender, EventArgs e)// the button change the slogen
        {

            if (!(Application.OpenForms.OfType<SlogenForm>().Any()))
            {
                SlogenForm newform = new SlogenForm(currMember);
                newform.ShowDialog();
                initializeSettingsInfo();
            }
        }

        private void initializeSettingsInfo()// initialize the info for the boxes in vthe window form
        {
            int PartyLeader = DataLogicMember.mostRich(currMember.Party, DataLogicMember.GetMember());
            this.PartyNameBox.Text = currMember.Party;
            this.PartySlogenBox.Text = DataLogicMember.GetMember()[PartyLeader].Slogan;
            this.MySlogenBox.Text = currMember.Slogan;
        }

        private void fillPartyColleague()
        {
            int charCount = 0;
            string longestname = null;
            foreach (var item in DataLogicMember.returnColleagues(currMember.Party))
            {
                partyList.Items.Add(item.Value.Name);
                if (charCount < item.Value.Name.Length)
                {
                    charCount = item.Value.Name.Length;
                    longestname = item.Value.Name;
                }
            }
            Size textsize = TextRenderer.MeasureText(longestname, this.Font);
            partyList.Width = textsize.Width + 4;

        }

        private void MmberVote_Click(object sender, EventArgs e)
        {
            //massge with the price that the user is going to pay
            if (currMember.NumOfVotes == 0)                                             //if its the first time this member votes:
            {
                DataLogicPerson.voteToParty(currMember.Party);                          //vote to the his party
                currMember.NumOfVotes++;                                                //icrease number of votes
                MessageBox.Show("You have successfuly voted for " + currMember.Party);  //display conformation message
            }
            else                                                                        //if its not the first time this member votes:
            {
                //notifiy member about cost of paying
                DialogResult dialogResult = MessageBox.Show("Please pay " + DataLogicPerson.getVotingFeeByNumOfVotes(currMember.NumOfVotes) + "$ to vote", "Attention!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)                   //if member agrees to pay
                {
                    if (DataLogicPerson.getVotingFeeByNumOfVotes(currMember.NumOfVotes) < DataLogicPerson.getBalance(currMember))           //check if member has enough money
                    {
                        DataLogicPerson.voteToParty(currMember.Party);                                                                      //vote to party
                        DataLogicPerson.withdrawlFromAccount(currMember, DataLogicPerson.getVotingFeeByNumOfVotes(currMember.NumOfVotes));  //withdrawl amount from voter
                        bankTab.ImageIndex = 0;                                                                                             //inform member there's been a change in his bank avvount
                        MessageBox.Show("You have successfuly voted for " + currMember.Party);                                              //display conformation message
                    }
                    else
                    {
                        //if member doesn't have enough money
                        MessageBox.Show("Insufficient funds!"); //display coresponding message
                    }
                }

            }
            
        }

        private void Votetomember_Click(object sender, EventArgs e)
        {
            if (currMember.NumOfVotes == 0)                                     //if this party member still haven't voted:
            {
                DataLogicPerson.voteToMember(currMember.Name);                  //to to userself
                currMember.NumOfVotes++;                                        //increace number of votes count
                MessageBox.Show("You have successfuly voted for yourself!");    //display conformation message
            }
            else                                                                //if this party member has already voted:
            {
                //display voting notification about the cost of the vote
                DialogResult dialogResult = MessageBox.Show("Please pay " + DataLogicPerson.getVotingFeeByNumOfVotes(currMember.NumOfVotes) + "$ to vote", "Attention!", MessageBoxButtons.YesNo);
                
                if (dialogResult == DialogResult.Yes)                           //if member pressed yes
                {
                    if (DataLogicPerson.getVotingFeeByNumOfVotes(currMember.NumOfVotes) < DataLogicPerson.getBalance(currMember))           //if this member has enough money to vote
                    {

                        DataLogicPerson.voteToMember(currMember.Name);                                                                      //vote
                        DataLogicPerson.withdrawlFromAccount(currMember, DataLogicPerson.getVotingFeeByNumOfVotes(currMember.NumOfVotes));  //withdrawl amount from members account
                        bankTab.ImageIndex = 0;                                                                                             //alert member there's been a change in he's account
                        currMember.NumOfVotes++;                                                                                            //icrease num of votes counter
                        MessageBox.Show("You have successfuly voted for yourself!");                                                        //display conformation message
                    }
                    else
                    {
                        //if member doesn't have eanough money, display coresponding message
                        MessageBox.Show("Insufficient funds!");
                    }
                }

            }

        }

        private void initializeMenu(){
            if (DataLogicPerson.getPraimeries() == true)                //if its praimeries
            {
                voteToYourSelfButton.Location = new Point(5, 5);        //set locations
                suggestSlogenButton.Location = new Point(5, 35);

                voteToYourSelfButton.Show();                            //show buttons
                suggestSlogenButton.Show();
                pickSlogenButton.Show();
                if (currMember.Location == -1)                          //if its praimeries and the user is the party leader
                {
                    //addMemberButton.Location = new Point(5, 65);        //set locations
                    //removeMemberButton.Location = new Point(5, 95);

                    //addMemberButton.Show();                             //show buttons
                    //removeMemberButton.Show();
                }
            }
            else if (DataLogicPerson.getElections() == true)            //if it's the elections
            {
                voteToYourPartyButton.Location = new Point(5, 5);       //set locations

                voteToYourPartyButton.Show();                           //show buttons
            }

        }
    }
}
