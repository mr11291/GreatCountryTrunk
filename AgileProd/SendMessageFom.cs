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
    public partial class SendMessageFom : Form
    {

        int senderID = 0;
        int reciverID = 0;
        int bribeAmount = 0;

        public SendMessageFom(int sender, int reciver)
        {
            InitializeComponent();
            senderID = sender;
            reciverID = reciver;
            if (DataLogicMember.GetMember().Keys.Contains(sender))
            {
                moneytrackBar.Minimum = 1;
                moneytrackBar.Maximum = DataLogicBank.getBankDictionary()[sender].Balance;
                if (DataLogicPerson.getPersonDictionary()[reciverID].NumOfVotes == 0)
                {
                    moneytrackBar.Value = 1;
                    currentMoneyBox.Text = "1";
                }
                else
                {
                    moneytrackBar.Value = DataLogicPerson.getVotingFeeByNumOfVotes(DataLogicPerson.getPersonDictionary()[reciverID].NumOfVotes);
                    currentMoneyBox.Text = Convert.ToString(DataLogicPerson.getVotingFeeByNumOfVotes(DataLogicPerson.getPersonDictionary()[reciverID].NumOfVotes));
                }
                
                maxLabel.Text = Convert.ToString(DataLogicBank.getBankDictionary()[sender].Balance);
                initializeJobOffer();
                initializeBribeOffer();

                moneytrackBar.Show();
                minLabel.Show();
                maxLabel.Show();
                currentMoneyBox.Show();
                bribeOfferBox.Show();

                messageMenu.Show();
                messageMenu.SelectedIndexChanged += messageMenu_SelectedIndexChanged;
            }
            else
            {
                regularMessageBox.Show();
            }
        }

        void messageMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (messageMenu.SelectedIndex)
            {
                case 0:
                    {
                        jobOfferBox.Hide();
                        moneytrackBar.Show();
                        bribeOfferBox.Show();
                        maxLabel.Show();
                        minLabel.Show();
                        currentMoneyBox.Show();
                        initializeBribeOffer();
                    }
                    break;
                case 1:
                    {
                        moneytrackBar.Hide();
                        bribeOfferBox.Hide();
                        maxLabel.Hide();
                        minLabel.Hide();
                        currentMoneyBox.Hide();
                        jobOfferBox.Show();
                        initializeJobOffer();
                    }
                    break;
            }
        }

        private void moneytrackBar_Scroll(object sender, EventArgs e)
        {
            currentMoneyBox.Text = Convert.ToString(moneytrackBar.Value);
            bribeAmount = moneytrackBar.Value;
            initializeBribeOffer();
            try
            {
                if (bribeAmount <= DataLogicPerson.getVotingFeeByNumOfVotes(DataLogicPerson.getPersonDictionary()[reciverID].NumOfVotes))
                {
                    currentMoneyBox.ForeColor = Color.Red;
                }
                else
                {
                    currentMoneyBox.ForeColor = Color.Black;
                }
            }
            catch { }
        }

        private void initializeBribeOffer()
        {
            bribeOfferBox.Text = "Dear " +
                                 DataLogicPerson.getPersonDictionary()[reciverID].Name +
                                 ", I would love if you could kindly vote for me. Here is a little insentive -" +
                                 " " + currentMoneyBox.Text + "$";
        }

        private void initializeJobOffer()
        {
            jobOfferBox.Text = "Dear " +
                               DataLogicPerson.getPersonDictionary()[reciverID].Name +
                               ", We have reviewed your account and we would like you to join " +
                               DataLogicMember.GetMember()[senderID].Party;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Person reciver = DataLogicPerson.getPersonDictionary()[reciverID];

            if (regularMessageBox.Visible)
            {
                try
                {
                    DataLogicMessage.getAllMessages(reciver.Id).addMessage(senderID, regularMessageBox.Text, 0);
                }
                catch (NullReferenceException)
                {
                    AgileProdObjectModel.Message newInbox = new AgileProdObjectModel.Message(senderID, regularMessageBox.Text, 0);
                    DataLogicMessage.getMessageDictionary()[reciverID] = newInbox;
                }
            }
            else if (bribeOfferBox.Visible)
            {
                try
                {
                    DataLogicMessage.getAllMessages(reciver.Id).addMessage(senderID, bribeOfferBox.Text, Convert.ToInt32(currentMoneyBox.Text));
                }
                catch (NullReferenceException)
                {
                    AgileProdObjectModel.Message newInbox = new AgileProdObjectModel.Message(senderID, bribeOfferBox.Text, Convert.ToInt32(currentMoneyBox.Text));
                    DataLogicMessage.getMessageDictionary()[reciverID] = newInbox;
                }
            }
            else if (jobOfferBox.Visible)
            {
                try
                {
                    DataLogicMessage.getAllMessages(reciver.Id).addMessage(senderID, jobOfferBox.Text, 0);
                }
                catch (NullReferenceException)
                {
                    AgileProdObjectModel.Message newInbox = new AgileProdObjectModel.Message(senderID, jobOfferBox.Text, 0);
                    DataLogicMessage.getMessageDictionary()[reciverID] = newInbox;
                }
            }

            this.Close();
        }
    }
}
