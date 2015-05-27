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
    public partial class UpdateBankForm : Form
    {
        Bank tempbank = null;
        AdminFormV2 tempadmin = null;

        public UpdateBankForm(Bank bank, AdminFormV2 admin)
        {
            InitializeComponent();
            tempbank = bank;
            tempadmin = admin;
            initializeInfo();
        }

        private void initializeInfo()
        {
            idBox.Text = Convert.ToString(tempbank.Id);
            nameBox.Text = tempbank.Name;
            balanceBox.Text = Convert.ToString(tempbank.Balance);

            return;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Conformation", MessageBoxButtons.YesNo); //checks if he or she wants to change thier info
            if (dialogResult == DialogResult.Yes)       //if user clicked "Yes"
            {
                //update inforamtion
                tempbank.Balance = Convert.ToInt32(balanceBox.Text);
                tempadmin.updateBankGrid();
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
