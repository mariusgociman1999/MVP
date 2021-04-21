using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Checkers.Services
{
    public class GameLogic
    {
        private ObservableCollection<ObservableCollection<Piece>> _board;
        public GameLogic(ObservableCollection<ObservableCollection<Piece>> board)
        {
            this._board = board;
        }

        private Position first { get; set; }
        private Position second { get; set; }

        private int clickCount = 0;

        public void ClickAction(Piece piece) 
        {
            if(clickCount == 0 && piece != null)
            {
                first = piece.Position;
                clickCount++;
            }
            else if(clickCount == 1 && piece != null)
            {
                second = piece.Position;
                clickCount++;
                if (_board[first.Row][first.Column].Moves.Contains(second))
                {
                    MovePiece();
                }
                else
                {
                    MessageBox.Show("Invalid Move!");
                    first = new Position();
                    second = new Position();
                    clickCount = 0;
                }
            }
            else
            {
                first = new Position();
                second = new Position();
                clickCount = 0;
            }
        }

        private void MovePiece()
        {
            _board[second.Row][second.Column] = _board[first.Row][first.Column];
            _board[first.Row][first.Column] = new Piece();
        }
    }
}
