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


        public static bool addMember(int id, string name, int age, string username, string password, bool isVoting, string group, int location, int balance)   //admin
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


        //Admin Functions 
        /*
         * addPerson creates and adds a new person to the people dictionary
         */
        public static bool addPerson(int id,string name,int age,string username,string password, int balance, bool isVoting)   //admin
        {
            if (!data.GetPeople().Any(current => current.Key == id))                               //checks if ID doesn't exist in the system
            {
                Message newMessageBox = new Message(id);                                   //creates a new message box
                Bank newAccount = new Bank(balance, id, name);                             //creates a new bank account
                Person newPerson=new Person(id, name, age, username, password, isVoting);  //creates a new person
                data.GetPeople().Add(newPerson.Id, newPerson);                                  //adds person to the dictionary
                data.GetBankAccounts().Add(id, newAccount);                                     //adds bank to the diciotnary
                data.GetMessages().Add(id, newMessageBox);                                      //adds message box to the dictionary
                return true;
            }
            return false; 
        }//addPerson(int, string, int, string, string, int, bool)

        public static bool addPartyMemeber(int id, string name, int age, string username, string password, int balance, bool isVoting, string party, int location)  //admin+member
        {
            if (!data.GetMembers().Any(current => current.Key == id))                               //checks if ID doesn't exist in the system
            {
                Message newMessageBox = new Message(id);                                                     //creates a new message box
                Bank newAccount = new Bank(balance, id, name);                                               //creates a new bank account
                Member newMember = new Member(id, name, age, username, password, isVoting, party, location); //creates a new person
                data.GetMembers().Add(newMember.Id, newMember);                                                   //adds person to the dictionary
                data.GetBankAccounts().Add(id, newAccount);                                                       //adds bank to the diciotnary
                data.GetMessages().Add(id, newMessageBox);                                                        //adds message box to the dictionary
                return true;
            }
            return false; 
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

        //Person Functions
        /*
         * voteToParty is a method used to add a vote to a certine party
         */
        public static void voteToParty(string PartyName)  
        {
            data.GetPartyList()[PartyName]++;
        }//voteToParty()

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


    } 
}
