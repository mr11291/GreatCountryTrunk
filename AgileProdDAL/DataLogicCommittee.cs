using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;

namespace AgileProdDAL
{
    public static class DataLogicCommittee
    {
        private static DataRepository data;

        static DataLogicCommittee()
        {
            data = DataRepository.GetDataRepository();
        }
        public static bool AddParty(string Name, int Id)
        {
            if (data.GetPeople().Any(current => current.Key == Id && !data.GetMembers().Any(current1 => current1.Key == Id) && !data.GetPartyList().Any(current2 => current2.Key == Name)))
            {

                Person thisPerson = data.GetPeople()[Id];
                Member newMember = new Member(Id, thisPerson.Name, thisPerson.Age, thisPerson.UserName, thisPerson.Password, thisPerson.IsVoting, Name, 1);
                data.GetPartyList().Add(Name, 0);
                data.GetMembers().Add(Id, newMember);
                return true;
            }
            else
                return false;
        }

    }

}