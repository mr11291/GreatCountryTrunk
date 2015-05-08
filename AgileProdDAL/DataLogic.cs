using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;
using System.Collections.ObjectModel;

namespace AgileProdDAL
{
    public static class DataLogic
    {
        private static DataRepository data;

        //System Functions
        /*
         * DataLogic is a defualt constructor.
         */
        static DataLogic()
        {
            data = DataRepository.GetDataRepository(); //initialize data base.
        }//DataLogic()


        public static bool addMember(int id, string name, int age, string username, string password, bool isVoting,int numofvote, string group, int location, int balance)   //admin
        {
            if (!data.GetMembers().Any(current => current.Key == id))
            {
                Bank account = new Bank(balance, id, name);
                Member m = new Member(id, name, age, username, password, isVoting,numofvote, group, location);
                data.GetMembers().Add(m.Id, m);
                data.GetBankAccounts().Add(id, account);
                return true;
            }
            return false;
        }


        //Admin Functions 
        /*
         * addPerson creates and adds a new person to the people dictionary
         */
        public static bool addPerson(int id, string name, int age, string username, string password, int balance, bool isVoting, int numOfVote)   //admin
        {
            if (!data.GetPeople().Any(current => current.Key == id))                               //checks if ID doesn't exist in the system
            {
                Message newMessageBox = null;                                  //creates a new message box
                Bank newAccount = new Bank(balance, id, name);                             //creates a new bank account
                Person newPerson = new Person(id, name, age, username, password, isVoting,numOfVote);  //creates a new person
                data.GetPeople().Add(newPerson.Id, newPerson);                                  //adds person to the dictionary
                data.GetBankAccounts().Add(id, newAccount);                                     //adds bank to the diciotnary
                data.GetMessages().Add(id, newMessageBox);                                      //adds message box to the dictionary
                return true;
            }
            return false;
        }//addPerson(int, string, int, string, string, int, bool)

        public static bool addPartyMemeber(int id, string name, int age, string username, string password, int balance, bool isVoting,int numofvote, string party, int location)  //admin+member
        {
            if (!data.GetMembers().Any(current => current.Key == id))                               //checks if ID doesn't exist in the system
            {
                Message newMessageBox = null;                                                     //creates a new message box
                Bank newAccount = new Bank(balance, id, name);                                               //creates a new bank account
                Member newMember = new Member(id, name, age, username, password, isVoting,numofvote, party, location); //creates a new person
                data.GetMembers().Add(newMember.Id, newMember);                                                   //adds person to the dictionary
                data.GetBankAccounts().Add(id, newAccount);                                                       //adds bank to the diciotnary
                data.GetMessages().Add(id, newMessageBox);                                                        //adds message box to the dictionary
                return true;
            }
            return false;
        }

        public static int ReturnNumOfVotes(string PartyName)
        {
            return data.GetPartyList()[PartyName];
        }
        /*
         * DeletePerson deletes a person using a given ID
         */
        public static bool DeletePerson(int id)  //admin
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
        }//DeletePerson(int)



        //those functions are used for UpdateInfo form
        public static void ChangeName(Person someone, string newname)
        {
            someone.Name = newname;
        }

        public static void ChangeID(Person someone, int newID)
        {
            someone.Id = newID;
        }

        public static void ChangeAge(Person someone, int newAge)
        {
            someone.Age = newAge;
        }

        public static void ChangeUserName(Person someone, string newusername)
        {
            someone.UserName = newusername;
        }

        public static void ChangePassword(Person someone, string newpassword)
        {
            someone.Password = newpassword;
        }

        //Party Member Functions
        public static void AddSlogan(Member partyMember, string slogan)
        {
            partyMember.Slogan = slogan;
        }

        public static int getBalance(Person user)
        {
            return data.GetBankAccounts()[user.Id].Balance;
        }

        // Delete party
        public static bool DelParty(string Pname)
        {
            try
            {
                Dictionary<int, Member> TempMem = new Dictionary<int, Member>();
                data.GetPartyList().Remove(Pname);
                foreach (var x in data.GetMembers())
                {
                    if (x.Value.Party != Pname.Replace(" ", string.Empty))
                    {
                        TempMem.Add(x.Key, x.Value);
                    }
                }

                data.setMember(TempMem);

                Console.WriteLine(data.GetMembers().Count());
                Console.WriteLine(data.GetPartyList().Count());
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Withdrawal from person bank account
        public static int WithdrawalPeronAcc(int id, int amount)
        {
            try
            {
                return data.GetBankAccounts()[id].withdrawl(amount);
            }
            catch
            {
                return -1; 
            }
            
        }
    }
}
