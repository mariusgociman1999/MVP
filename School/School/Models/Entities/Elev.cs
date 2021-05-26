using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Elev : Persoana
    {
        private int _idElev;
        public int IdElev
        {
            get { return _idElev; }
            set
            {
                _idElev = value;
                NotifyPropertyChanged();
            }
        }

        private Clasa _clasaFrecv;
        public Clasa ClasaFrecv 
        {
            get { return _clasaFrecv; }
            set
            {
                _clasaFrecv = value;
                NotifyPropertyChanged();
            }
        }

        private List<Nota> _note;
        public List<Nota> Note 
        {
            get { return _note; }
            set
            {
                _note = value;
                NotifyPropertyChanged();
            }
        }

        private List<Absenta> _absente;
        public List<Absenta> Absente
        {
            get { return _absente; }
            set
            {
                _absente = value;
                NotifyPropertyChanged();
            }
        }

    }
}
