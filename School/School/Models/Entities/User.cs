using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class User : BasePropertyChanged
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

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
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
        public Rol Rol
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
