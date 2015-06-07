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
    public partial class UpdateInfoForm : Form
    {
        private Person tempPerson = null;
        AdminFormV2 adminform = null;

        public UpdateInfoForm(Person user, AdminFormV2 form)
        {
            InitializeComponent();
            tempPerson = user; //used only to access person info without overriding button click event
            adminform = form;
            initializeInfo(user);
        }

        /*
         * Show person's updated info
         */
        private void initializeInfo(Person user)
        {
            idBox.Text = Convert.ToString(user.Id);
            nameBox.Text = user.Name;
            ageBox.Text = Convert.ToString(user.Age);
            votingTestBox.Text = Convert.ToString(Convert.ToInt32(user.IsVoting));
            usernameBox.Text = user.UserName;
            passwordBox.Text = user.Password;
            return;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Conformation", MessageBoxButtons.YesNo); //checks if he or she wants to change thier info
            if (dialogResult == DialogResult.Yes)       //if user clicked "Yes"
            {
                //update inforamtion
                DataLogic.ChangeID(this.tempPerson, Convert.ToInt32(idBox.Text));
                DataLogic.ChangeName(this.tempPerson, (nameBox.Text));
                DataLogic.ChangeAge(this.tempPerson, Convert.ToInt32(ageBox.Text));
                DataLogic.ChangeUserName(this.tempPerson, (usernameBox.Text));
                DataLogic.ChangePassword(this.tempPerson, (passwordBox.Text));
                this.tempPerson.IsVoting = Convert.ToBoolean(Convert.ToInt32(votingTestBox.Text));
                adminform.updateInfoGrid();
                MessageBox.Show("Updated succsessfuly");
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
