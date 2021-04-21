using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Checkers
{
    public class Game
    {
        public ObservableCollection<ObservableCollection<Piece>> _board;
        public ObservableCollection<ObservableCollection<Piece>> Board
        {
            get => _board;
            set => _board = value;
        }
        
        public Game()
        {
        }

    }
}
