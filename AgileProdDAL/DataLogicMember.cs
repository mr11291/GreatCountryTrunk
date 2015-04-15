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
        private static DataRepository data;
        static DataLogicMember()
        {
            data = DataRepository.GetDataRepository();
        }


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
    }
}
