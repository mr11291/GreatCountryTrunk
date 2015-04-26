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
    public partial class MemberForm : Form
    {
        //int type;
        Button addMem;
        TextBox id;
        Member currMember;
        public MemberForm(Member currentMember)
        {
            InitializeComponent();
            this.currMember = currentMember;
            btnAddMem.Hide();
            
            if(currentMember.Location==1)
            {
                lblWelcome.Text = "Hello Member: " + currentMember.Name;
                lblWelcome.Size = new System.Drawing.Size(12, 12);
                //type = 1;
                btnAddMem.Show();
                addMem = new Button();
                addMem.Hide();
                id = new TextBox();
                id.Hide();
                addMem.Click += tryToAdd;
            }
            else
            {
                lblWelcome.Text = "Hello Member: " + currentMember.Name;
                lblWelcome.Size = new System.Drawing.Size(12, 12);
                //type = 0;
            }
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

        public void tryToAdd(object sender,EventArgs e)
        {
            try
            {
                
                Person p=DataLogicAdmin.AllPersons().FirstOrDefault((currVoter) => (currVoter.Key == int.Parse(id.Text))).Value;
                //DataLogic.addMember(p.Id, p.Name, p.Age, p.UserName, p.Password, p.IsVoting, currMember.Party, ReturnLastMemberLocation(currMember.Party) + 1, balance);
            }
            catch
            {
                MessageBox.Show("Error... try again");
            }
            id.Hide();
            addMem.Hide();
            btnAddMem.Show();
        }

        public int ReturnLastMemberLocation(string party)
        {
            return DataLogicAdmin.AllMembers().Where(x => x.Value.Party==party).Max(x => x.Value.Location);
        }
    }
}
