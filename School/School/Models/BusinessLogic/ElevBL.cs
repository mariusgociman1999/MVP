using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models 
{ 
    class ElevBL
    {
        ElevDA elevDA = new ElevDA();

        public Elev GetElev(int persID)
        {
            return elevDA.GetElev(persID);
        }

        public void AddClasa(Elev elv)
        {
            elevDA.AddElev(elv);
        }

        public void ModClasa(Elev elv)
        {
            elevDA.ModElev(elv);
        }
    }
}
