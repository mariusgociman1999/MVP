using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class NotaBL
    {
        public Nota nota { get; set; }

        NotaDA noteDA = new NotaDA();

        public void AddNota(int idElev, Nota nota)
        {
            noteDA.AddNota(idElev, nota);
        }

        public void ModNota(int idElev, Nota nota)
        {
            noteDA.ModNota(idElev, nota);
        }
    }
}