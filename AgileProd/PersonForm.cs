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
            HideVoets();
            user = Cuser;
            var templist = DataLogicAdmin.AllParties();      //get list of all parties
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            ListOf.Clear();
           
            if (!ListOf.Visible)//check the status of listOf
            {
                ListOf.Show();
                CommitteListLabel.Show();
            }

            FeelListOf();// feel the list by party name
        }

        private void FeelListOf()
        {
            
            foreach (var item in DataLogicCommittee.GetPartyList())//get all the partymember and add it to the list
            {
                ListOf.Items.Add(item.Key);
            }
        }

        private void HideVoets()
        {
            ListOf.Hide();
            ListOf2.Hide();
            CommitteListLabel.Hide();
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
                MessageBox.Show("Click on the member that you whant to vote for");
            }

        }

        private void ListOf2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ListOf2.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("You sure that you whant to vote to this member? ", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!DataLogicPerson.voteToMember(ListOf2.SelectedItems[0].Text))
                    {
                        MessageBox.Show("Something went wrong");
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
    }
}
