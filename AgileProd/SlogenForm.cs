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
        private Member currMember;
        private String input;

        public SlogenForm(Member currentMember)
        {
            InitializeComponent();
            this.currMember = currentMember;
            this.input = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//text box
        {
            
            this.input = slogenBox.Text;

        }

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
