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
        static
                Person thisPerson = data.GetPeople()[Id];
                Member newMember = new Member(Id,thisPerson.Name,thisPerson.Age,thisPerson.UserName,thisPerson.Password,thisPerson.IsVoting,Name,1);
                data.GetPartyList().Add(Name,0);
                data.GetMembers().Add(Id,newMember);
                return true;
            }
            else
                return false;
        }

    }

