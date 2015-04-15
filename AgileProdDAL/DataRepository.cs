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

        /*
         * Class DataReposatory uses local database to create dynamic dictionary based, usable database.
         * this class DO NOT change the local data up until the user finishes (close) using the program.
         */
        private static Dictionary<int, Person> people;       
        private static Dictionary<int, Member> members;
        private static Dictionary<string, int> partyList;
        private static Dictionary<int, Message> messages;
        private static Dictionary<int, Bank> bankAccounts;
        private static bool praimerise;
        private static Dictionary<int, Head> committee;
        private static Dictionary<string, string> admin;
        private static DataRepository instance;

        public  DataRepository(Dictionary<int, Person> peopleD, Dictionary<int, Member> membersD, Dictionary<string, int> partyListD, bool praimeriseD, Dictionary<int, Head> headD, Dictionary<string, string> adminD, Dictionary<int, Bank> bankAccountsD, Dictionary<int, Message> messagesD)
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

        public Dictionary<int, Person> GetPeople()
        {
            return people;
        }

        //public  void setPeople(Dictionary<int,Person> peopleD)
        //{
        //    people = peopleD;
        //}


        public Dictionary<int, Member> GetMembers()
        {
            return members;
        }

        //public void setMember(Dictionary<int, Member> memberD)
        //{
        //    members = memberD;
        //}

        public Dictionary<int, Head> GetCommittee()
        {
            return committee;
        }

        //public void setHead(Dictionary<int, Head> headD)
        //{
        //    head = headD;
        //}

        public Dictionary<string, int> GetPartyList()
        {
            return partyList;
        }

        //public void setPartyList(Dictionary<string, int> PartyListD)
        //{
        //    partyList=PartyListD;
        //}

        public Dictionary<string, string> GetAdmin()
        {
            return admin;
        }

        //public void setAdmin(Dictionary<string, string> adminD)
        //{
        //    admin = adminD;
        //}

        public bool GetPraimerise()
        {
            return praimerise;
        }

        //public void setPraimeries(bool praim)
        //{
        //    praimerise = praim;
        //}

        public Dictionary<int, Message> GetMessages()
        {
            return messages;
        }

        public Dictionary<int, Bank> GetBankAccounts()
        {
            return bankAccounts;
        }

        public static DataRepository GetDataRepository() //bad singleton
        {
            if (instance == null)
                instance = LoadDataBase.LoadToDataRepository();
            return instance;
        }
    }
}
