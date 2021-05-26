using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Piece : INotifyPropertyChanged
    {
        private string hiddenImage;
        public string HiddenImage
        {
            get { return hiddenImage; }
            set
            {
                hiddenImage = value;
                NotifyPropertyChanged("HidddenImage");
            }
        }

        private string shownImage;
        public string ShownImage
        {
            get { return shownImage; }
            set
            {
                shownImage = value;
                NotifyPropertyChanged("ShownImage");
            }
        }

        public Position _position;
        public Position Position
        {
            get => _position;
            set => _position = value;
        }

        public List<Position> _moves;
        public List<Position> Moves
        {
            get => _moves;
            set => _moves = value;
        }

        public List<Position> _delete;
        public List<Position> Delete
        {
            get => _delete;
            set => _delete = value;
        }

        public int _type;
        public int Type //if 1, piece is red; if 2, piece is black; if 0  piece is null
        {
            get => _type;
            set => _type = value;
        }

        public bool _king;
        public bool King
        {
            get => _king;
            set => _king = value;
        }

        public Piece(Position pos, int type, string shown, string hidden)
        {
            Position = pos;
            ShownImage = shown;
            HiddenImage = hidden;
            _type = type;
            Moves = new List<Position>();
        }
        public Piece() : this(new Position(0, 0), 0, "", "") { }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
