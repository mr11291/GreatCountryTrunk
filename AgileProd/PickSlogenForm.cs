using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgileProdDAL;
using AgileProdObjectModel;
namespace AgileProd
{
    public partial class PickSlogenForm : Form
    {
        Member user;
        string selectedPerson = null;

        public PickSlogenForm(Member user)
        {
            InitializeComponent();
            this.user = user;

            slogenList.SelectedIndexChanged += slogenList_SelectedIndexChanged;
        }

        void slogenList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPerson = Convert.ToString(slogenList.FocusedItem.Text);
        }

        private void initializeSlogenList()
        {
            foreach (var member in DataLogicMember.GetMember())
            {
                if (member.Value.Slogan != string.Empty)
                {
                    ListViewItem details = new ListViewItem();
                    string senderId = Convert.ToString(member.Key);
                    string slogen = member.Value.Slogan;
                    details.Text = senderId;
                    details.SubItems.Add(Convert.ToString(slogen));
                    slogenList.Items.Add(details);

                    slogenList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (selectedPerson != null)
            {
                user.Slogan = DataLogicMember.GetMember()[Convert.ToInt32(selectedPerson)].Slogan;
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
