using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class GameVM
    {
        public ObservableCollection<ObservableCollection<string>> _board;

        public ObservableCollection<ObservableCollection<string>> Board { get; set; }

        public GameVM(ObservableCollection<ObservableCollection<Piece>> board)
        {
            Board = new ObservableCollection<ObservableCollection<string>>();
            for (int i = 0; i < 8; i++)
            {
                Board.Add(new ObservableCollection<string>());
                for (int j = 0; j < 8; j++)
                {
                    Board[i].Add(board[i][j].Image);
                }
            }
        }
    }
}
