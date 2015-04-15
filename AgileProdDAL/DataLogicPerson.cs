using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;

namespace AgileProdDAL
{
    public static class DataLogicPerson
    {
        private static DataRepository data;
        static DataLogicPerson()
        {
            data = DataRepository.GetDataRepository();
        }

        public static Person LoginPerson(string username, string password)   //person
        {
            //Person p = data.GetPeople().FirstOrDefault((currPer) => (currPer.Value.userName == username.Replace(" ", "") && currPer.Value.password == password.Replace(" ", ""))).Value;

            var tempPersonDictionary = data.GetPeople();
            Person Success = null;
            foreach (var item in tempPersonDictionary.Values)
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
      * This function assignes the boolean value of true to a isVoting field of a person.
      * USED BY PERSON
      */
        public static bool registerVoter(Person someone)
        {
            data.GetPeople()[someone.Id].IsVoting = true;
            return true;
        }//registerVoter(Person)

        /*
 * This function assignes the boolean value of false to a isVoting field of a person.
 * USED BY PERSON
 */
        public static bool revokeVoter(Person someone)
        {
            data.GetPeople()[someone.Id].IsVoting = false;
            return true;
        }//revokeVoter(Person)


    }
}
