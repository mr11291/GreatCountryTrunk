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

namespace AgileProd
{
    public partial class MessageForm : Form
    {
        Tuple<int, string, int> messageItem = null;

        public MessageForm(Tuple<int, string, int> Item)
        {
            InitializeComponent();
            messageItem = Item;
            this.Text = "Message From " + DataLogicPerson.getPersonDictionary()[messageItem.Item1].Name + ":";
            fillmessageBox();
        }

        void fillmessageBox(){
            messageBox.Text = messageItem.Item2;
        }
    }
}
