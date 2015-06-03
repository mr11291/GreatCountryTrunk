using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileProd
{
    public partial class EndingPrimariesPage : Form
    {
        public EndingPrimariesPage()
        {
            InitializeComponent();


            ElectionTimer = new Timer();
            ElectionTimer.Interval = 5000;
            ElectionTimer.Tick += new EventHandler(ElectionTimer_Tick);

            startAnimation();
        }

        private void ElectionTimer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox1.Hide();
            this.Close();
        }

        private void startAnimation()
        {
            ElectionTimer.Start();
            pictureBox1.Enabled = true;
            pictureBox1.Show();
        }
    }
}
