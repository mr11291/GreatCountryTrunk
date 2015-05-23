﻿using System;
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
            lvotetoparty2.Hide();
        }
        //all the active of vote button
        private void VoteButton_Click(object sender, EventArgs e)
        {
            HideAddParty();
            if(!ListOf.Visible)//check the status of listOf
            {
                ListOf.Show();
                CommitteListLabel.Show();
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
            MemberListLabel.Show();
            ListOf2.Clear();
            if (ListOf.SelectedItems.Count > 0)
            {
                foreach (var item in DataLogicMember.GetMember().Values)
                {
                    if (item.Party.Equals(ListOf.SelectedItems[0].Text.Replace(" ",String.Empty)))
                    {
                        ListOf2.Items.Add(item.Name);//add the member to list
                        
                    }
                }
                MessageBox.Show("Click on the member that you whant to vote for");
            }

        }
        //vote to the chosen member
        //This function is when user push to vote for a member
        private void ListOf2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("You are going to pay for KIM " + DataLogicPerson.GetChargeBynumberofvote(user.NumOfVotes) + " for the right to vote..", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (ListOf2.SelectedItems.Count > 0)
                {
                    if (DataLogicPerson.GetChargeBynumberofvote(user.NumOfVotes) < DataLogic.getBalance(user))
                    {
                        DataLogicPerson.voteToMember(ListOf2.SelectedItems[0].Text);
                        MessageBox.Show("You voted to: " + ListOf2.SelectedItems[0].Text);
                        user.NumOfVotes++;
                    }
                    else
                    {
                        MessageBox.Show("not enough money!!!");
                    }

                }
                
            }
                
        }
        //when click to add party
        private void AddPartyButton_Click(object sender, EventArgs e)
        {
            Name1.Show();
            TextName.Show();
            EnterB.Show();
            HideVoets();
                       
        }  
        //get from text box the id of the new head party
        private void EnterB_Click_1(object sender, EventArgs e)
        {
            String input;
            input = TextName.Text;

            if (input == "")
                {
                    MessageBox.Show("Error");

                }
                else
                {
                    HeadId = int.Parse(input);
                    EnterB.Text = "OK!!";
                    Partynamelabel.Show();
                    TextParty.Show();
                    EnterB2.Show();
                    EnterB.Enabled = false;
                    
                }
          
        }
        //get the name of the new party
        private void EnterB2_Click_1(object sender, EventArgs e)
        {

            Partyname = TextParty.Text;
            if (Partyname == "")
            {
                MessageBox.Show("Error");

            }
            else
            {
                EnterB2.Text = "OK";
                EnterB2.Enabled = false;
                if(!DataLogicCommittee.AddParty(Partyname, HeadId))
                    {
                        MessageBox.Show("Something went wrong");
                        EnterB2.Enabled = true;
                    }
            }  
        }
        private void HideVoets()
        {
            ListOf.Hide();
            ListOf2.Hide();
            CommitteListLabel.Hide();
            MemberListLabel.Hide();
        }
        private void HideAddParty()
        {
            Name1.Hide();
            TextName.Hide();
            EnterB.Hide();
            Partynamelabel.Hide();
            TextParty.Hide();
            EnterB2.Hide();

        }
        //start the elction and finish the primeris
        private void button1_Click(object sender, EventArgs e)
        {
            HideVoets();
            HideAddParty();
            DialogResult dialogResult = MessageBox.Show("You sure that you whant to start the elction? ", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataLogicCommittee.ChangePraimeryStatus();
                button1.Enabled = false;
                    
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
            lvotetoparty2.Show();
            CommitteListLabel.Show();
            foreach (var item in DataLogicCommittee.GetPartyList())//get all the partymember and add it to the list
            {
                lvotetoparty2.Items.Add(item.Key);
            }
            MessageBox.Show("Click on the party that you whant to vote for..");
           

            
        }

        private void lvotetoparty2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are going to pay " + DataLogicPerson.GetChargeBynumberofvote(user.NumOfVotes) + " for the right to vote..", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (DataLogicPerson.VoterFee(user) > 0)
                {
                    DataLogicPerson.voteToParty(this.lvotetoparty2.Text);
                    MessageBox.Show("You voted to " + this.lvotetoparty2.Text + " party");
                }
                else
                {
                    MessageBox.Show("not enough money!!!");
                }
            }
        }
          
    }
}
