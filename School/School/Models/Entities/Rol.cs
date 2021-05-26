using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Rol : BasePropertyChanged
    {
        private int _idRol;

        public int IdRol
        {
            get { return _idRol; }
            set
            {
                _idRol = value;
                NotifyPropertyChanged();
            }
        }

        private string _descriere;
        public string Descriere
        {
            get { return _descriere;  }
            set
            {
                _descriere = value;
                NotifyPropertyChanged();
            }
        }
    }
}
