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
    public partial class PersonForm : Form
    {
        public PersonForm(Person user)
        {
            InitializeComponent();
            this.InfoGrid.Hide();
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            this.InfoGrid.Show();
            foreach (var item in DataLogicAdmin.AllMembers().Values)
            {
                InfoGrid.Rows.Add(item.Id, item.Name);
            }
            
            //InfoGrid.Rows.Add()
            //foreach (DataLogic)

        }
    }
}
