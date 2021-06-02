using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class EleviBL
    {
        public ObservableCollection<Elev> Elevi { get; set; }
        EleviDA eleviDA = new EleviDA();

        public ObservableCollection<Elev> GetEleviClasa(int clasaID)
        {
            return eleviDA.GetEleviClasa(clasaID);
        }

        public void ModElev(Elev elev)
        {
            eleviDA.ModElev(elev);
        }
    }
}
