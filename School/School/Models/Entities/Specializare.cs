using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Specializare : BasePropertyChanged
    {
        private int _idSpecializare;
        public int IdSpecializare 
        {
            get { return _idSpecializare; }
            set
            {
                _idSpecializare = value;
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

        public Specializare()
        {
            IdSpecializare = 0;
            Descriere = "";
        }

        public Specializare(int id, string desc)
        {
            IdSpecializare = id;
            Descriere = desc;
        }
    }
}
