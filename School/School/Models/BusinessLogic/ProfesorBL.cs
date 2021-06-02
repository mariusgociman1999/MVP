using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class ProfesorBL
    { 
        ProfesorDA profDA = new ProfesorDA();

        public Profesor GetProfesor(int persID)
        {
            return profDA.GetProf(persID);
        }

        public void AddProf(Profesor prof)
        {
            profDA.AddProf(prof);
        }

        public void ModClasa(Profesor prof)
        {
            profDA.ModProf(prof);
        }
    }
}
