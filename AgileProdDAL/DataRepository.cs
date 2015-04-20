using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;

namespace AgileProdDAL
{
    internal class DataRepository
    {

        private static Dictionary<int, Person> people;      //<id, person instance>   
        private static Dictionary<int, Member> members;     //<id, party member instance> 
        private static Dictionary<int, Message> messages;   //<id, message inbox instance> 
        private static Dictionary<int, Bank> bankAccounts;  //<id, bank account instnace> 
        private static Dictionary<int, Head> committee;     //<id, committee member instance> 
        private static Dictionary<int, Admin> admin;        //<id, admin instance>
        private static Dictionary<string, int> partyList;   //<party name, amount of votes recived
        private static bool praimerise;                     //represents an on going praimeries
        private static DataRepository instance;             //an instance of data reposetory

        //constructor
        public DataRepository(Dictionary<int, Person> peopleD, Dictionary<int, Member> membersD,
                               Dictionary<string, int> partyListD, bool praimeriseD, Dictionary<int, Head> headD,
                               Dictionary<int, Admin> adminD, Dictionary<int, Bank> bankAccountsD,
                               Dictionary<int, Message> messagesD)
        {
            people = peopleD;
            members = membersD;
            committee = headD;
            partyList = partyListD;
            bankAccounts = bankAccountsD;
            praimerise = praimeriseD;
            messages = messagesD;
            admin = adminD;
            
        }

        /*
         * Those function use local data base to create dynamic dictionary based database.
         * the access to those dictionaries is global and almost every outer function uses them.
         */

        //Setters Getters
        public Dictionary<int, Person> GetPeople()
        {
            return people;
        }
        public Dictionary<int, Member> GetMembers()
        {
            return members;
        }
        public Dictionary<int, Head> GetCommittee()
        {
            return committee;
        }
        public Dictionary<int, Admin> GetAdmin()
        {
            return admin;
        }
        public Dictionary<int, Message> GetMessages()
        {
            return messages;
        }
        public Dictionary<int, Bank> GetBankAccounts()
        {
            return bankAccounts;
        }
        public Dictionary<string, int> GetPartyList()
        {
            return partyList;
        }
        public bool GetPraimerise()
        {
            return praimerise;
        }
        public static DataRepository GetDataRepository()
        {
            if (instance == null)
                instance = LoadDataBase.LoadToDataRepository();
            return instance;
        }//Singleton instance
        public void setMember(Dictionary<int, Member> memberD)
        {
            members = memberD;
        }
        public void setPraimeries(bool praim)
        {
            praimerise = praim;

        }
        
        /*
        public void setPeople(Dictionary<int, Person> peopleD)
        {
            people = peopleD;
        }

<<<<<<< HEAD
        public void setHead(Dictionary<int, Head> headD)
        {
            head = headD;
=======


        public void setPartyList(Dictionary<string, int> PartyListD)
        {
            partyList = PartyListD;
        }

        public void setAdmin(Dictionary<string, string> adminD)
        {
            admin = adminD;
        }

        public void setPraimeries(bool praim)
        {
            praimerise = praim;
        }
        */
        
    }
}
