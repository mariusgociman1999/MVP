using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Profesor : Persoana
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

        private List<Clasa> _clase;
        public List<Clasa> Clase
        {
            get { return _clase; }
            set
            {
                _clase = value;
                NotifyPropertyChanged();
            }
        }

        private List<Materie> _materiiPred;
        public List <Materie> MateriiPred
        {
            get { return _materiiPred; }
            set
            {
                _materiiPred = value;
                NotifyPropertyChanged();
            }
        }
    }
}
