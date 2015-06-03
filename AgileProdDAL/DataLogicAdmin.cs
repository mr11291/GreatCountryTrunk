using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;

namespace AgileProdDAL
{
    public static class DataLogicAdmin
    {
        //Varaiables
        private static DataRepository data;
        public static int Process;

        //Constructor
        static DataLogicAdmin()
        {
            data = DataRepository.GetDataRepository();
        }

        //AllPersons() returns a READ-ONLY dictionarty of persons
        public static ReadOnlyDictionary<int, Person> AllPersons()
        {
            return new ReadOnlyDictionary<int, Person>(data.GetPeople());
        }

        //AllMembers() returns a READ-ONLY dictionarty of party members
        public static ReadOnlyDictionary<int, Member> AllMembers()
        {
            return new ReadOnlyDictionary<int, Member>(data.GetMembers());
        }

        //AllCommittee() returns a READ-ONLY dictionarty of committee members
        public static ReadOnlyDictionary<int, Head> AllCommittee()
        {
            return new ReadOnlyDictionary<int, Head>(data.GetCommittee());
        }

        //AllParties() returns a READ-ONLY dictionarty of party list
        public static ReadOnlyDictionary<string, int> AllParties()
        {
            return new ReadOnlyDictionary<string, int>(data.GetPartyList());
        }

        //AllAccounts() returns a READ-ONLY dictionarty of bank accounts
        public static ReadOnlyDictionary<int, Bank> AllAccounts()
        {
            return new ReadOnlyDictionary<int, Bank>(data.GetBankAccounts());
        }

        //AllMessages() returns a READ-ONLY dictionarty of messages
        public static ReadOnlyDictionary<int, Message> AllMessages()
        {
            return new ReadOnlyDictionary<int, Message>(data.GetMessages());
        }

        //AllAdmins() returns a READ-ONLY dictionarty of admins
        public static ReadOnlyDictionary<int, Admin> AllAdmins()
        {
            return new ReadOnlyDictionary<int, Admin>(data.GetAdmin());
        }

        public static ReadOnlyDictionary<int, LastEntry> AllEntries()
        {
            return new ReadOnlyDictionary<int,LastEntry>(data.GetLastEntery());
        }

        public static ReadOnlyDictionary<int, Memento> AllMementoes()
        {
            return new ReadOnlyDictionary<int, Memento>(data.GetMementoes());
        }

        //PraimeriesStatus returns the boolean status of the praimeries
        public static bool PraimeriesStatus()
        {
            return data.GetPraimerise();
        }

        //LoginAdmin is used to log in to the system as an admin
        public static Admin LoginAdmin(string username, string password)
        {
            //var temp = data.GetAdmin().FirstOrDefault((currAdmin) => (currAdmin.Key == username.Trim() && currAdmin.Value == password.Replace(" ", ""))).Value;
            var tempAdminDictionary = data.GetAdmin();                                  //get temporary admin dictionary
            Admin Success = null;                                                       //create an empty instance of admin
            foreach (var item in tempAdminDictionary.Values)                            //iterate trough admin dictionary values
            {
                if (username.Equals(item.UserName) && password.Equals(item.Password))   //if given username/password match the existing ones
                {
                    Success = item;                                                     //initialize admin instance
                    break;                                                              //break loop
                }
            }
            return Success;                                                             //return admin instance
        }

        //revokeVoter function assignes the boolean value of false to a isVoting field of a person/member/committee member. USED ONLY BY ADMIN
        public static bool revokeVoter(int id)
        {
            data.GetPeople()[id].IsVoting = false;
            return true;
        }

        //registerVoter function assignes the boolean value of true to a isVoting field of a person/member/committee member. USED ONLY BY ADMIN
        public static bool registerVoter(int id)
        {
            data.GetPeople()[id].IsVoting = true;
            return true;
        }

        //getMessages used by the system to get the messages of an admin
        public static List<Tuple<int, string, int>> getMessages(Admin user)
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

