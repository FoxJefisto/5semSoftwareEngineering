using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class Archipelago
    {
        public string name;
        public int nIslands;
        public int nHabitableIslands;

        public static Archipelago Create(string name, int nIslands, int nHabitableIslands)
        {
            if (nHabitableIslands > nIslands)
                return null;
            return new Archipelago(name, nIslands, nHabitableIslands);
        }
        private Archipelago(string name, int nIslands, int nHabitableIslands)
        {
            this.name = name;
            this.nIslands = nIslands;
            this.nHabitableIslands = nHabitableIslands;    
        }
 
    }
}
