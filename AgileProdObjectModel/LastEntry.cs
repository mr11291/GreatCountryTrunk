using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class LastEntry
    {
        //Varaiables
        private int id;
        private long last;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public long Last
        {
            get { return last; }
            set { last = value; }
        }

        public LastEntry(int id, long last)
        {
            this.id = id;
            this.last = last;
        }

    }
    
}
