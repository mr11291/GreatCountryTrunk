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
                moneytrackBar.Maximum = DataLogicBank.getBankDictionary()[sender].Balance;
                moneytrackBar.Value = DataLogicPerson.getVotingFeeByNumOfVotes(DataLogicPerson.getPersonDictionary()[reciverID].NumOfVotes);
                currentMoneyBox.Text = Convert.ToString(DataLogicPerson.getVotingFeeByNumOfVotes(DataLogicPerson.getPersonDictionary()[reciverID].NumOfVotes));
                maxLabel.Text = Convert.ToString(DataLogicBank.getBankDictionary()[sender].Balance);
                initializeJobOffer();
                initializeBribeOffer();

                moneytrackBar.Show();
                minLabel.Show();
                maxLabel.Show();
                currentMoneyBox.Show();

                messageMenu.Show();
                messageMenu.SelectedIndexChanged += messageMenu_SelectedIndexChanged;
            }
        }

        void messageMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (messageMenu.SelectedIndex)
            {
                case 0:
                    {
                        moneytrackBar.Show();
                        maxLabel.Show();
                        minLabel.Show();
                        currentMoneyBox.Show();
                        initializeBribeOffer();
                    }
                    break;
                case 1:
                    {
                        moneytrackBar.Hide();
                        maxLabel.Hide();
                        minLabel.Hide();
                        currentMoneyBox.Hide();
                        initializeJobOffer();
                    }
                    break;
            }
        }

        private void moneytrackBar_Scroll(object sender, EventArgs e)
        {
            currentMoneyBox.Text = Convert.ToString(moneytrackBar.Value);
            bribeAmount = moneytrackBar.Value;
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
                                 ", I would love if you kindly vote for me. Here is a little insentive." +
                                 " " + bribeAmount;
        }

        private void initializeJobOffer()
        {
            jobOfferBox.Text = "Dear " +
                               DataLogicPerson.getPersonDictionary()[reciverID].Name +
                               ", We have reviewed your account and we would like you to join " +
                               DataLogicMember.GetMember()[senderID].Party;
        }
    }
}
