using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;

namespace AgileProdDAL
{
    public static class DataLogicMember
    {
        //Varaiables
        private static DataRepository data;

        //Constructor
        static DataLogicMember()
        {
            data = DataRepository.GetDataRepository();
        }

        //LoginMember is a function used to log in to the system as a party member
        public static Member LoginMember(string username, string password)  //member
        {
            //Member m = data.Members.FirstOrDefault((currMem) => (currMem.Value.UserName == username.Replace(" ", "") && currMem.Value.Password == password.Replace(" ", ""))).Value;
            var tempMemberDictionary = data.GetMembers();                               //get temporary party member dictionary
            Member Success = null;                                                      //initialize a new empty Member class instance
            foreach (var item in tempMemberDictionary.Values)                           //loop trough the dictionary
            {
                if (username.Equals(item.UserName) && password.Equals(item.Password))   //if the given username/password and the existing username/passwords match 
                {
                    Success = item;                                                     //initialize member using found member
                    break;                                                              //break loop
                }
            }         
            return Success;                                                             //return member instance                        
        }

        //sendMessageToPerson is a function that is used to send messages from party member to person
        public static bool sendMassageToPerson(Member sender, int id, string message, int bribeAmount = 0)
        {
            data.GetMessages()[id].addMessage(sender.Id, message, bribeAmount);
            return true;
        }

        //ON GOING DEVELOPMENT!:

        //NEEDS DOCUMENTATION
        public static void AddSlogan(Member partyMember, string slogan)
        {
            partyMember.Slogan = slogan;
        }
        public static Dictionary<int,Member> GetMember()
        {
            return data.GetMembers();
        }

        //selectPartyLeader selects a party leader using an algorithem to find the richest person in each party
        public static void selectPartyLeader()
        {
            //Tuple<int, int> temp = new Tuple<int, int> (Convert.ToInt32(data.GetMembers().Keys), Convert.ToInt32(data.GetPartyList().Keys));
            int RichestMemberId = 0;
            int balance = 0;
            foreach (var party in data.GetPartyList().Keys)                 //loop trough all of the parties
            {
                foreach (var id in data.GetMembers().Keys)                  //loop trough all of the party members
                {
                    if (data.GetMembers()[id].Equals(party))                //this if loop will make sure we are only looking at people from the same party
                    {
                        if (data.GetBankAccounts()[id].Balance > balance)   //we will get into this if only if we found someone richer
                        {
                            balance = data.GetBankAccounts()[id].Balance;   //set new balance to compare with
                            RichestMemberId = id;                           //remember richest party member
                        }
                    }
                }
                data.GetMembers()[RichestMemberId].Location = -1;           //set richest party member to be the party leader of his party
            }  
        }
    }
}
