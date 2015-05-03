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
    public partial class SlogenForm : Form
    {
        //Varaiables
        private Member currMember;
        private String input;

        //Constructor
        public SlogenForm(Member currentMember)
        {
            InitializeComponent();
            this.currMember = currentMember;
            this.input = null;
        }

        //handling change in slogen text box
        private void slogenBox_TextChanged(object sender, EventArgs e)
        {
            this.input = slogenBox.Text;
        }

        //Clicking on submit
        private void Submmit_Click(object sender, EventArgs e)
        {
            if (!(this.input == null))
            {
                DataLogicMember.AddSlogan(currMember, this.input);
                this.Hide();
                return;
            }           
            this.Close();
        }
    }
}
