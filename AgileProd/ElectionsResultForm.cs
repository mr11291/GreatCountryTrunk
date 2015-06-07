using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgileProdDAL;
using AgileProdObjectModel;

namespace AgileProd
{
    public partial class ElectionsResultForm : Form
    {
        public ElectionsResultForm()
        {
            InitializeComponent();
            Shown += ElectionsResultForm_Shown;
            
            
        }

        void ElectionsResultForm_Shown(object sender, EventArgs e)
        {
            sortGoverment();
        }

        private void sortGoverment()
        {
            int i = 0;
            int counter = 0;
            int row = 0;
            int col = 0;
            int height = 1;
            int padding = 10;
            int xLocation = 0;
            int yLocation = 0;
            bool winnigParty = true, stop = false;

            CheckBox[] chair = new CheckBox[DataLogicMember.GetMember().Count];
            Label[] memberName = new Label[DataLogicMember.GetMember().Count];
            Label[] partyName = new Label[DataLogicMember.GetMember().Count];

            bool[,] locationMatrix = 
            {
                 {false, false, false, false, false, false, false, false, false},
                 {false, false, false, true,  true,  true,  false, false, false},
                 {true,  true,  true,  true,  true,  true,  true,  true,  true},
                 {true,  true,  true,  true,  true,  true,  true,  true,  true},
                 {true,  true,  false, false, false, false, false, true,  true},
                 {true,  true,  false, false, false, false, false, true,  true}
            };
            
            //sort dictionaries 
            var sortedPartyDict = from party in DataLogicCommittee.GetPartyList() orderby party.Value descending select party;
            var sortedMemberDict = from member in DataLogicMember.GetMember() orderby member.Value.Location descending select member;

            //iterate trough partys and members and find them a chair
            foreach (var ascendingParty in sortedPartyDict)
            {
                foreach (var member in sortedMemberDict)
                {
                    if (member.Value.Party.Equals(ascendingParty.Key))
                    {

                        for (row = 0; row < locationMatrix.GetLength(0); row++)
                        {
                            for (col = 0; col < locationMatrix.GetLength(1); col++)
                            {

                                if (locationMatrix[row, col] == true && (member.Value.Location != -1 || winnigParty != true))
                                {
                                    counter++;
                                    //gui size goes here!
                                    xLocation = (int)1000 / 9 * col + 80;
                                    yLocation = (int)400 / 6 * row + 55;
                                    //mark place as already seen
                                    locationMatrix[row, col] = false;
                                    //stop iterating trough matrix
                                    stop = true;
                                    break;
                                }
                            }
                            if (stop == true)
                            {
                                break;
                            }
                        }
                        
                        stop = false;
                            
                        //create new chair and a name
                        chair[i] = new CheckBox();
                        chair[i].Visible = true;
                        chair[i].AutoSize = true;
                        chair[i].Bounds = new Rectangle(10, 20 + padding + height, 40, 22);
                        
                        memberName[i] = new Label();
                        memberName[i].Visible = true;
                        memberName[i].AutoSize = true;

                        partyName[i] = new Label();
                        partyName[i].Visible = true;
                        partyName[i].AutoSize = true;
                        
                        //name chair after it's number
                        chair[i].Name = "chair" + i.ToString();
                        memberName[i].Name = "name" + i.ToString();
                        partyName[i].Name = "party" + i.ToString();

                        //if it's the party leader of the winning party
                        if (member.Value.Location == -1 && winnigParty == true)
                        {
                            chair[i].Location = new Point(520, 50); //gui size / total number of columns * column number where the true value is at
                            chair[i].Checked = true;
                        
                            memberName[i].Text = member.Value.Name;
                            memberName[i].Font = new Font(memberName[i].Font, FontStyle.Bold);
                            memberName[i].Location = new Point(490, 70);

                            partyName[i].Text = ascendingParty.Key;
                            partyName[i].Location = new Point(490, 85);

                            winnigParty = false;

                        }
                        else //if its any other party member
                        {
                            chair[i].Location = new Point(xLocation, yLocation);
                            chair[i].Checked = true;

                            memberName[i].Text = member.Value.Name;
                            if (member.Value.Location == -1)
                            {
                                memberName[i].Font = new Font(memberName[i].Font, FontStyle.Bold);
                            }
                            //if (xLocation == 0)
                            //    MessageBox.Show("xl = 0");
                            memberName[i].Location = new Point(xLocation - 30, yLocation + 20);

                            partyName[i].Text = ascendingParty.Key;
                            partyName[i].Location = new Point(xLocation - 30, yLocation + 35);
                        }

                        row = 0;
                        col = 0;
                        xLocation = 0;
                        yLocation = 0;

                        this.Controls.Add(chair[i]);
                        this.Controls.Add(memberName[i]);
                        this.Controls.Add(partyName[i]);

                        i++;
                    }
                }
            }
        }
    }
}
