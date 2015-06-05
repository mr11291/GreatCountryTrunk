using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;
namespace AgileProdDAL


{
    public static class DataLogicLastEntry
    {
        //Varaiables
        private static DataRepository data;

        //Constructor
        static DataLogicLastEntry()
        {
            data = DataRepository.GetDataRepository();
        }

        public static Dictionary<int, LastEntry> getLastEntryDictionary()
        {
            return data.GetLastEntery();
        }
        




    }
}
