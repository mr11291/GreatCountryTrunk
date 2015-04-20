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
        //Varaiables
        private static DataRepository data;

        //Constructor
        static DataLogic()
        {
            data = DataRepository.GetDataRepository(); //initialize data base.
        }

        //ReturnNumOfVotes is a function used ti get the amount of votes a certain party got
        public static int ReturnNumOfVotes(string PartyName)
        {
            return data.GetPartyList()[PartyName];
        }

        //this function is used for UpdateInfo form
        public static void ChangeName(Person someone, string newname)
        {
            someone.Name = newname;
        }

        //this function is used for UpdateInfo form
        public static void ChangeID(Person someone, int newID)
        {
            someone.Id = newID;
        }

        //this function is used for UpdateInfo form
        public static void ChangeAge(Person someone, int newAge)
        {
            someone.Age = newAge;
        }

        //this function is used for UpdateInfo form
        public static void ChangeUserName(Person someone, string newusername)
        {
            someone.UserName = newusername;
        }

        //this function is used for UpdateInfo form
        public static void ChangePassword(Person someone, string newpassword)
        {
            someone.Password = newpassword;
        }

        public static void firstSetPartyLeader()
        {
            int highestBalance = 0;
            Member memberBalance = null;
            foreach (var party in data.GetPartyList().Keys)
            {
                foreach (var id in data.GetMembers().Keys)
                {
                    if (data.GetMembers()[id].Party.Equals(party))
                    {
                        int balance = data.GetBankAccounts()[id].Balance;
                        if (balance > highestBalance)
                        {
                            highestBalance = balance;
                            memberBalance = (data.GetMembers()[id]);
                        }
                    }
                }
                if (memberBalance != null)
                {
                    memberBalance.Location = -1;
                    memberBalance = null;
                }
            }
        }
    }
}
