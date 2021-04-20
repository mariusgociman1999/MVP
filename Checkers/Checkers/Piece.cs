using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Piece
    {
        public string _image;
        public string Image 
        {
            get => _image;
            set => _image = value;
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

        public Piece(Position pos, int type)
        {
            Position = new Position(pos);
            if (type == 1)
            {
                Image = "\\red.png";
            }
            else if(type == 2)
            {
                Image = "\\black.png";
            }
            else
            {
                Image = "";
            }
            Moves = new List<Position>();
        }
        public Piece() : this(new Position(0, 0), 0){ }
    }
}
