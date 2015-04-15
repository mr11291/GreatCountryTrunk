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
using System.Collections.ObjectModel;
using AgileProdDAL;

namespace AgileProd
{
    public partial class CreateVolterForm : Form
    {
        ReadOnlyDictionary<int,Person> people;
        Form preForm;
        Person person;
        public CreateVolterForm(ReadOnlyDictionary<int,Person> people,Form preForm,Person p)
        {
            InitializeComponent();
            this.people = people;
            this.preForm = preForm;
            this.person = p;
            if (person != null)
                UpdateFields();
        }


        public void UpdateFields()
        {
            textBoxname.Text = person.name;
            textBox1.Text = person.id.ToString();
            textBoxage.Text = person.age.ToString();
            textBoxusername.Text = person.userName;
            textBoxpassword.Text = person.password;
            textBoxBalance.Text = person.balance.ToString();
        }



        private void btnReg_Click(object sender, EventArgs e)
        {
            Validation valid=new Validation();
            if (valid.CheckNameValid(textBoxname.Text) && valid.CheckAgeValid(int.Parse(textBoxage.Text)) && valid.CheckUserNameValid(textBoxusername.Text) && valid.CheckPasswordValid(textBoxpassword.Text))
            {
                if (valid.CheckIDExist(int.Parse(textBox1.Text)))
                    MessageBox.Show("id exist, updating... ");
                    DataLogic.DelVoter(int.Parse(textBox1.Text));
                DataLogic.addVoter(int.Parse(textBox1.Text), textBoxname.Text, int.Parse(textBoxage.Text), textBoxusername.Text, textBoxpassword.Text, int.Parse(textBoxBalance.Text), false);
                this.preForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show(valid.NotValid());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.preForm.Show();
            this.Hide();
        }
    }
}
