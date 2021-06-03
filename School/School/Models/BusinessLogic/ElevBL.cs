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
        public Elev elev { get; set; }

        ElevDA elevDA = new ElevDA();

        public Elev GetElev(int persID)
        {
            return elevDA.GetElev(persID);
        }

        public void AddElev(Elev elv)
        {
            elevDA.AddElev(elv);
        }

        public void ModElev(Elev elv)
        {
            elevDA.ModElev(elv);
        }
    }
}
