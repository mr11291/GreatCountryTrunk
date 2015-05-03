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
    public partial class MemberForm : BaseForm
    {

        Button addMem = null;
        TextBox id = null;

        Member currMember;
        

        public MemberForm(Member currentMember): base(currentMember)
        {
            InitializeComponent();
            this.currMember = currentMember;
            initializeSettingsInfo();
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            lblWelcome.Hide();
            btnAddMem.Hide();
            id.Show();
            addMem.Show();
            addMem.Text = "Add";
            addMem.BackColor = Color.Orange;
            addMem.Location = new Point(id.Location.X, id.Location.Y + id.Height);
            this.Controls.Add(id);
            this.Controls.Add(addMem);
        }

        private void button3_Click(object sender, EventArgs e)//the Quit Party button
        {
            DialogResult dialogResult = MessageBox.Show("You sure that you whant to quit the party? ", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int msg = DataLogicMember.QuitParty(currMember);
                if (msg == 1)
                { MessageBox.Show("You'r request for leaving the party has accepted. Thank's for your service at the party");
                  this.Hide();
                  return;
                }
                else { MessageBox.Show("Error " + msg); }

            }
        }

        private void button6_Click(object sender, EventArgs e)// the button change the slogen
        {

            if (!(Application.OpenForms.OfType<SlogenForm>().Any()))
            {
                SlogenForm newform = new SlogenForm(currMember);
                newform.Show();
            }
            else
            {
                initializeSettingsInfo();
            }
        }

        private void initializeSettingsInfo()// initialize the info for the boxes in vthe window form
        {
            int PartyLeader = DataLogicMember.mostRich(currMember.Party, DataLogicMember.GetMember());
            this.PartyNameBox.Text = currMember.Party;
            this.PartySlogenBox.Text = DataLogicMember.GetMember()[PartyLeader].Slogan;
            this.MySlogenBox.Text = currMember.Slogan;
            
        }
    }
}
