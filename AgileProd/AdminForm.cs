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
        bool buttonClickDelete;
        Admin user;
        //Button btnVoterDel;
        //Button btnVoterUp;

        public AdminForm(Admin admin)
        {

            InitializeComponent();
            user = admin;
            buttonClickVP = false;
            buttonClickDelete = false;
            IDtextbox.Hide();
            IDlabel.Hide();
            ViewPeople.Hide();
            dataGridPeople.Hide();
            tabMenu.SelectedIndexChanged += tabMenu_SelectedIndexChanged;
            //tx = new TextBox();
            //btnVoterDel = new Button();
            //btnVoterUp = new Button();
            //tx.Hide();
            //btnVoterDel.Hide();
            //btnVoterUp.Hide();
            //btnVoterDel.Click += insertDelButton;
            //btnVoterUp.Click += insertUpdateButton;
        }


        //private void btnDelVoter_Click(object sender, EventArgs e)
        //{
        //    comboBox1.Hide();
        //    btnCreateVoter.Hide();
        //    btnUpdateVoter.Hide();
        //    btnDelVoter.Hide();
        //    tx.Show();
        //    btnVoterDel.Show();
        //    btnVoterDel.Text = "Delete";
        //    btnVoterDel.BackColor = Color.Orange;
        //    btnVoterDel.Location = new Point(tx.Location.X, tx.Location.Y + tx.Height);
        //    this.Controls.Add(tx);
        //    this.Controls.Add(btnVoterDel);
            
        //}

        //private void insertDelButton(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string nameUser = DataLogic.AllPersons()[int.Parse(tx.Text.Replace(" ", ""))].name;
        //        DataLogic.DelVoter(int.Parse(tx.Text.Trim()));
        //        MessageBox.Show("User " + nameUser + " Deleted");
        //        tx.Hide();
        //        tx.Clear();
        //        btnVoterDel.Hide();
                
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Not found try again...");
        //        tx.Hide();
        //        tx.Clear();
        //        btnVoterDel.Hide();
        //    }
        //    btnCreateVoter.Show();
        //    btnUpdateVoter.Show();
        //    btnDelVoter.Show();
        //    comboBox1.Show();
            
        //}


        //private void insertUpdateButton(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Person person = DataLogic.AllPersons()[int.Parse(tx.Text.Replace(" ", ""))];
        //        CreateVolterForm cvf = new CreateVolterForm(DataLogic.AllPersons(), this,person);
        //        this.Hide();
        //        cvf.Show();
        //        tx.Hide();
        //        tx.Clear();
        //        btnVoterUp.Hide();

        //    }
        //    catch
        //    {
        //        MessageBox.Show("Not found try again...");
        //        tx.Hide();
        //        tx.Clear();
        //        btnVoterUp.Hide();
        //    }
        //    btnCreateVoter.Show();
        //    btnUpdateVoter.Show();
        //    btnDelVoter.Show();
        //    comboBox1.Show();
        //}

        //private void btnUpdateVoter_Click(object sender, EventArgs e)
        //{
        //    comboBox1.Hide();
        //    btnCreateVoter.Hide();
        //    btnUpdateVoter.Hide();
        //    btnDelVoter.Hide();
        //    tx.Show();
        //    btnVoterUp.Show();
        //    btnVoterUp.Text = "Update";
        //    btnVoterUp.BackColor = Color.Orange;
        //    btnVoterUp.Location = new Point(tx.Location.X, tx.Location.Y + tx.Height);
        //    this.Controls.Add(tx);
        //    this.Controls.Add(btnVoterUp);
        //}

        //private void btnCreateVoter_Click(object sender, EventArgs e)
        //{
        //    AdminForm currentForm = new AdminForm();
        //    CreateVolterForm cvf = new CreateVolterForm(DataLogic.AllPersons(), currentForm, null);
        //    cvf.Show();
        //    this.Hide();
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedItem.ToString() == "Person")
        //    {
        //        btnCreateVoter.Show();
        //        btnDelVoter.Show();
        //        btnUpdateVoter.Show();
        //    }
        //    else
        //    {
        //        btnUpdateVoter.Hide();
        //        btnCreateVoter.Hide();
        //        btnDelVoter.Hide();
        //    }
                        
                
        //}
        
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
                if (IDtextbox.Text == null)
                {
                    if (DataLogicAdmin.DeletePerson(Convert.ToInt32(IDtextbox.Text)))
                    {
                        MessageBox.Show("Person deleted successfuly!");
                    }
                    else
                    {
                        MessageBox.Show("Looks like the id does not exist");
                    }
                    buttonClickDelete = false;
                    IDtextbox.Hide();
                    IDlabel.Hide();
                    ViewPeople.Hide();
                    return;
                }
                else
                {
                    buttonClickDelete = false;
                    IDtextbox.Hide();
                    IDlabel.Hide();
                    ViewPeople.Hide();
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
                dataGridPeople.Show();                                      //show data grid
                this.dataGridPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPeople_CellClick);  //initialize click event handler
                DataGridViewRow row = new DataGridViewRow();                //create a new empty data grid view row 
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
        private void dataGridPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDtextbox.Text = (string)dataGridPeople[0, e.RowIndex].Value; //get's value of clicked cell, converts it to a string and copies it to text box
            return;
        }

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
            }
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
}
