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

        //Constructor call
        static DataLogicMember()
        {
            data = DataRepository.GetDataRepository();
        }

        //LoginMember is a function used to log in to the system as a party member
        public static Member LoginMember(string username, string password)  //member
        {
            //Member m = data.Members.FirstOrDefault((currMem) => (currMem.Value.UserName == username.Replace(" ", "") && currMem.Value.Password == password.Replace(" ", ""))).Value;
            var tempMemberDictionary = data.GetMembers();
            Member Success = null;
            foreach (var item in tempMemberDictionary.Values)
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

        //sendMessageToPerson is a function that is used to send messages from party member to person
        public static bool sendMassageToPerson(Member sender, int id, string message, int bribeAmount = 0)
        {
            data.GetMessages()[id].addMessage(sender.Id, message, bribeAmount);
            return true;
        }
    }
}
