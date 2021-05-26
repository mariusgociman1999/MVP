using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Checkers
{
    public class GameLogic
    {
        public ObservableCollection<ObservableCollection<Piece>> Board { get; set; }
        public GameLogic(ObservableCollection<ObservableCollection<Piece>> board)
        {
            Board = board;
        }

        private Piece first { get; set; }
        private Piece second { get; set; }

        private int reds = 12;
        private int blacks = 12;

        public Player player { get; set; } = new Player("");

        private int clickCount = 0;

        public int turn = 2;

        public void ClickAction(Piece piece) 
        {
            if(clickCount == 0 && piece != null && piece.Type != 0 && piece.Type == turn)
            {
                first = piece;
                Helper.Current = piece;
                clickCount++;
            }
            else if(clickCount == 1 && piece != null && piece.Type != first.Type)
            {
                second = piece;
                clickCount++;
                if (first.Moves.Any(item => item.Row == second.Position.Row && item.Column == second.Position.Column))
                {
                    MovePiece();
                    piece = Helper.UpdatePiece(Board, second);
                    Helper.DeletePiece(Board, new Position(second.Position.Row - first.Position.Row, second.Position.Column - first.Position.Column), second);
                    if (second.Type == 1)
                    {
                        reds--;
                    }
                    else
                    {
                        blacks--;
                    }
                    if (blacks == 0)
                    {
                        MessageBox.Show("Reds won!");
                    }
                    else if(reds == 0)
                    {
                        MessageBox.Show("Blacks won!");
                    }
                    Board = Helper.UpdateBoard(Board);
                    clickCount = 0;
                }
                else
                {
                    MessageBox.Show("Invalid Move!");
                    first = null;
                    second = null;
                    Helper.Current = null;
                    Helper.Previous = null;
                    clickCount = 0;
                }
            }
            else
            {
                first = null;
                second = null;
                clickCount = 0;
            }
        }

        private void MovePiece()
        {
            if (first.Type == 1 && second.Position.Row == 7)
            {
                second.King = true;
                second.ShownImage = "..\\Resources\\red_k.png";
            }
            else if(first.Type == 2 && second.Position.Row == 0)
            {
                second.King = true;
                second.ShownImage = "..\\Resources\\black_k.png";
            }
            else
            {
                second.ShownImage = first.ShownImage;
                second.King = first.King;
            }

            if(first.Type == 1)
            {
                turn = 2;
                player = Helper.UpdatePlayer(player, "Blacks");
            }
            else if(first.Type == 2)
            {
                turn = 1;
                player = Helper.UpdatePlayer(player, "Reds");
            }

            first.ShownImage = first.HiddenImage;
            second.Type = first.Type;
            first.Type = 0;
            Board[second.Position.Row][second.Position.Column] = second;
            Board[first.Position.Row][first.Position.Column] = first;

            Helper.Current = second;
            Helper.Previous = first;
        }
    }
}
