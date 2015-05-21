using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProdObjectModel
{
    public class Memento
    {
        public readonly string PartyName;
        public readonly int location;
        public Memento(string PartyName,int location)
        {
            this.PartyName = PartyName;
            this.location = location;
        }
    }
}
