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
        public CommitteeForm(Head user): base(user)
        {

            tabMenu.TabPages[0].Text = "Committee";
            InitializeComponent();
            ListOf.Hide();
            ListOf2.Hide();
            
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            if(!ListOf.Visible)
                ListOf.Show();
            FeelListOf();
        }

        private void FeelListOf()
        {
            ListOf.Clear();
            foreach (var item in DataLogicCommittee.GetPartyList())
            { 
                ListOf.Items.Add(item.Key);
            }
        }


        private void ListOf_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOf2.Show();
            ListOf2.Clear();
            if (ListOf.SelectedItems.Count > 0)
            {
                foreach (var item in DataLogicMember.GetMember().Values)
                {
                    if (item.Party.Equals(ListOf.SelectedItems[0].Text.Replace(" ",String.Empty)))
                    {
                        ListOf2.Items.Add(item.Name);
                    }
                }
            }

        }

        private void ListOf2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOf.SelectedItems.Count > 0)
            {
                if(ListOf.SelectedItems.Count > 1)
                {
                    MessageBox.Show("You allredy voted");
                }
                else
                {
                     

                }
            }

        }



       


       


    }
}
