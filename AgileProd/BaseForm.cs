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

namespace AgileProd
{
    public partial class BaseForm : Form
    {
        private Person user;

        private BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(Person user)
        {
            this.user = user;
            InitializeComponent();
        }

    }
}
