using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgileProdDAL;

namespace AgileProd
{
    public partial class AddPersonToPartyForm : Form
    {
        protected String selectedParty = null;
        AdminFormV2 tempForm = null;
        
        public AddPersonToPartyForm(AdminFormV2 form)
        {
            InitializeComponent();
            fillPartyList();
            tempForm = form;
        }

        private void fillPartyList()
        {
            foreach (var party in DataLogicAdmin.AllParties().Keys)     //loop trough parties
            {
                partyList.Items.Add(party);                             //add every party to the combobox
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedParty = partyList.Text;                             //keep track of selected party
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (tempForm != null)                                                           //if previus form passed successfuly
            {
                if (selectedParty != null)                                                  //if the user selected a party
                {
                    if (!(DataLogicAdmin.AllMembers().Keys.Contains(tempForm.selectedID)))  //if the selected person is already in a party
                    {                                                                       //add selected person to selected party
                        DataLogicAdmin.AddPerosnToParty(Convert.ToInt32(tempForm.selectedID), selectedParty, 0);    
                                                                                            //show conformation message

                        MessageBox.Show("You have successfuly added " + 
                                        DataLogicAdmin.AllPersons()[tempForm.selectedID].Name + 
                                        " to " + 
                                        selectedParty);

                        tempForm.selectedID = 0;                                            //reset selected id
                        selectedParty = null;                                               //reset selected party
                        this.Close();                                                       //close form
                    }
                    else                                                                    //if the person is already in party 
                    {                                                                       //show coresponding message

                        MessageBox.Show("Opps! " + 
                                        DataLogicAdmin.AllPersons()[tempForm.selectedID].Name + 
                                        " is already a party member at " + 
                                        DataLogicAdmin.AllMembers()[tempForm.selectedID].Party);
                    }
                }
                else                                                                        //if a party wasn't selected yet
                {                                                                           //show coresponding message
                    MessageBox.Show("Please select a party");
                }
            }
        }
    }
}
