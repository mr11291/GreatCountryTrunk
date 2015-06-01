using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;

namespace AgileProdDAL
{
    public class DataLogicMessage
    {
        //Varaiables
        private static DataRepository data;

        //Constructor
        static DataLogicMessage()
        {
            data = DataRepository.GetDataRepository();
        }

        public static void createEmptyMessageBox(int id)
        {
            Message newMessage = null;
            data.GetMessages().Add(id, newMessage);
        }

        public static Message getAllMessages(int id)
        {
            return data.GetMessages()[id];
        }
    }
}
