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
            fillPartyColleague();
            partyList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            partyList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.lblttlmoney.Text = "Total money: " + DataLogic.getBalance(currMember);
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

        private void quitPartyButton_Click(object sender, EventArgs e)//the Quit Party button
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to quit the party? ", "ARE YOU LEAVING US?!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int msg = DataLogicMember.QuitParty(currMember);
                if (msg == 1)
                { 
                    MessageBox.Show("Your request for leaving the party has accepted. Thank's for your service");
                    this.Hide();
                    DataLogicAdmin.AllPersons()[currMember.Id].memento = new Memento(currMember.Party, currMember.Location);
                    DataLogicMember.InsertToMemento(currMember.Id, DataLogicAdmin.AllPersons()[currMember.Id].memento);
                    return;
                }
                else { MessageBox.Show("Error " + msg); }
            }
        }

        private void slogenChangeButton_Click(object sender, EventArgs e)// the button change the slogen
        {

            if (!(Application.OpenForms.OfType<SlogenForm>().Any()))
            {
                SlogenForm newform = new SlogenForm(currMember);
                newform.ShowDialog();
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

        private void fillPartyColleague()
        {
            int charCount = 0;
            string longestname = null;
            foreach (var item in DataLogicMember.returnColleagues(currMember.Party))
            {
                partyList.Items.Add(item.Value.Name);
                if (charCount < item.Value.Name.Length)
                {
                    charCount = item.Value.Name.Length;
                    longestname = item.Value.Name;
                }
            }
            Size textsize = TextRenderer.MeasureText(longestname, this.Font);
            partyList.Width = textsize.Width + 4;

        }


        private void MmberVote_Click(object sender, EventArgs e)
        {   
            //massge with the price that the user going to pay of
            DialogResult dialogResult = MessageBox.Show("You are going to pay " + DataLogicPerson.GetChargeBynumberofvote(currMember.NumOfVotes) + " for the right to vote..", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (DataLogicPerson.VoterFee(currMember) > 0)
                {
                    this.lblttlmoney.Text = "Total money: " + DataLogic.getBalance(currMember);
                    DataLogicPerson.voteToParty(currMember.Party);
                    MessageBox.Show("You voted to " + currMember.Party + " party"); 
                }
                else
                {
                    MessageBox.Show("not enough money!!!");
                }
            }
                
        }



    }
}
