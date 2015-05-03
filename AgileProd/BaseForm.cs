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
        private Person user;

        private BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(Person user)
        {
            this.user = user;
            InitializeComponent();
            tabMenu.SelectedIndexChanged += tabMenu_SelectedIndexChanged;
            fromList.View = View.Details;
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMenu.SelectedIndex)
            {
                case 1:
                    {
                        initializeBankInfo();
                    }
                    break;
                case 2:
                    {
                        //tabMenu.TabPages[2].Text = "Messages";
                        while (fromList.Items.Count > 0)
                        {
                            fromList.Items.RemoveAt(0);
                        }
                        fillMessageList();
                    }
                    break;
                case 3:
                    {
                        initializeSettingsInfo();
                    }
                    break;
            }
        }

        private void initializeBankInfo()
        {
            int tempBalance = DataLogicPerson.getBalance(this.user);
            this.nameBox.Text = user.Name;
            this.idBox.Text = Convert.ToString(user.Id);
            this.balanceBox.Text = Convert.ToString(tempBalance) + " $";
        }

        private void initializeSettingsInfo()
        {
            this.settingsNameBox.Text = user.Name;
            this.settingsIdBox.Text = Convert.ToString(user.Id);
            this.settingsUserNameBox.Text = user.UserName;
            this.settingsPasswordBox.Text = user.Password;
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
            details = fromList.SelectedItems[0];
            
            //find message
            foreach (var item in DataLogicPerson.getMessages(user))
            {
                //find sender id
                if (item.Item1 == Convert.ToInt32(details.SubItems[1].Text))
                {
                    //display message
                    DialogResult dialogResult = MessageBox.Show(item.Item2, Convert.ToString(details.SubItems[0].Text) + ":", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //if its a bribe offer
                        if (DataLogicPerson.isMember(item.Item1) && item.Item3 > 0)
                        {
                            if (DataLogicPerson.voteToMember(user, item.Item1))
                            {
                                MessageBox.Show("You have voted for" + DataLogicPerson.getMemberNameById(item.Item1));
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }

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
            //TODO update database
            this.Close();
            goback.Show();
        }

        private void settingsNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingsIdBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
