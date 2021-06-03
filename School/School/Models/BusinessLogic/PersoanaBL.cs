using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class PersoanaBL
    {
        public ObservableCollection<Persoana> Prople { get; set; }

        PersoanaDA peopleDA = new PersoanaDA();

        public ObservableCollection<Persoana> GetPeople()
        {
            return peopleDA.GetPeople();
        }
    }
}
