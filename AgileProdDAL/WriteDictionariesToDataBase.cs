using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;
using AgileProdDAL.Properties;

namespace AgileProdDAL
{
    public class WriteDictionariesToDataBase
    {

        private static string path = Settings.Default.DataPath;
        StreamWriter file;

        public WriteDictionariesToDataBase()
        {
            WriteToPeople();
            WriteToPartyMember();
            WriteToCommittee();
            WriteToPartyList();
            WriteToPraimerise();
            WriteToMessage();
            WriteToBank();
            WriteToLastEnty();
            WriteToAdmin();
            WriteToMemento();
        }

        private void WriteToPeople()
        {
            file = new StreamWriter(path + "\\people.txt");

            foreach (var person in DataLogicAdmin.AllPersons().Values)
            {
                file.WriteLine(person.Id + ", " + person.Name + ", " + person.Age + ", " + person.UserName + ", " + person.Password + ", " + person.IsVoting + ", " + person.NumOfVotes);
            }
        }

        private void WriteToPartyMember()
        {
            file = new StreamWriter(path + "\\members.txt");

            foreach (var member in DataLogicAdmin.AllMembers().Values)
            {
                file.WriteLine(member.Id + ", " + member.Party + ", " + member.Location);
            }
        }

        private void WriteToCommittee()
        {
            file = new StreamWriter(path + "\\committee.txt");

            foreach (var committee in DataLogicAdmin.AllCommittee().Values)
            {
                file.WriteLine(committee.Id + ", " + committee.Age);
            }
        }

        private void WriteToPartyList()
        {
            file = new StreamWriter(path + "\\parties.txt");

            foreach (var party in DataLogicAdmin.AllParties())
            {
                file.WriteLine(party.Key + ", " + party.Value);
            }
        }

        private void WriteToPraimerise()
        {
            file = new StreamWriter(path + "\\praimerise.txt");
            if (DataLogicAdmin.PraimeriesStatus())
            {
                file.WriteLine("1");
            }
            else
            {
                file.WriteLine("0");
            } 
        }

        private void WriteToElections()
        {
            file = new StreamWriter(path + "\\elections.txt");
            if (DataLogicCommittee.getElections())
            {
                file.WriteLine("1");
            }
            else
            {
                file.WriteLine("0");
            } 
        }

        private void WriteToMessage()
        {
            file = new StreamWriter(path + "\\messageInbox.txt");
            int i = 0;

            foreach (var message in DataLogicMessage.getMessageDictionary())
            {
                if (message.Value == null)
                {
                    file.WriteLine(message.Key);
                }
                else
                {
                    var messages = DataLogicPerson.getMessages(message.Key);

                    file.Write(message.Key);

                    foreach (var item in messages)
                    {
                        if (messages.Count == 1)
                        {
                            file.WriteLine(item.Item1 + ", " + item.Item2 + ", " + item.Item3);
                        }
                        else
                        {
                            if (i != messages.Count - 1) 
                            {
                                file.Write(item.Item1 + ", " + item.Item2 + ", " + item.Item3 + ", ");
                            }
                            else
                            {
                                file.WriteLine(item.Item1 + ", " + item.Item2 + ", " + item.Item3);
                            }

                            i++;
                        }
                    }
                }
            }
        }

        private void WriteToBank()
        {
            file = new StreamWriter(path + "\\bankAccounts.txt");

            foreach (var account in DataLogicBank.getBankDictionary())
            {
                file.WriteLine(account.Key + ", " + account.Value.Name + ", " + account.Value.Balance);
            }
        }

        private void WriteToLastEnty()
        {
            file = new StreamWriter(path + "\\LastEntry.txt");

            foreach (var log in DataLogicAdmin.AllEntries())
            {
                file.WriteLine(log.Key + ", " + log.Value.Last);
            }
        }

        private void WriteToAdmin()
        {
            file = new StreamWriter(path + "\\admin.txt");

            foreach (var admin in DataLogicAdmin.AllAdmins())
            {
                file.WriteLine(admin.Key + ", " + admin.Value.Name + ", " + admin.Value.UserName + ", " + admin.Value.Password);
            }
        }

        private void WriteToMemento()
        {
            file = new StreamWriter(path + "\\memento.txt");

            foreach (var memento in DataLogicAdmin.AllMementoes())
            {
                file.WriteLine(memento.Key + ", " + memento.Value.PartyName + ", " + memento.Value.location);
            }
        }
    }


}
