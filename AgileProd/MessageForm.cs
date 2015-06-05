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

        private void yesButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (messageItem.Item3 > 0)
            {

                if (DataLogicBank.getBankDictionary()[messageItem.Item1].withdrawl(messageItem.Item3) != 0)          //try to withdrawl from sender's account
                {   
                    DataLogicBank.getBankDictionary()[user.Id].deposit(messageItem.Item3);                          //deposit into reciver's account

                    DataLogicPerson.voteToMember(DataLogicPerson.getPersonDictionary()[messageItem.Item1].Name);    //vote for sender 
                    DataLogicBank.getBankDictionary()[messageItem.Item1].withdrawl(DataLogicPerson.getVotingFeeByNumOfVotes(user.NumOfVotes)); //withdrawl from reciver's account

                }
                else
                {
                    MessageBox.Show("Looks like " + DataLogicPerson.getPersonDictionary()[messageItem.Item1].Name + " doesn't have enough money");
                }

                foreach (var message in DataLogicMessage.getMessageDictionary()[user.Id].Inbox)
                {
                    if (message.Item1 == messageItem.Item1 && message.Item2.Equals(messageItem.Item2) && message.Item3 == message.Item3)
                    {
                        DataLogicMessage.getMessageDictionary()[user.Id].removeMessage(i);
                        if (DataLogicMessage.getMessageDictionary()[user.Id].Count == 0)
                        {
                            DataLogicMessage.getMessageDictionary().Remove(user.Id);
                            DataLogicMessage.getMessageDictionary().Add(user.Id, null);
                            break;
                        }
                    }
                    i++;
                }
            }
            else if (DataLogicMember.GetMember().Keys.Contains(messageItem.Item1) && messageItem.Item3 == 0)
            {

            }

            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {

        }
    }
}
