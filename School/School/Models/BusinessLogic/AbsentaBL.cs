using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class AbsentaBL
    {
        public ObservableCollection<Absenta> Absente { get; set; }

        AbsentaDA absenteDA = new AbsentaDA();

        public ObservableCollection<Absenta> GetAbsente(int idElev)
        {
            return absenteDA.GetAbsenta(idElev);
        }

        public void AddAbsenta(int idElev, Absenta absenta)
        {
            absenteDA.AddAbsenta(idElev, absenta);
            Absente.Add(absenta);
        }

        public void ModAbsenta(int idElev, Absenta absenta)
        {
            absenteDA.ModAbsenta(idElev, absenta);
        }
    }
}