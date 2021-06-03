using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class MaterieBL
    {
        public ObservableCollection<Materie> Materii { get; set; }

        MaterieDA materiiDA = new MaterieDA();

        public ObservableCollection<Materie> GetMaterii()
        {
            return materiiDA.GetMaterie();
        }

        public void AddMaterie(Materie materie)
        {
            materiiDA.AddMaterie(materie);
        }

        public void ModMaterie(Materie materie)
        {
            materiiDA.ModMaterie(materie);
        }
    }
}