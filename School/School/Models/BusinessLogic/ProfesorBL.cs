using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class ProfesorBL
    {
        public Profesor prof { get; set; }

        ProfesorDA profDA = new ProfesorDA();

        public Profesor GetProfesor(int persID)
        {
            return profDA.GetProf(persID);
        }

        public void AddProf(Profesor prof)
        {
            profDA.AddProf(prof);
        }

        public void ModProf(Profesor prof)
        {
            profDA.ModProf(prof);
        }
    }
}
