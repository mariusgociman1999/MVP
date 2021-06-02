using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class ClasaBL
    {
        public ObservableCollection<Clasa> Clase { get; set; }

        ClasaDA clasaDA = new ClasaDA();

        public ObservableCollection<Clasa> GetClase()
        {
            return clasaDA.GetClase();
        }

        public void AddClasa(Clasa clasa)
        {
            clasaDA.AddClasa(clasa);
            Clase.Add(clasa);
        }

        public void ModClasa(Clasa clasa)
        {
            clasaDA.ModClasa(clasa);
        }
    }
}