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
        public Absenta Absenta { get; set; }

        AbsentaDA absenteDA = new AbsentaDA();

        public void AddAbsenta(int idElev, Absenta absenta)
        {
            absenteDA.AddAbsenta(idElev, absenta);
        }

        public void ModAbsenta(int idElev, Absenta absenta)
        {
            absenteDA.ModAbsenta(idElev, absenta);
        }
    }
}