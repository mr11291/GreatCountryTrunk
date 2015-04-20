using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            return data.GetMessages()[user.Id].Inbox;
        }


        //ON GOING DEVELOPMENT!:

        public static bool AddPerosnToParty(int id , string partyName,int location)
        {
            try
            {
                if (data.GetPartyList().Keys.Contains(partyName))
                {
                    string newMemberName = data.GetMembers()[id].Name;
                    int newMemberAge = data.GetMembers()[id].Age;
                    string newMemberUserName = data.GetMembers()[id].UserName;
                    string newMemberPassword = data.GetMembers()[id].Password;
                    bool newMemberVoting = data.GetMembers()[id].IsVoting;
                    Member m = new Member(id, newMemberName, newMemberAge, newMemberUserName, newMemberPassword, newMemberVoting, partyName, location);
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

        public static void SetPraimeryStatus()
        {
            data.setPraimeries(true);
        }


        //NEEDS TO BE UPDATED TO USE MESSAGES
        public static bool addMember(int id, string name, int age, string username, string password, bool isVoting, string group, int location, int balance)
        {
            if (!data.GetMembers().Any(current => current.Key == id))
            {
                Bank account = new Bank(balance, id, name);
                Member m = new Member(id, name, age, username, password, isVoting, group, location);
                data.GetMembers().Add(m.Id, m);
                data.GetBankAccounts().Add(id, account);
                return true;
            }
            return false;
        }

        //NEEDS TO BE UPDATED TO USE MESSAGES
        public static bool addPerson(int id, string name, int age, string username, string password, int balance, bool isVoting)
        {
            if (!data.GetPeople().Any(current => current.Key == id))                               //checks if ID doesn't exist in the system
            {
                //Message newMessageBox = new Message(id);                                   //creates a new message box
                Bank newAccount = new Bank(balance, id, name);                             //creates a new bank account
                Person newPerson = new Person(id, name, age, username, password, isVoting);  //creates a new person
                data.GetPeople().Add(newPerson.Id, newPerson);                                  //adds person to the dictionary
                data.GetBankAccounts().Add(id, newAccount);                                     //adds bank to the diciotnary
                data.GetMessages().Add(id, null);                                      //adds message box to the dictionary
                return true;
            }
            return false;
        }//addPerson(int, string, int, string, string, int, bool)

        //NEEDS TO BE UPDATED TO USE MESSAGES
        public static bool addPartyMemeber(int id, string name, int age, string username, string password, int balance, bool isVoting, string party, int location)  //admin+member
        {
            if (!data.GetMembers().Any(current => current.Key == id))                               //checks if ID doesn't exist in the system
            {
                //Message newMessageBox = new Message();                                                     //creates a new message box
                Bank newAccount = new Bank(balance, id, name);                                               //creates a new bank account
                Member newMember = new Member(id, name, age, username, password, isVoting, party, location); //creates a new person
                data.GetMembers().Add(newMember.Id, newMember);                                                   //adds person to the dictionary
                data.GetBankAccounts().Add(id, newAccount);                                                       //adds bank to the diciotnary
                data.GetMessages().Add(id, null);                                                        //adds message box to the dictionary
                return true;
            }
            return false;
        }

        //NEEDS TO BE UPDATE AND DOCUMENTED
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
            return data.GetMessages()[user.Id].Count;
        }
    }
}
