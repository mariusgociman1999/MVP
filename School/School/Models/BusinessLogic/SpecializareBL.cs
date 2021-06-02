using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class SpecializareBL
    {
        public ObservableCollection<Specializare> Specials { get; set; }

        SpecializareDA specsDA = new SpecializareDA();

        public ObservableCollection<Specializare> GetSpecials()
        {
            return specsDA.GetSpecializare();
        }

        public void AddSpecializare(Specializare spec)
        {
            specsDA.AddSpecializare(spec);
            Specials.Add(spec);
        }

        public void ModSpecializare(Specializare spec)
        {
            specsDA.ModSpecializare(spec);
        }
    }
}
