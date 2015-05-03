using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;

namespace AgileProdDAL
{
    public class WriteDictionariesToDataBase
    {
        
        string path;
        StreamWriter file;
        public WriteDictionariesToDataBase(string path)
        {
            this.path = path;
            WriteToPeople();
            WriteToPartyMember();
            WriteToHead();
            WriteToPartyList();
            WriteToPraimerise();
        }

        public void WriteToPeople()
        {
            file = new StreamWriter(path + "\\people.txt");
            foreach (var i in DataLogicAdmin.AllPersons())
            {
                file.WriteLine(i.Value.Id + "  ,  " + i.Value.Name + "  ,  " + i.Value.Age + "  ,  " + i.Value.UserName + "  ,  " + i.Value.Password + "  ,  " + "  ,  " + i.Value.IsVoting);
            }
        }

        public void WriteToPartyMember()
        {
            file = new StreamWriter(path + "\\members.txt");
            foreach (var i in DataLogicAdmin.AllMembers())
            {
                file.WriteLine(i.Value.Id + " , " + i.Value.Party + " , " + i.Value.Location);
            }
        }

        public void WriteToHead()
        {
            file = new StreamWriter(path + "\\Head.txt");
            foreach (var i in DataLogicAdmin.AllCommittee())
            {
                file.WriteLine(i.Value.Id);
            }
        }

        public void WriteToPartyList()
        {
            file = new StreamWriter(path + "\\parties.txt");
            foreach (var i in DataLogicAdmin.AllParties())
            {
                file.WriteLine(i.Key + " , " + i.Value);
            }
        }

        public void WriteToPraimerise()
        {
            file = new StreamWriter(path + "\\praimerise.txt");
            file.WriteLine(DataLogicAdmin.PraimeriesStatus());
        }
    }
}
