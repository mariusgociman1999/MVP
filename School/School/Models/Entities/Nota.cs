using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Nota : BasePropertyChanged
    {
        private int _idNota;
        public int IdNota
        {
            get { return _idNota; }
            set
            {
                _idNota = value;
                NotifyPropertyChanged();
            }
        }

        private decimal _valoare;
        public decimal Valoare
        {
            get { return _valoare; }
            set
            {
                _valoare = Math.Round(value, 2);
                NotifyPropertyChanged();
            }
        }

        private Materie _materie;
        public Materie Materie 
        {
            get { return _materie; }
            set
            {
                _materie = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime _data;
        public DateTime Data {
            get { return _data; }
            set
            {
                _data = value;
                NotifyPropertyChanged();
            }
        }

        private bool _teza;
        public bool Teza
        {
            get { return _teza; }
            set
            {
                _teza = value;
                NotifyPropertyChanged();
            }
        }

    }
}
