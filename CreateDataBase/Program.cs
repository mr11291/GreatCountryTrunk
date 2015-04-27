using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCSVFilesV2 csvF = new CreateCSVFilesV2(@"C:\Users\Michael\Desktop\GreatCountryTrunk\AgileProdDAL\Database\people.txt",
                                                         @"C:\Users\Michael\Desktop\GreatCountryTrunk\AgileProdDAL\Database\members.txt",
                                                         @"C:\Users\Michael\Desktop\GreatCountryTrunk\AgileProdDAL\Database\parties.txt",
                                                         @"C:\Users\Michael\Desktop\GreatCountryTrunk\AgileProdDAL\Database\committee.txt",
                                                         @"C:\Users\Michael\Desktop\GreatCountryTrunk\AgileProdDAL\Database\bankAccounts.txt",
                                                         @"C:\Users\Michael\Desktop\GreatCountryTrunk\AgileProdDAL\Database\messageInbox.txt");
            csvF.writeFiles();
        }
    }
}
