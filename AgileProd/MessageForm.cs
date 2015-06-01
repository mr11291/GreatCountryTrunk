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
    public partial class MessageForm : Form
    {
        private Tuple<int, string, int> messageItem = null;
        private Person user = null;

        public MessageForm(Tuple<int, string, int> Item, Person user)
        {
            InitializeComponent();
            messageItem = Item;
            buildForm();
            this.user = user;
            this.Text = "Message From " + DataLogicPerson.getPersonDictionary()[messageItem.Item1].Name + ":";
            fillmessageBox();
        }

        void fillmessageBox(){
            messageBox.Text = messageItem.Item2;
        }

        void buildForm()
        {
            if (messageItem.Item3 == 0)
            {
                replyButton.Show();
                cancelButton.Show();
                nextButton.Show();
            }
            else
            {
                yesButton.Location = new Point(12, 166);
                noButton.Location = new Point(93, 166);
                cancelButton.Location = new Point(174, 166);
                yesButton.Show();
                noButton.Show();
                cancelButton.Show();

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void replyButton_Click(object sender, EventArgs e)
        {
            SendMessageFom reply = new SendMessageFom(user.Id, messageItem.Item1);
            reply.ShowDialog();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Tuple<int, string, int> nextMessage = DataLogic.NextMessage(user);
            try
            {
                MessageForm nextMessageForm = new MessageForm(nextMessage, user);
                nextMessageForm.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("No more messages to read");
            }
        }
    }
}
