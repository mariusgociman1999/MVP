using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Clasa : BasePropertyChanged
    {
        private int _idClasa;
        public int IdClasa
        {
            get { return _idClasa; }
            set 
            { 
                _idClasa = value;
                NotifyPropertyChanged();
            }
        }

        private string _descriere;
        public string Descriere
        {
            get { return _descriere; }
            set
            {
                _descriere = value;
                NotifyPropertyChanged();
            }
        }

        private Specializare _special;
        public Specializare Special 
        {
            get { return _special; }
            set
            {
                _special = value;
                NotifyPropertyChanged();
            }
        }

        public Clasa()
        {
            IdClasa = 0;
            Descriere = "";
            Special = new Specializare();
        }

        public Clasa(int id, string desc, Specializare spec)
        {
            IdClasa = id;
            Descriere = desc;
            Special = spec;
        }
    }
}
