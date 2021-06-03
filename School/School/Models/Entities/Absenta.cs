using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Absenta : BasePropertyChanged
    {
        private int _idAbsenta;
        public int idAbsenta
        {
            get { return _idAbsenta; }
            set
            {
                _idAbsenta = value;
                NotifyPropertyChanged();
            }
        }

        private Materie _materie;
        public Materie Materie
        {
            get { return _materie; }
            set
            {
                _materie = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime _data;
        public DateTime Data
        {
            get{ return _data; }
            set
            {
                _data = value;
                NotifyPropertyChanged();
            }
        }

        private bool _motivata;
        public bool Motivata
        {
            get { return _motivata; }
            set
            {
                _motivata= value;
                NotifyPropertyChanged();
            }
        }
    }
}
