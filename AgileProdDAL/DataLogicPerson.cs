using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;

namespace AgileProdDAL
{
    public static class DataLogicPerson
    {
        //Varaiables
        private static DataRepository data;
        private static int baseFee = 800;
        
        //Setter Getter
        public static int BaseFee
        {
          get { return DataLogicPerson.baseFee; }
          set { DataLogicPerson.baseFee = value; }
        }

        //Constructor
        static DataLogicPerson()
        {
            data = DataRepository.GetDataRepository();
        }

        //LoginPerson is a function used to log in to the system as a person
        public static Person LoginPerson(string username, string password)
        {
            //Person p = data.GetPeople().FirstOrDefault((currPer) => (currPer.Value.userName == username.Replace(" ", "") && currPer.Value.password == password.Replace(" ", ""))).Value;

            var tempPersonDictionary = data.GetPeople();
            Person Success = null;
            foreach (var item in tempPersonDictionary.Values)
            {
                if (username.Equals(item.UserName) && password.Equals(item.Password))
                {
                    Success = item;
                    break;
                }

            }
            if (Success != null)
                return Success;
            return null;
        }

        //voteToParty is a method used to add a vote to a party
        public static void voteToParty(string PartyName)
        {
            try
            {
                data.GetPartyList()[PartyName]++;
            }
            catch
            {
                return;
            }
        }//voteToParty()

        public static bool voteToMember(string MemberName)
        {
            int memberId = 0;
            foreach (var item in data.GetMembers().Values)
            {
                if (item.Name.Equals(MemberName))
                {
                    memberId = item.Id;
                }
            }

            try
            {
                data.GetMembers()[memberId].Location += 1;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool voteToMember(Person user, int id)
        {
            try
            {
                data.GetMembers()[id].Location += 1;
                //user.NumOfVotes += 1;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isMember(int id)
        {
            if (data.GetMembers().Keys.Contains(id))
            {
                return true;
            }

            return false;
        }

        public static Member getMemberById(int id)
        {
            try
            {
                return data.GetMembers()[id];
            }
            catch
            {
                return null;
            }
        }

        public static string getMemberNameById(int id)
        {
            try
            {
                return data.GetMembers()[id].Name;
            }
            catch
            {
                return null;
            }
        }

        //VoterFee is a function used to claim voting fee from voters
        public static int VoterFee(Person person)
        {
            person.NumOfVotes++;
            if (person.NumOfVotes == 1)                                         //if a person did not vote yet
            {
                return data.GetBankAccounts()[person.Id].withdrawl(baseFee);    //use base fee
            }
            else                                                                //if a person already voted
            {                                                                   //use bigger fee
                //Console.WriteLine(data.GetBankAccounts()[person.Id].Balance + " " + (int)(baseFee * person.NumOfVotes * 1.5));
                return data.GetBankAccounts()[person.Id].withdrawl((int)(baseFee * person.NumOfVotes*1.5));
            }
        }

        //This function assignes the boolean value of true to a isVoting field of a person.
        //USED BY PERSON
        public static bool registerVoter(Person someone)
        {
            data.GetPeople()[someone.Id].IsVoting = true;
            return true;
        }//registerVoter(Person)

        //This function assignes the boolean value of false to a isVoting field of a person. USED BY PERSON!
        public static bool revokeVoter(Person someone)
        {
            data.GetPeople()[someone.Id].IsVoting = false;
            return true;
        }//revokeVoter(Person)

        //getMessages used by the system to get the messages of an person
        public static List<Tuple<int, string, int>> getMessages(Person user)
        {
            try
            {
                return data.GetMessages()[user.Id].Inbox;
            }
            catch
            {
                return null;
            }

        }

        //getMessages used by the system to get the messages of an person
        public static List<Tuple<int, string, int>> getMessages(int id)
        {
            try
            {
                return data.GetMessages()[id].Inbox;
            }
            catch
            {
                return null;
            }

        }

        //getMessageInbox function used to get a certain message from message box using an index
        public static Tuple<int, string, int> getMessageInbox(Person person, int index)
        {
            return data.GetMessages()[person.Id].Inbox[index];
        }

        //getMessageInboxSize function return the size of a peson's message box
        public static int getMessageInboxSize(Person person)
        {
            return data.GetMessages()[person.Id].Inbox.Count;
        }

        public static void replyToMessage(Person person, int index, bool answer)
        {
            Tuple<int, string, int> message = getMessageInbox(person, index);
            if (message.Item3 > 0 && answer == true)
            {
                int senderId = message.Item1;

                data.GetMembers()[senderId].Location += 1;
                
            }
        }

        //NEEDS TO BE UPDATED AND DOCUMENTED
        public static int getBalance(Person user)
        {
            return data.GetBankAccounts()[user.Id].Balance;
        }

        public static bool addToParty(Person p,string partyName,int location)
        {
            if(data.GetPartyList().Keys.Contains(partyName))
            {
                Member m = new Member(p.Id, p.Name, p.Age, p.UserName, p.Password, p.IsVoting,p.NumOfVotes, partyName, location);
                data.GetMembers().Add(m.Id, m);
                return true;
            }
            return false;
        }

        //Deposit account of a Person
        public static bool depositToAccount(Person user, int money)
        {
            if(money >= 0)
            {
                data.GetBankAccounts()[user.Id].Balance += money;//add the amuont to the balnce of the user
                return true;//succsses
            }
            return false;
        }

        public static bool withdrawlFromAccount(Person user, int money)
        {
            if(money >= 0)
            {
                data.GetBankAccounts()[user.Id].withdrawl(money);
                return true;//succsses
            }
            return false;
        }

        public static string getSenderName(int id)
        {
            try
            {
                return data.GetPeople()[id].Name;
            }
            catch
            {
                return "Unknown person!";
            }
        }

        public static int getVotingFeeByNumOfVotes(int NumOfVotes)
        {
            return (int)(baseFee * NumOfVotes*1.5);

        }

        public static List<string> InfoForParty(string nParty)
        {
            List<string> ForParty = new List<string>();
            foreach (var x in data.GetMembers().Values)
            {
                if (x.Party == nParty)
                {
                    ForParty.Add(x.Name);
                    if (x.Location == -1)
                    {
                        ForParty.Insert(0, x.Slogan);
                    }
                }
            }

            return ForParty;
        }

        public static Memento GetMemento(int id)
        {
            try
            {
                return data.GetMementoes()[id];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public static bool getPraimeries()
        {
            return data.GetPraimerise();
        }

        public static Dictionary<int, Person> getPersonDictionary()
        {
            return data.GetPeople();
        }

        public static void createPerson(int id, String name, int age, String username, String password)
        {
            Person newPerson = new Person(id, name, age, username, password, false);
            data.GetPeople().Add(id, newPerson);
        }
    }
}
