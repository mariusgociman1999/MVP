using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Materie : BasePropertyChanged
    {
        private int _idMaterie;
        public int IdMaterie {
            get { return _idMaterie; }
            set
            {
                _idMaterie = value;
                NotifyPropertyChanged();
            }
        }

        private string _descriere;
        public string Descriere {
            get { return _descriere; }
            set
            {
                _descriere = value;
                NotifyPropertyChanged();
            }
        }

        public Materie()
        {
            IdMaterie = 0;
            Descriere = "";
        }

        public Materie(int id, string desc)
        {
            IdMaterie = id;
            Descriere = desc;
        }
    }
}
