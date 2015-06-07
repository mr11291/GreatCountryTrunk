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
    public partial class BaseForm : Form
    {
        private Person user = null;
        private String selectedPerson = null;

        private BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(Person user)
        {
            this.user = user;
            InitializeComponent();

            //set setting configurations
            username.Text = "User: " + user.Name;

            tabMenu.SelectedIndexChanged += tabMenu_SelectedIndexChanged;
            personList.SelectedIndexChanged += personList_SelectedIndexChanged;

            fromList.View = View.Details;
        }

        void personList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPerson = Convert.ToString(personList.FocusedItem.Text);     //save selected person
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMenu.SelectedIndex)
            {
                case 1:
                    {
                        initializeBankInfo();    //initialize the users bank info
                        bankTab.ImageIndex = -1; //remove red dot from tab
                    }
                    break;
                case 2:
                    {
                        while (fromList.Items.Count > 0)    //clean message list if exists
                        {
                            fromList.Items.RemoveAt(0);
                        }
                        fillMessageList();                  //fill updated message list
                        fillPersonList();                   //fill person list
                    }
                    break;
                case 3:
                    {
                        initializeSettingsInfo();           //initialize users settings
                    }
                    break;
            }
        }

        private void initializeBankInfo()
        {
            try     //try initializing bank settings
            {
                int tempBalance = DataLogicPerson.getBalance(this.user);
                this.nameBox.Text = user.Name;
                this.idBox.Text = Convert.ToString(user.Id);
                this.balanceBox.Text = Convert.ToString(tempBalance) + " $";
            }
            catch (NullReferenceException) 
            {
                this.nameBox.Text = "null";
                this.idBox.Text = "null";
                this.balanceBox.Text = "null";
            }
        }

        private void initializeSettingsInfo()
        {
            this.settingsNameBox.Text = user.Name;
            this.settingsIdBox.Text = Convert.ToString(user.Id);
            this.settingsUserNameBox.Text = user.UserName;
            this.settingsPasswordBox.Text = user.Password;
        }

        private void fillPersonList()
        {
            ListViewItem details = new ListViewItem();

            foreach (var person in DataLogicPerson.getPersonDictionary())
            {
                if (person.Key != user.Id)
                {
                    personList.Items.Add(person.Value.Name);
                }
            }
        }

        private void fillMessageList()
        {
            var messages = DataLogicPerson.getMessages(user);
            if (messages != null)
            {
                foreach (var item in messages)
                {
                    ListViewItem details = new ListViewItem();
                    int senderId = item.Item1;
                    string senderName = DataLogicPerson.getSenderName(senderId);
                    string message = item.Item2;
                    int amount = item.Item3;
                    details.Text = senderName;
                    details.SubItems.Add(Convert.ToString(senderId));
                    fromList.Items.Add(details);

                    fromList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                fromList.Columns[fromList.Columns.Count - 1].Width = -2;
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            ListViewItem details = new ListViewItem();
            try
            {
                details = fromList.SelectedItems[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

            try
            {
                //find message
                foreach (var item in DataLogicPerson.getMessages(user))
                {
                    //find sender id
                    if (item.Item1 == Convert.ToInt32(details.SubItems[1].Text))
                    {
                        //display message
                        MessageForm messageDialog = new MessageForm(item, user);
                        messageDialog.ShowDialog();
                        while (fromList.Items.Count > 0)
                        {
                            fromList.Items.RemoveAt(0);
                        }
                        fillMessageList();
                        //fromList.Clear();
                        //fillMessageList();
                    }
                }
            }
            catch (InvalidOperationException){}
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!(user.Name.Equals(this.settingsNameBox.Text)) ||
                !(user.UserName.Equals(this.settingsUserNameBox.Text)) ||
                !(user.Password.Equals(this.settingsPasswordBox.Text)))
            {
                user.Name = this.settingsNameBox.Text;
                user.UserName = this.settingsUserNameBox.Text;
                user.Password = this.settingsPasswordBox.Text;

                MessageBox.Show("Success!", "Information saved!");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm goback = new LoginForm();
            this.Close();
            goback.Show();
        }

        protected bool checkOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            Tuple<int, string, int> resultMsg = DataLogic.NextMessage(user);
            try
            {
                MessageBox.Show(resultMsg.Item2);
            }
            catch
            {
                MessageBox.Show("No more messages to read");
            }
        }

        private void btnAllMsg_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (var i in DataLogic.AllMessageForSpecificPerson(user))
            {
                result += i + " \n";
            }
            MessageBox.Show(result);
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            int personid = 0;
            if (selectedPerson != null)
            {
                foreach (var person in DataLogicPerson.getPersonDictionary())
                {
                    if (selectedPerson.Equals(person.Value.Name))
                    {
                        personid = person.Key;
                        break;
                    }
                }
            }

            if (personid != 0)
            {
                if (selectedPerson != null)
                {
                    SendMessageFom newForm = new SendMessageFom(user.Id, personid);
                    newForm.ShowDialog();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
           WriteDictionariesToDataBase update= new WriteDictionariesToDataBase();
        }
    }
}
