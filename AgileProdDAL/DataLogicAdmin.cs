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
        private static DataRepository data;
        static DataLogicAdmin()
        {
            data = DataRepository.GetDataRepository();
        }

        /*
 * AllPersons() return a READ-ONLY dictionarty of persons
 */
        public static ReadOnlyDictionary<int, Person> AllPersons()
        {
            return new ReadOnlyDictionary<int, Person>(data.GetPeople());
        }//AllPersons()

        /*
     * AllMembers() return a READ-ONLY dictionarty of party members
     */
        public static ReadOnlyDictionary<int, Member> AllMembers()
        {
            return new ReadOnlyDictionary<int, Member>(data.GetMembers());
        }//AllMembers()

        /*
         * AllCommittee() return a READ-ONLY dictionarty of committee members
         */
        public static ReadOnlyDictionary<int, Head> AllCommittee()
        {
            return new ReadOnlyDictionary<int, Head>(data.GetCommittee());
        }//AllCommittee()

        /*
         * AllParties() return a READ-ONLY dictionarty
         */
        public static ReadOnlyDictionary<string, int> AllParties()
        {
            return new ReadOnlyDictionary<string, int>(data.GetPartyList());
        }//AllParties()

        public static ReadOnlyDictionary<int, Message> AllMessages()
        {
            return new ReadOnlyDictionary<int, Message>(data.GetMessages());
        }

        public static ReadOnlyDictionary<int, Admin> AllAdmins()
        {
            return new ReadOnlyDictionary<int, Admin>(data.GetAdmin());
        }

        public static bool PraimeriesStatus()
        {
            return data.GetPraimerise();
        }//PraimeriesStatus()

        public static Admin LoginAdmin(string username, string password)
        {
            //var temp = data.GetAdmin().FirstOrDefault((currAdmin) => (currAdmin.Key == username.Trim() && currAdmin.Value == password.Replace(" ", ""))).Value;

            //if (temp != null)
            //    return true;
            //return false;
            var tempAdminDictionary = data.GetAdmin();
            Admin Success = null;
            foreach (var item in tempAdminDictionary.Values)
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

        /*
         * This function assignes the boolean value of false to a isVoting field of a person/member/committee member.
         * USED BY ADMIN
         */
        public static bool revokeVoter(int id)
        {
            data.GetPeople()[id].IsVoting = false;
            return true;
        }//revokeVoter(int)

        /*
         * This function assignes the boolean value of true to a isVoting field of a person/member/committee member.
         * USED BY ADMIN
         */
        public static bool registerVoter(int id)
        {
            data.GetPeople()[id].IsVoting = true;
            return true;
        }//registerVoter(int)

        public static List<Tuple<int, string, int>> getMessages(Admin user)
        {
            return data.GetMessages()[user.Id].Inbox;
        }
    }
}
