using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Dictionar
{
    public class Word : INotifyPropertyChanged, IComparable<Word>
    {
        public string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != _Name)
                {
                    _Name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string _Definition;
        public string Definition
        {
            get { return _Definition; }
            set
            {
                if (value != _Definition)
                {
                    _Definition = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set
            {
                if (value != _ImagePath)
                {
                    _ImagePath = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Word(string desc, string def, string path)
        {
            Name = desc;
            Definition = def;
            ImagePath = path;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int CompareTo(Word obj)
        {
            if (null == obj)
            {
                return 1;
            }
            return string.Compare(this.Name, obj.Name);
        }
    }
}
