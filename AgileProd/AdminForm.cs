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
    public partial class AdminForm : Form
    {
        bool buttonClickVP;
        bool buttonClickLP;
        bool buttomClickLM;
        bool buttonClickDelete;
        Admin user;
        //Button btnVoterDel;
        //Button btnVoterUp;

        public AdminForm(Admin admin)
        {

            InitializeComponent();
            user = admin;
            buttonClickVP = false;
            buttonClickLP = false;
            buttomClickLM = false;
            buttonClickDelete = false;
            IDtextbox.Hide();
            IDlabel.Hide();
            //ViewPeople.Hide();
            dataGridPeople.Hide();
            dataGridParty.Hide();
            tabMenu.SelectedIndexChanged += tabMenu_SelectedIndexChanged;
            tabMenu.TabPages[4].Text = "Messages " + "[" + DataLogicAdmin.getMessageCount(user) + "]";

        }

        /*
         * AddPerson_Click is a button function of AdminForm
         * it's job is to open the create person form
         */
        private void AddPerson_Click(object sender, EventArgs e)
        {
            AdminForm currentForm = new AdminForm(user);                                                     //set current form
            CreateVoterForm voterForm = new CreateVoterForm(DataLogicAdmin.AllPersons(), currentForm, null); //initialize new voter form
            voterForm.Show();                                                                                //open voter form
            this.Hide();                                                                                     //close current form
        }

        /*
         * DeletePerson_Click is a button function of AdminForm
         * it's job is to open the deletion options of admin
         */
        private void DeletePerson_Click(object sender, EventArgs e)
        {
            if (this.buttonClickDelete == false)
            {
                IDlabel.Show();        //show ID
                IDtextbox.Show();      //show textbox
                ViewPeople.Show();     //show people list

                MessageBox.Show("Please select a person's ID and then press 'Delete person' once again");
                this.buttonClickDelete = true;
            }
            else
            {
                if (IDtextbox.Text != null)
                {
                    if (DataLogicAdmin.DeletePerson(Convert.ToInt32(IDtextbox.Text)))
                    {
                        MessageBox.Show("Person deleted successfuly!");
                        Refresh();
                        //this.buttonClickVP = false ;
                        dataGridPeople.Hide();
                       // dataGridPeople.Dispose();
                       // dataGridPeople = new DataGridView();
                      
                        dataGridPeople.ClearSelection();
                        IDtextbox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Looks like the id does not exist");
                    }

                    dataGridPeople.Rows.Clear();

                    buttonClickDelete = false;
                    IDtextbox.Hide();
                    IDtextbox.Clear();
                    IDlabel.Hide();
                 //   ViewPeople.Hide();
                    return;
                }
                else
                {
                    buttonClickDelete = false;
                    IDtextbox.Hide();
                    IDlabel.Hide();
                   // ViewPeople.Hide();
                    return;
                }
            }
        }

        /*
         * ViewPeople_Click is a button function of AdminForm
         * it's job is to open the data grid view and fill it with people
         */
        private void ViewPeople_Click(object sender, EventArgs e)
        {
            
            if (this.buttonClickVP == false)
            {
                dataGridPeople.Show();                                      //show data grid  //initialize click event handler
                DataGridViewRow row = new DataGridViewRow(); 
                //create a new empty data grid view row
                var temp = DataLogicAdmin.AllPersons();                          //get persons read only dictionary
                
                foreach (var item in temp.Values)                           //loop trough dictionary 
                {
                    dataGridPeople.Rows.Add(item.Id.ToString(), item.Name, item.Age.ToString(), item.UserName, item.Password, item.IsVoting.ToString());  //add values to grid vie
                }

                this.buttonClickVP = true;
                return;
            }
            else
            {
                dataGridPeople.Hide();
                this.buttonClickVP = false;
                return;
            }

        }












        /*
         * dataGridPeople_CellClick is an event hander of class AdminForm
         */

        private void btnDelParty_Click(object sender, EventArgs e)
        {
            if (txtDelParty.Text == "")
            {
                MessageBox.Show("Please enter party name for delete");
                
            }
            else
            {
                DataLogic.DelParty(txtDelParty.Text);
                txtDelParty.Text = "";
                MessageBox.Show("deleted :)");
                dataGridParty.Rows.Clear();
                dataGridParty.Hide();
            }
            txtDelParty.Clear();
            buttonClickLP = false;
  
        }

        private void btnWithdrwl_Click(object sender, EventArgs e)
        {
            if (txtAmntdrwl.Text == "")
            {
                MessageBox.Show("Please enter amount to withdrawal.");
                return;
            }

            if (txtWthdrwl.Text == "")
            {
                MessageBox.Show("Please enter id for withdrawal.");
                return;
            }

            DataLogic.WithdrawalPeronAcc(int.Parse(txtWthdrwl.Text), int.Parse(txtAmntdrwl.Text));
        }
    
        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabMenu.SelectedIndex)
            {
            case 4:
                {
                    tabMenu.TabPages[4].Text = "Messages";
                    fillMessageList(user.Id);
                }
                break;
            }
        }

        private void fillMessageList(int id)
        {
            if (MessageList.Items.Count != 0)
            {
                MessageList.Items.Clear();
            }
            
            var messages = DataLogicAdmin.getMessages(user);
            if (messages != null)
            {
                foreach (var item in messages)
                {
                    int senderId = item.Item1;
                    string message = item.Item2;
                    string senderName = null;

                    if (DataLogicAdmin.AllAdmins().ContainsKey(senderId))
                    {
                        senderName = DataLogicAdmin.AllAdmins()[senderId].Name;
                    }
                    else if (DataLogicAdmin.AllPersons().ContainsKey(senderId))
                    {
                        senderName = DataLogicAdmin.AllPersons()[senderId].Name;
                    }

                    if (senderName != null)
                    {
                        MessageList.Items.Add(senderName + ": " + message);
                    }
                    else
                    {
                        MessageList.Items.Add("ERROR! you shouldnt get here!");
                    }


                }
            }

        }

        private void RegisterVoter_Click(object sender, EventArgs e)
        {
           
            IDtextbox.Show();
            if(IDtextbox.Text!="")
            {
                DataLogicAdmin.registerVoter(int.Parse(IDtextbox.Text));
                MessageBox.Show(DataLogicAdmin.AllPersons()[int.Parse(IDtextbox.Text)].Name + " register");
                IDtextbox.Clear();
                IDtextbox.Hide();
                dataGridPeople.Hide();
                buttonClickVP = false;
            }
            IDtextbox.Clear();
            dataGridPeople.Rows.Clear();

        }

        private void RevokeVoter_Click(object sender, EventArgs e)
        {
            IDtextbox.Show();
            if (IDtextbox.Text != "")
            {
                DataLogicAdmin.revokeVoter(int.Parse(IDtextbox.Text));
                MessageBox.Show(DataLogicAdmin.AllPersons()[int.Parse(IDtextbox.Text)].Name + " revoke");
                IDtextbox.Clear();
                IDtextbox.Hide();
                dataGridPeople.Hide();
                buttonClickVP = false;
            }
            IDtextbox.Clear();
            dataGridPeople.Rows.Clear();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {

        }

        private void btnListP_Click(object sender, EventArgs e)
        {
             
            if (this.buttonClickLP == false)
            {
                dataGridParty.Show();                                   //show data grid
                 //initialize click event handler
                DataGridViewRow row = new DataGridViewRow();
                //create a new empty data grid view row
                var temp = DataLogicAdmin.AllParties();                          //get persons read only dictionary

                foreach (var item in temp.Keys)                           //loop trough dictionary 
                {
                    dataGridParty.Rows.Add(item.ToString());  //add values to grid vie
                }

                this.buttonClickLP = true;
                return;
            }
            else
            {
                dataGridParty.Hide();
                dataGridParty.Rows.Clear();
                this.buttonClickLP = false;
                return;
            }
        }


        private void dataGridPeople_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IDtextbox.Text = (string)dataGridPeople[0, e.RowIndex].Value; //get's value of clicked cell, converts it to a string and copies it to text box
            return;
        }




        private void btnPraimeriesStatus_Click(object sender, EventArgs e)
        {
            bool a = DataLogicAdmin.PraimeriesStatus();
            MessageBox.Show(a.ToString());
        }

        private void btnChangePStatus_Click(object sender, EventArgs e)
        {
            DataLogicAdmin.ChangePraimeryStatus();
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            if (this.buttomClickLM == false)
            {
                dataGridMember.Show();                                   //show data grid
                //initialize click event handler
                DataGridViewRow row = new DataGridViewRow();
                //create a new empty data grid view row
                var temp = DataLogicAdmin.AllMembers();                          //get persons read only dictionary

                foreach (var item in temp.Values)                           //loop trough dictionary 
                {
                    dataGridMember.Rows.Add(item.Id.ToString(), item.Name, item.Age.ToString(), item.Location.ToString(), item.Party);  //add values to grid vie
                }

                this.buttomClickLM = true;
                return;
            }
            else
            {
                dataGridMember.Hide();
                dataGridMember.Rows.Clear();
                this.buttomClickLM = false;
                return;
            }
        }

        private void txtIDForMember_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridMember(object sender, DataGridViewCellEventArgs e)
        {
            txtIDForMember.Text = (string)dataGridMember[0, e.RowIndex].Value;
        }

        private void dataGridParty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDelParty.Text = (string)dataGridParty[0, e.RowIndex].Value; //get's value of clicked cell, converts it to a string and copies it to text box
            return;
        }


        private void btnPersonToParty_Click_1(object sender, EventArgs e)
        {
            IDtextbox.Show();
            if (IDtextbox.Text == "")
            {
                MessageBox.Show("Please enter ID");

            }
            else
            {
                if (txtPartyNameForPerson.Text != "")
                {
                    DataLogicAdmin.AddPerosnToParty(int.Parse(IDtextbox.Text), txtPartyNameForPerson.Text, 0);
                    IDtextbox.Text = "";
                    txtPartyNameForPerson.Text = "";
                    MessageBox.Show("Added :)");
                    dataGridMember.Rows.Clear();
                    dataGridMember.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter party name");
                }

            }
            IDtextbox.Clear();
            txtPartyNameForPerson.Clear();
            buttomClickLM = false;
            dataGridMember.Rows.Clear();
        }







    }
}
