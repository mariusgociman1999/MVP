using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Position
    {
        public int _row;
        public int Row
        {
            get => _row;
            set => _row = value;
        }

        public int _column;
        public int Column
        {
            get => _column;
            set => _column = value;
        }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public Position() : this(0,0) { }

        public Position(Position pos) : this(pos.Row, pos.Column) { }
    }
}
