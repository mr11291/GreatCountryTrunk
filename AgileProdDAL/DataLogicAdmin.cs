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
        public static ReadOnlyDictionary<int, Person> AllPersons()  //admin
        {
            return new ReadOnlyDictionary<int, Person>(data.GetPeople());
        }//AllPersons()


        /*
     * AllMembers() return a READ-ONLY dictionarty of party members
     */
        public static ReadOnlyDictionary<int, Member> AllMembers()     //admin
        {
            return new ReadOnlyDictionary<int, Member>(data.GetMembers());
        }//AllMembers()

        /*
         * AllCommittee() return a READ-ONLY dictionarty of committee members
         */
        public static ReadOnlyDictionary<int, Head> AllCommittee()     //admin
        {
            return new ReadOnlyDictionary<int, Head>(data.GetCommittee());
        }//AllCommittee()

        /*
         * AllParties() return a READ-ONLY dictionarty
         */
        public static ReadOnlyDictionary<string, int> AllParties()   //admin
        {
            return new ReadOnlyDictionary<string, int>(data.GetPartyList());
        }//AllParties()


        public static bool PraimeriesStatus() //   admin
        {
            return data.GetPraimerise();
        }//PraimeriesStatus()


        public static bool LoginAdmin(string username, string password)     //admin
        {
            var temp = data.GetAdmin().FirstOrDefault((currAdmin) => (currAdmin.Key == username.Trim() && currAdmin.Value == password.Replace(" ", ""))).Value;

            if (temp != null)
                return true;
            return false;
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
        public static bool registerVoter(int id)   //person
        {
            data.GetPeople()[id].IsVoting = true;
            return true;
        }//registerVoter(int)



    }
}
