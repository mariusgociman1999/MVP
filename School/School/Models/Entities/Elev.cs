using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private ObservableCollection<Nota> _note;
        public ObservableCollection<Nota> Note 
        {
            get { return _note; }
            set
            {
                _note = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<Absenta> _absente;
        public ObservableCollection<Absenta> Absente
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
