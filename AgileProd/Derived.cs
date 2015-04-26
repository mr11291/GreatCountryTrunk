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
    public partial class Derived : PersonForm
    {
        public Derived(Person user) : base(user)
        {
            
            InitializeComponent();
        }
    }
}
