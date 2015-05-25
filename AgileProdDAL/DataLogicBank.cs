using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;
namespace AgileProdDAL
{
    public static class DataLogicBank
    {
        //Varaiables
        private static DataRepository data;

        //Constructor
        static DataLogicBank()
        {
            data = DataRepository.GetDataRepository();
        }

        public static Dictionary<int, Bank> getBankDictionary()
        {
            return data.GetBankAccounts();
        }
        

    }
}
