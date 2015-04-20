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

        //AddParty, committee is the only user that can add new party, the function get the new name and the ID of the head of the party
        public static bool AddParty(string Name, int Id)
        {
            //Check if the head is a person, check if he is alrady a member, and check if there is a party with the same name
            if (data.GetPeople().Any(current => current.Key == Id && !data.GetMembers().Any(current1 => current1.Key == Id) && !data.GetPartyList().Any(current2 => current2.Key == Name)))
            {

                Person thisPerson = data.GetPeople()[Id];//crating new person for the head of the newParty
                Member newMember = new Member(Id, thisPerson.Name, thisPerson.Age, thisPerson.UserName, thisPerson.Password, thisPerson.IsVoting, Name,1);//crating a member
                data.GetPartyList().Add(Name, 0);//Add the new party to PartyList
                data.GetMembers().Add(Id, newMember);//Add new member(Head) to the members
                return true;
            }
            else
                return false;
        }

        public static void ChangePraimeryStatus()
        {
            if (data.GetPraimerise() == false)
                data.setPraimeries(true);
            else
                data.setPraimeries(false);
        }




    }
}
