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
    public partial class AdminFormV2 : Form
    {
        Admin user = null;
        int selectedID = 0;
        String selectedPartyName = null;

        public AdminFormV2(Admin admin)
        {
            user = admin;           //save user info
            InitializeComponent();  //initialize component
            fillUserInfo();         //initialize user info grid view

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            userInfoGrid.SelectionChanged += userInfoGrid_SelectionChanged;     //selected index changed event
            memberInfoGrid.SelectionChanged += memberInfoGrid_SelectionChanged; //selected index changed event
            partyInfoGrid.SelectionChanged += partyInfoGrid_SelectionChanged;   //selected index changed event
            bankInfoGrid.SelectionChanged += bankInfoGrid_SelectionChanged;     //selected index changed event
        }

        void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    {
                        updateInfoGrid();
                    }
                    break;
                case 1:
                    {
                        updateMemberGrid();
                    }
                    break;
                case 2:
                    {
                        updatePartyGrid();
                    }
                    break;
                case 3:
                    {
                        updateCommitteeGrid();
                    }
                    break;
                case 4:
                    {
                        updateBankGrid();
                    }
                    break;
            }
        }
        
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        /////////////
        /////////////   Person tab functions
        /////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        private void createPersonButton_Click(object sender, EventArgs e)
        {
            CreatePersonForm newPerson = new CreatePersonForm(null);    //create a new createPersonForm
            newPerson.Show();                                           //show form
        }

        void userInfoGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (userInfoGrid.SelectedCells.Count > 0)                               //if any cells are selected
            {
                int selectedrowindex = userInfoGrid.SelectedCells[0].RowIndex;      //get selected row index

                userInfoGrid.Rows[selectedrowindex].Selected = true;                //mark whole row with selection

                DataGridViewRow selectedRow = userInfoGrid.Rows[selectedrowindex];  //get selected row

                selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);           //get id of selected person
            }
        }

        private void fillUserInfo()
        {
            foreach (var person in DataLogicAdmin.AllPersons()) //iterate trough data grid
            {
                DataGridViewRow row = new DataGridViewRow();    //create new row and fill it using the dictionary
                row.CreateCells(userInfoGrid);
                row.Cells[0].Value = person.Value.Id;
                row.Cells[1].Value = person.Value.Name;
                row.Cells[2].Value = person.Value.Age;
                row.Cells[3].Value = person.Value.UserName;
                row.Cells[4].Value = person.Value.Password;
                if (person.Value.IsVoting == true)
                {
                    row.Cells[5].Value = "True";
                }
                else
                {
                    row.Cells[5].Value = "False";
                }
                userInfoGrid.Rows.Add(row);
            }
        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            if (selectedID != 0) //if a person is selected
            {
                //check if user is sure of his desition
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + DataLogicPerson.getPersonDictionary()[selectedID].Name + "?", "Attention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DataLogicAdmin.DeletePerson(selectedID))            //if person is deleted successfuly
                    {
                        updateInfoGrid();
                        MessageBox.Show("Person deleted successfuly!");     //show conformation message
                    }
                }
                selectedID = 0;                                             //reset person id selection
            }
            else                                                            // if a person was not selected yet
            {
                MessageBox.Show("Please select a person");                  //dispay coresponding message
            }
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            if (selectedID != 0)
            {
                UpdateInfoForm update = new UpdateInfoForm(DataLogicPerson.getPersonDictionary()[selectedID], this);
                update.Show();
            }
            else
            {
                MessageBox.Show("Please select a person");                  //dispay coresponding message
            }
        }

        public void updateInfoGrid()
        {
            userInfoGrid.Rows.Clear();  //clear gridview
            fillUserInfo();             //update gridview
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        /////////////
        /////////////   Party Member tab
        /////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        void memberInfoGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (memberInfoGrid.SelectedCells.Count > 0)                               //if any cells are selected
            {
                int selectedrowindex = memberInfoGrid.SelectedCells[0].RowIndex;      //get selected row index

                memberInfoGrid.Rows[selectedrowindex].Selected = true;                //mark whole row with selection

                DataGridViewRow selectedRow = memberInfoGrid.Rows[selectedrowindex];  //get selected row

                selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);             //get id of selected person
            }
        }
        
        private void fillMemberInfo()
        {
            foreach (var member in DataLogicAdmin.AllMembers()) //iterate trough data grid
            {
                DataGridViewRow row = new DataGridViewRow();    //create new row and fill it using the dictionary
                row.CreateCells(memberInfoGrid);
                row.Cells[0].Value = DataLogicPerson.getPersonDictionary()[member.Key].Id;
                row.Cells[1].Value = DataLogicPerson.getPersonDictionary()[member.Key].Name;
                row.Cells[2].Value = DataLogicPerson.getPersonDictionary()[member.Key].Age;
                row.Cells[3].Value = DataLogicPerson.getPersonDictionary()[member.Key].UserName;
                row.Cells[4].Value = DataLogicPerson.getPersonDictionary()[member.Key].Password;
                row.Cells[5].Value = member.Value.Party;
                row.Cells[6].Value = member.Value.Location;

                memberInfoGrid.Rows.Add(row);                     //add to datagrid
            }
        }

        public void updateMemberGrid()
        {
            memberInfoGrid.Rows.Clear();    //clear gridview
            fillMemberInfo();               //update gridview
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        /////////////
        /////////////   Party tab
        /////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        void partyInfoGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (userInfoGrid.SelectedCells.Count > 0)                               //if any cells are selected
            {
                try
                {
                    int selectedrowindex = partyInfoGrid.SelectedCells[0].RowIndex;     //get selected row index

                    partyInfoGrid.Rows[selectedrowindex].Selected = true;               //mark whole row with selection

                    DataGridViewRow selectedRow = partyInfoGrid.Rows[selectedrowindex]; //get selected row

                    selectedPartyName = Convert.ToString(selectedRow.Cells[0].Value);   //get id of selected person
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }

        private void fillPartyInfo()
        {
            int count = 0;
            foreach (var party in DataLogicAdmin.AllParties())          //iterate trough data grid
            {
                DataGridViewRow row = new DataGridViewRow();            //create new row and fill it using the dictionary
                row.CreateCells(partyInfoGrid);
                row.Cells[0].Value = party.Key;
                row.Cells[2].Value = party.Value;

                foreach (var member in DataLogicAdmin.AllMembers())     //count amount of pary members in every party
                {
                    if (member.Value.Party.Equals(party.Key))
                    {
                        count++;
                    }
                }

                row.Cells[1].Value = count;
                count = 0;

                partyInfoGrid.Rows.Add(row);    //add row to datagrid
            }
        }

        public void updatePartyGrid()
        {
            partyInfoGrid.Rows.Clear();    //clear gridview
            fillPartyInfo();               //update gridview
        }

        private void deletePartyButton_Click(object sender, EventArgs e)
        {
            if (selectedPartyName != null) //if a party is selected
            {
                //check if user is sure of his desition
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + selectedPartyName + "?", "Attention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DataLogicCommittee.DeleteParty(selectedPartyName))  //if party is deleted successfuly
                    {
                        updatePartyGrid();
                        MessageBox.Show("Party deleted successfuly!");      //show conformation message
                    }
                }
                
                selectedPartyName = null; ;                                 //reset person id selection
            }
            else                                                            // if a person was not selected yet
            {
                MessageBox.Show("Please select a party");                  //display coresponding message
            }
            
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        /////////////
        /////////////   Committee Member tab
        /////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        private void fillCommitteeInfo()
        {
            foreach (var committee in DataLogicAdmin.AllCommittee()) //iterate trough data grid
            {
                DataGridViewRow row = new DataGridViewRow();    //create new row and fill it using the dictionary
                row.CreateCells(committeeInfoGrid);
                row.Cells[0].Value = DataLogicPerson.getPersonDictionary()[committee.Key].Id;
                row.Cells[1].Value = DataLogicPerson.getPersonDictionary()[committee.Key].Name;
                row.Cells[2].Value = DataLogicPerson.getPersonDictionary()[committee.Key].Age;

                committeeInfoGrid.Rows.Add(row);                     //add to datagrid
            }
        }

        public void updateCommitteeGrid()
        {
            committeeInfoGrid.Rows.Clear();  //clear gridview
            fillCommitteeInfo();             //update gridview
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        /////////////
        /////////////   Bank tab
        /////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        void bankInfoGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (bankInfoGrid.SelectedCells.Count > 0)                               //if any cells are selected
            {
                int selectedrowindex = bankInfoGrid.SelectedCells[0].RowIndex;      //get selected row index

                bankInfoGrid.Rows[selectedrowindex].Selected = true;                //mark whole row with selection

                DataGridViewRow selectedRow = bankInfoGrid.Rows[selectedrowindex];  //get selected row

                selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);           //get id of selected person
            }
        }

        private void updateBankInfoButton_Click(object sender, EventArgs e)
        {
            if (selectedID != 0)
            {
                UpdateBankForm update = new UpdateBankForm(DataLogicAdmin.AllAccounts()[selectedID], this);
                update.Show();
            }
            else
            {
                MessageBox.Show("Please select an account");                  //dispay coresponding message
            }
        }

        private void fillBankInfo()
        {
            foreach (var account in DataLogicAdmin.AllAccounts()) //iterate trough data grid
            {
                DataGridViewRow row = new DataGridViewRow();    //create new row and fill it using the dictionary
                row.CreateCells(bankInfoGrid);
                row.Cells[0].Value = account.Key;
                row.Cells[1].Value = account.Value.Name;
                row.Cells[2].Value = Convert.ToString(account.Value.Balance) + "$";

                bankInfoGrid.Rows.Add(row);                     //add to datagrid
            }
        }

        public void updateBankGrid()
        {
            bankInfoGrid.Rows.Clear();  //clear gridview
            fillBankInfo();             //update gridview
        }
    }
}
