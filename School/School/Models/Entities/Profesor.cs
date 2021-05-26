using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Profesor : Persoana
    {
        private int _idProf;
        public int IdProf
        {
            get { return _idProf; }
            set
            {
                _idProf = value;
                NotifyPropertyChanged();
            }
        }

        private Clasa _clasa;
        public Clasa Clasa
        {
            get { return _clasa; }
            set
            {
                _clasa = value;
                NotifyPropertyChanged();
            }
        }

        private Materie _materiePred;
        public Materie MateriePred
        {
            get { return _materiePred; }
            set
            {
                _materiePred = value;
                NotifyPropertyChanged();
            }
        }
    }
}
