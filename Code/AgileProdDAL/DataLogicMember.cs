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

        //selectPartyLeader selects a party leader using an algorithem to find the richest person in each party
        public static void selectPartyLeader()
        {
            //Tuple<int, int> temp = new Tuple<int, int> (Convert.ToInt32(data.GetMembers().Keys), Convert.ToInt32(data.GetPartyList().Keys));
            int RichestMemberId = 0;
            int balance = 0;
            foreach (var party in data.GetPartyList())                          //loop trough all of the parties
            {
                foreach (var id in data.GetMembers())                           //loop trough all of the party members
                {
                    if (data.GetMembers()[id.Key].Party.Replace(" ", string.Empty).Equals(party.Key.Replace(" ", string.Empty)))    //this if loop will make sure we are only looking at people from the same party
                    {
                        if (data.GetBankAccounts()[id.Key].Balance > balance)   //we will get into this if only if we found someone richer
                        {
                            balance = data.GetBankAccounts()[id.Key].Balance;   //set new balance to compare with
                            RichestMemberId = id.Key;                           //remember richest party member
                        }
                    }
                }
                data.GetMembers()[RichestMemberId].Location = -1;               //set richest party member to be the party leader of his party
                balance = 0;
            }

        }

        //NEEDS DOCUMENTATION
        public static void AddSlogan(Member partyMember, string slogan)
        {
            partyMember.Slogan = slogan;
        }

        public static Dictionary<int,Member> GetMember()
        {
            return data.GetMembers();
        }

        //the function returen the id of the most rich member in the party  
        public static int mostRich(string NameOfParty, Dictionary<int, Member> dict)
        {
            int rich = -1;
            foreach (var x in dict.Values)
            {
                if (x.Party.Equals(NameOfParty))
                    //chack if the party member is at the same party we search 
                    if (data.GetBankAccounts()[x.Id].Balance >= rich)
                        //chack if the party member is thr richest 
                        rich = x.Id;
            }
            return rich;
        }

        //the function remove party member from DB, if neccery delete allso the party from DB
        // return int for messeges in GUI:
        //0- "the member dosn't excist" , 1- "function seccied" , (-1)- "the party dosn't excist" 
        public static int QuitParty(Member mem)
        {
            if (data.GetMembers().ContainsKey(mem.Id))
            {
                int count = 0;
                foreach (var x in data.GetMembers().Values)
                {
                    if (x.Party.Equals(mem.Party))
                    {  //count how mach members we have in the party befor quiting
                        count++;
                    }
                }
                if (count == 0)
                {
                    return -1;
                } //the party dosn't excist
                else if (count == 1) //the party have only 1 member and he want to quit
                {
                    data.GetMembers().Remove(mem.Id); //delete the mem from Members DB
                    data.GetPartyList().Remove(mem.Party); //delete the Party of the member that quit from Party DB
                    return 1;//the fnction seccied
                }
                else //the party have more then 1 member and he want to quit
                {
                    if (mem.Location == -1)//the member that quits is the party leader
                    {
                        string nameOfParty = mem.Party;
                        data.GetMembers().Remove(mem.Id); //delete the mem from Members DB
                        int NewHead = mostRich(nameOfParty, data.GetMembers());
                        data.GetMembers()[NewHead].Location = -1;//set the new party leader
                        return 1;//function seccied
                    }
                    else
                    {
                        data.GetMembers().Remove(mem.Id); //delete the mem from Members DB
                        return 1;//function seccied
                    }
                }
            }
            else
                return 0; //the member dosn't excist
        }

        public static Dictionary<int, Member> returnColleagues(string partyName)
        {
            Dictionary<int, Member> temp = new Dictionary<int, Member>();

            foreach (var item in data.GetMembers())
            {
                if (item.Value.Party.Equals(partyName))
                {
                    temp.Add(item.Key, item.Value);
                }
            }
            return temp;
        }

    }
}
