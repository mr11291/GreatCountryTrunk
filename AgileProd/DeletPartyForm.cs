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
    public partial class DeletPartyForm : Form
    {
        private String input;

        public DeletPartyForm()
        {
            InitializeComponent();
            this.input = "";
            inputWarning.Hide();
            inputWarning2.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputWarning.Hide();
            inputWarning2.Hide();
            if(!(textBox1.Equals("")))
            {
                this.input = textBox1.Text;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.input.Equals(""))
                {
                    inputWarning2.Show(); 
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete this party? ", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (DataLogicCommittee.DeleteParty(this.input) == false)
                        {
                            this.input = String.Empty;
                            inputWarning.Show();
                        }
                        else
                        {
                            this.input = "";
                            this.Hide();
                        }
                    }

                }

            }
            catch (NullReferenceException) { };

        }


    }
}