        public static bool AddPerosnToParty(int id , string partyName,int location)
        {
            try
            {
                if (data.GetPartyList().Keys.Contains(partyName))
                {
                    string newMemberName = data.GetPeople()[id].Name;
                    int newMemberAge = data.GetPeople()[id].Age;
                    string newMemberUserName = data.GetPeople()[id].UserName;
                    string newMemberPassword = data.GetPeople()[id].Password;
                    bool newMemberVoting = data.GetPeople()[id].IsVoting;
                    int newmembernumvoting = data.GetPeople()[id].NumOfVotes;
                    Member m = new Member(id, newMemberName, newMemberAge, newMemberUserName, newMemberPassword, newMemberVoting,newmembernumvoting, partyName, location);
                    data.GetMembers().Add(id, m);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static void ChangePraimeryStatus()
        {
            if (data.GetPraimerise() == true)
            {
                data.setPraimeries(false);
                foreach (var person in data.GetPeople().Values)
                {
                    person.NumOfVotes = 0;
                }
            }
            else
            {
                data.setPraimeries(true);
            }
        }

        public static bool addMember(int id, string name, int age, string username, string password, bool isVoting,int numofvote, string group, int location, int balance)
        {
            if (!data.GetMembers().Any(current => current.Key == id))
            {
                Bank account = new Bank(balance, id, name);
                Member m = new Member(id, name, age, username, password, isVoting,numofvote, group, location);

                data.GetMembers().Add(m.Id, m);
                if (data.GetPeople()[id].memento.PartyName == null)
                {
                    data.GetBankAccounts().Add(id, account);
                    DataLogicMessage.createEmptyMessageBox(id);
                }
                return true;
            }
            return false;
        }

        public static bool addPerson(int id, string name, int age, string username, string password, int balance, bool isVoting, int numOfVote)
        {
            if (!data.GetPeople().Any(current => current.Key == id))                               //checks if ID doesn't exist in the system
            {
                //Message newMessageBox = new Message(id);                                   //creates a new message box
                Bank newAccount = new Bank(balance, id, name);                             //creates a new bank account
                Person newPerson = new Person(id, name, age, username, password, isVoting,numOfVote);  //creates a new person
                data.GetPeople().Add(newPerson.Id, newPerson);                                  //adds person to the dictionary
                data.GetBankAccounts().Add(id, newAccount);                                     //adds bank to the diciotnary
                DataLogicMessage.createEmptyMessageBox(id);
                return true;
            }
            return false;
        }//addPerson(int, string, int, string, string, int, bool)

        public static bool addPartyMemeber(int id, string name, int age, string username, string password, int balance, bool isVoting,int numofvote, string party, int location)  //admin+member
        {
            if (!data.GetMembers().Any(current => current.Key == id))                               //checks if ID doesn't exist in the system
            {
                //Message newMessageBox = new Message();                                                     //creates a new message box
                Bank newAccount = new Bank(balance, id, name);                                               //creates a new bank account
                Member newMember = new Member(id, name, age, username, password, isVoting,numofvote, party, location); //creates a new person
                data.GetMembers().Add(newMember.Id, newMember);                                              //adds person to the dictionary
                data.GetBankAccounts().Add(id, newAccount);                                                  //adds bank to the diciotnary
                DataLogicMessage.createEmptyMessageBox(id);
                return true;
            }
            return false;
        }

        public static bool DeletePerson(int id)
        {
            try
            {
                data.GetPeople().Remove(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int getMessageCount(Admin user)
        {
            try
            {
                int count = data.GetMessages()[user.Id].Count;
                return count;
            }
            catch (KeyNotFoundException)
            {
                return -1;
            }
        }

        private static bool getRandomBool()
        {
            Random rand = new Random();

            if (rand.Next(100) % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool runPraimeries(BackgroundWorker worker)
        {
            Random rand;
            Random judge = new Random();
            bool vote = true;
            int i = 0;
            Dictionary<String, int> partydict;

            //set isVoting value
            foreach (var person in data.GetPeople())    //iterate trough all people
            {
                if (person.Value.IsVoting == false)     //if a person is not a voter yet
                {
                    if (judge.Next(100) < 90)           //randomly select if a person want's to register as a voter with 80% propability for "true" value
                    {
                        person.Value.IsVoting = true;
                    } 
                }
            }

            //vote for a party member 
            foreach (var person in data.GetPeople())
            { 
                i++;
                worker.ReportProgress((int)((double)100 / data.GetPeople().Count() * i));

                vote = true;
                rand = new Random();

                if (person.Value.IsVoting == true)                                               //if a person is a voter
                {
                    
                    partydict = data.GetPartyList().OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);

                    while (vote == true)                                                         //while he dicides to vote
                    {                                                                            //if a person has enogh money to pay for a vote
                        if (DataLogicPerson.getVotingFeeByNumOfVotes(person.Value.NumOfVotes) <= DataLogicBank.getBankDictionary()[person.Key].Balance)
                        {
                            foreach (var party in partydict)                                     //iterate trough party list
                            {
                                if (vote == true)
                                {
                                    if (getRandomBool())                                         //if a person decides to vote to this party
                                    {
                                        foreach (var member in data.GetMembers())                //find a member from this party
                                        {
                                            if (member.Value.Location != -1)
                                            {
                                                if (member.Value.Party.Equals(party.Key))        //if a member was found 
                                                {
                                                    if (getRandomBool())                         //if person decides to vote to this member
                                                    {
                                                        DataLogicPerson.voteToMember(person.Value, member.Value.Id);    //vote to selected member
                                                        person.Value.NumOfVotes++;                                      //increase number of votes
                                                        DataLogicBank.getBankDictionary()[person.Key].withdrawl(DataLogicPerson.getVotingFeeByNumOfVotes(person.Value.NumOfVotes)); //withdrawl from persons account

                                                        if (getRandomBool() == false)            //randomly select if a person want's to vote and assigns the coresponding value
                                                        {
                                                            vote = false;
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            if (DataLogicPerson.getVotingFeeByNumOfVotes(person.Value.NumOfVotes) > DataLogicBank.getBankDictionary()[person.Key].Balance)
                                                            {
                                                                vote = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            vote = false;
                        }
                    }
                }
                Process++;
            }
            return true;
        }

        public static bool runElections(BackgroundWorker worker)
        {
            Random rand;
            Random judge = new Random();
            bool vote = true;
            int i = 0;
            Dictionary<String, int> partydict;

            //set isVoting value
            foreach (var person in data.GetPeople())    //iterate trough all people
            {
                if (person.Value.IsVoting == false)     //if a person is not a voter yet
                {
                    if (judge.Next(100) < 90)           //randomly select if a person want's to register as a voter with 80% propability for "true" value
                    {
                        person.Value.IsVoting = true;
                    }
                }
            }

            //vote for a party member 
            foreach (var person in data.GetPeople())
            { 
                i++;
                worker.ReportProgress((int)((double)100 / data.GetPeople().Count() * i));

                vote = true;
                rand = new Random();

                if (person.Value.IsVoting == true)                                               //if a person is a voter
                {
                    partydict = data.GetPartyList().OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);

                    while (vote == true)                                                         //while he dicides to vote
                    {                                                                            //if a person has enogh money to pay for a vote
                        if (DataLogicPerson.getVotingFeeByNumOfVotes(person.Value.NumOfVotes) <= DataLogicBank.getBankDictionary()[person.Key].Balance)
                        {
                            if (DataLogicMember.GetMember().Keys.Contains(person.Key))         //if this person is a party member
                            {
                                DataLogicPerson.voteToParty(DataLogicMember.GetMember()[person.Key].Party);
                                person.Value.NumOfVotes++;
                                DataLogicBank.getBankDictionary()[person.Key].withdrawl(DataLogicPerson.getVotingFeeByNumOfVotes(person.Value.NumOfVotes));

                                if (getRandomBool() == false)            //randomly select if a person want's to vote and assigns the coresponding value
                                {
                                    vote = false;
                                    break;
                                }
                                else
                                {
                                    if (DataLogicPerson.getVotingFeeByNumOfVotes(person.Value.NumOfVotes) > DataLogicBank.getBankDictionary()[person.Key].Balance)
                                    {
                                        vote = false;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                foreach (var party in partydict)                                     //iterate trough party list
                                {
                                    if (vote == true)
                                    {
                                        if (getRandomBool())                                         //if a person decides to vote to this party
                                        {

                                            DataLogicPerson.voteToParty(party.Key);
                                            person.Value.NumOfVotes++;                                      //increase number of votes
                                            DataLogicBank.getBankDictionary()[person.Key].withdrawl(DataLogicPerson.getVotingFeeByNumOfVotes(person.Value.NumOfVotes)); //withdrawl from persons account

                                            if (getRandomBool() == false)            //randomly select if a person want's to vote and assigns the coresponding value
                                            {
                                                vote = false;
                                                break;
                                            }
                                            else
                                            {
                                                if (DataLogicPerson.getVotingFeeByNumOfVotes(person.Value.NumOfVotes) > DataLogicBank.getBankDictionary()[person.Key].Balance)
                                                {
                                                    vote = false;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            vote = false;
                        }
                    }
                }
                Process++;
            }
            return true;
        }
    }
}
