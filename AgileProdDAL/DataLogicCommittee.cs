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
        public static Head LoginCommittee(string username, string password)  //Committee
        {
            
            var tempMemberDictionary = data.GetCommittee();                               //get temporary party member dictionary
            Head Success = null;                                                      //initialize a new empty Member class instance
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
        public static Dictionary<string, int> GetPartyList()
        {
            return data.GetPartyList();
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
