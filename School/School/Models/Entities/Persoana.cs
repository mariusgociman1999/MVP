using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Persoana : BasePropertyChanged
    {
        public int _idPers;
        public int IdPers
        {
            get { return _idPers; }
            set
            {
                _idPers = value;
                NotifyPropertyChanged();
            }
        }

        public string _nume;
        public string Nume {
            get { return _nume; }
            set
            {
                _nume = value;
                NotifyPropertyChanged();
            }
        }

        public string _prenume;
        public string Prenume
        {
            get { return _prenume; }
            set
            {
                _prenume = value;
                NotifyPropertyChanged();
            }
        }
        
        public User User { get; set; }
    }
}
