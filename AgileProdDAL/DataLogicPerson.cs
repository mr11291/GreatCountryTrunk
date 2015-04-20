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
        private static int baseFee = 1001;
        
        public static int BaseFee
        {
          get { return DataLogicPerson.baseFee; }
          set { DataLogicPerson.baseFee = value; }
        }

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
        //Person Functions
        /*
         * voteToParty is a method used to add a vote to a certine party
         */
        public static void voteToParty(string PartyName)
        {
            data.GetPartyList()[PartyName]++;
        }//voteToParty()

        public static int VoterFee(Person person)
        {
            if (person.NumOfVotes == 0)
            {
                return data.GetBankAccounts()[person.Id].withdrawl(baseFee);
            }
            else
            {
                Console.WriteLine(data.GetBankAccounts()[person.Id].Balance + " " + (int)(baseFee * person.NumOfVotes * 1.5));
                return data.GetBankAccounts()[person.Id].withdrawl((int)(baseFee * person.NumOfVotes * 1.5));
            }
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


        public static bool AddToParty(Person p,string partyName,int location)
        {
            if(data.GetPartyList().Keys.Contains(partyName))
            {
                Member m = new Member(p.Id, p.Name, p.Age, p.UserName, p.Password, p.IsVoting, partyName, location);
                data.GetMembers().Add(m.Id, m);
                return true;
            }
            return false;
        }


    }
}
