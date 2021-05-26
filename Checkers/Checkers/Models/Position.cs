using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Position
    {
        private int row;
        public int Row
        {
            get { return row; }
            set
            {
                row = value;
                NotifyPropertyChanged("Row");
            }
        }
        private int column;
        public int Column
        {
            get { return column; }
            set
            {
                column = value;
                NotifyPropertyChanged("Column");
            }
        }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public Position() : this(0, 0) { }

        public Position(Position pos) : this(pos.Row, pos.Column) { }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
