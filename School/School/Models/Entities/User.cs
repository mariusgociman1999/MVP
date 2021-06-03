using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class User : BasePropertyChanged
    {
        private string _idUser;
        public string IdUser 
        {
            get { return _idUser; }
            set
            {
                _idUser = value;
                NotifyPropertyChanged();
            }
        }

        private string _parola;
        public string Parola
        {
            get { return _parola; }
            set
            {
                _parola = value;
                NotifyPropertyChanged();
            }
        }

        private Rol _rol;
        public Rol RolUs
        {
            get { return _rol; }
            set
            {
                _rol = value;
                NotifyPropertyChanged();
            }
        }

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
    }
}
