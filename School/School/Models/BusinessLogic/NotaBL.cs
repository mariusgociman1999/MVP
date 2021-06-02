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
        public ObservableCollection<Nota> Note { get; set; }

        NotaDA noteDA = new NotaDA();

        public ObservableCollection<Nota> GetNote(int idElev)
        {
            return noteDA.GetNote(idElev);
        }

        public void AddNota(int idElev, Nota nota)
        {
            noteDA.AddNota(idElev, nota);
        }

        public void ModAbsenta(int idElev, Nota nota)
        {
            noteDA.ModNota(idElev, nota);
        }
    }
}