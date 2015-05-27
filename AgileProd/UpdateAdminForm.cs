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
    public partial class UpdateAdminForm : Form
    {
        Admin tempAdmin = null;
        AdminFormV2 tempForm = null;

        public UpdateAdminForm(Admin admin, AdminFormV2 form)
        {
            InitializeComponent();
            tempAdmin = admin;
            tempForm = form;
            initializeInfo();
        }

        private void initializeInfo()
        {
            idBox.Text = Convert.ToString(tempAdmin.Id);
            nameBox.Text = tempAdmin.Name;
            usernameBox.Text = tempAdmin.UserName;
            passwordBox.Text = tempAdmin.Password;

            return;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Conformation", MessageBoxButtons.YesNo); //checks if he or she wants to change thier info
            if (dialogResult == DialogResult.Yes)       //if user clicked "Yes"
            {
                //update inforamtion
                tempAdmin.Name = nameBox.Text;
                tempAdmin.UserName = usernameBox.Text;
                tempAdmin.Password = passwordBox.Text;
                tempForm.updateAdminGrid();
                this.Close();                            //finish conformation event
            }
            else if (dialogResult == DialogResult.No)   //if user clicked "No"
            {
                return;                                 //finish click button event
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
