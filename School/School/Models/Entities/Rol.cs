using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Rol : BasePropertyChanged
    {
        public Rol(int idRol, string desc)
        {
            IdRol = idRol;
            Descriere = desc;
        }

        public Rol()
        {
            IdRol = 0;
            Descriere = ""; 
        }
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
