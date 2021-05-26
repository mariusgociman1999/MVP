using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Helper
    {
        public static Piece Current { get; set; }
        public static Piece Previous { get; set; }

        public static List<Position> toDelete { get; set; }
        public static ObservableCollection<ObservableCollection<Piece>> InitBoard()
        {
            toDelete = new List<Position>();
            ObservableCollection<ObservableCollection<Piece>> board = new ObservableCollection<ObservableCollection<Piece>>();
            for (int i = 0; i < 8; i++)
            {
                board.Add(new ObservableCollection<Piece>());
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            board[i].Add(new Piece(new Position(i, j), 0, "..\\Resources\\blank.png", "..\\Resources\\blank.png"));
                        }
                        else
                        {
                            board[i].Add(new Piece(new Position(i, j), 0, "..\\Resources\\blank_br.png", "..\\Resources\\blank_br.png"));
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            board[i].Add(new Piece(new Position(i, j), 0, "..\\Resources\\blank_br.png", "..\\Resources\\blank_br.png"));
                        }
                        else
                        {
                            board[i].Add(new Piece(new Position(i, j), 0, "..\\Resources\\blank.png", "..\\Resources\\blank.png"));
                        }
                    }

                }
            }
            InitReds(board);
            InitBlacks(board);
            return board;
        }

        private static void InitBlacks(ObservableCollection<ObservableCollection<Piece>> board)
        {
            int n = 5;
            int i;
            while (n <= 7)
            {
                i = n % 2 == 0 ? 1 : 0;
                for (; i < 8; i += 2)
                {
                    board[n][i] = new Piece(new Position(n, i), 2, "..\\Resources\\black.png", "..\\Resources\\blank_br.png");

                    if (i - 1 > 0 && n - 1 > 0 && board[n - 1][i - 1].Type == 0)
                    {
                        board[n][i].Moves.Add(new Position(n - 1, i - 1));
                    }
                    if (i + 1 < 8 && n - 1 > 0 && board[n - 1][i + 1].Type == 0)
                    {
                        board[n][i].Moves.Add(new Position(n - 1, i + 1));
                    }
                }
                n++;
            }
        }

        private static void InitReds(ObservableCollection<ObservableCollection<Piece>> board)
        {
            int n = 2;
            int i;
            while (n >= 0)
            {
                i = n % 2 == 0 ? 1 : 0;
                for (; i < 8; i += 2)
                {
                    board[n][i] = new Piece(new Position(n, i), 1, "..\\Resources\\red.png", "..\\Resources\\blank_br.png");

                    if (i - 1 >= 0 && n + 1 < 8 && board[n + 1][i - 1].Type == 0)
                    {
                        board[n][i].Moves.Add(new Position(n + 1, i - 1));
                    }
                    if (i + 1 < 8 && n + 1 < 8 && board[n + 1][i + 1].Type == 0)
                    {
                        board[n][i].Moves.Add(new Position(n + 1, i + 1));
                    }
                }
                n--;
            }
        }

        public static Piece UpdatePiece(ObservableCollection<ObservableCollection<Piece>> board, Piece piece)
        {
            Piece newPiece = new Piece();
            newPiece = piece;
            newPiece.Moves = new List<Position>();

            if (piece.Type == 1)
            {
                if (piece.Position.Row + 1 < 8)
                {
                    if (piece.Position.Column + 1 < 8)
                    {
                        if (board[piece.Position.Row + 1][piece.Position.Column + 1].Type == 0)
                        {
                            newPiece.Moves.Add(new Position(piece.Position.Row + 1, piece.Position.Column + 1));
                        }
                        else if (board[piece.Position.Row + 1][piece.Position.Column + 1].Type == 2)
                        {
                            if (piece.Position.Row + 2 < 8)
                            {
                                if (piece.Position.Column + 2 < 8)
                                {
                                    if (board[piece.Position.Row + 2][piece.Position.Column + 2].Type == 0)
                                    {
                                        newPiece.Moves.Add(new Position(piece.Position.Row + 2, piece.Position.Column + 2));
                                    }
                                }
                            }
                        }
                    }
                    if (piece.Position.Column - 1 >= 0)
                    {
                        if (board[piece.Position.Row + 1][piece.Position.Column - 1].Type == 0)
                        {
                            newPiece.Moves.Add(new Position(piece.Position.Row + 1, piece.Position.Column - 1));
                        }
                        else if (board[piece.Position.Row + 1][piece.Position.Column - 1].Type == 2)
                        {
                            if (piece.Position.Row + 2 < 8)
                            {
                                if (piece.Position.Column - 2 >= 0)
                                {
                                    if (board[piece.Position.Row + 2][piece.Position.Column - 2].Type == 0)
                                    {
                                        newPiece.Moves.Add(new Position(piece.Position.Row + 2, piece.Position.Column - 2));
                                    }
                                }
                            }
                        }
                    }
                }
                if (piece.King)
                {
                    if (piece.Position.Row - 1 >= 0)
                    {
                        if (piece.Position.Column + 1 < 8)
                        {
                            if (board[piece.Position.Row - 1][piece.Position.Column + 1].Type == 0)
                            {
                                newPiece.Moves.Add(new Position(piece.Position.Row - 1, piece.Position.Column + 1));
                            }
                            else if (board[piece.Position.Row - 1][piece.Position.Column + 1].Type == 2)
                            {
                                if (piece.Position.Row - 2 >= 0)
                                {
                                    if (piece.Position.Column + 2 < 8)
                                    {
                                        if (board[piece.Position.Row - 2][piece.Position.Column + 2].Type == 0)
                                        {
                                            newPiece.Moves.Add(new Position(piece.Position.Row - 2, piece.Position.Column + 2));
                                        }
                                    }
                                }
                            }
                        }
                        if (piece.Position.Column - 1 >= 0)
                        {
                            if (board[piece.Position.Row - 1][piece.Position.Column - 1].Type == 0)
                            {
                                newPiece.Moves.Add(new Position(piece.Position.Row - 1, piece.Position.Column - 1));
                            }
                            else if (board[piece.Position.Row - 1][piece.Position.Column - 1].Type == 2)
                            {
                                if (piece.Position.Row - 2 >= 0)
                                {
                                    if (piece.Position.Column - 2 >= 0)
                                    {
                                        if (board[piece.Position.Row - 2][piece.Position.Column - 2].Type == 0)
                                        {
                                            newPiece.Moves.Add(new Position(piece.Position.Row - 2, piece.Position.Column - 2));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (piece.Type == 2)
            {
                if (piece.Position.Row - 1 >= 0)
                {
                    if (piece.Position.Column + 1 < 8)
                    {
                        if (board[piece.Position.Row - 1][piece.Position.Column + 1].Type == 0)
                        {
                            newPiece.Moves.Add(new Position(piece.Position.Row - 1, piece.Position.Column + 1));
                        }
                        else if (board[piece.Position.Row - 1][piece.Position.Column + 1].Type == 1)
                        {
                            if (piece.Position.Row - 2 >= 0)
                            {
                                if (piece.Position.Column + 2 < 8)
                                {
                                    if (board[piece.Position.Row - 2][piece.Position.Column + 2].Type == 0)
                                    {
                                        newPiece.Moves.Add(new Position(piece.Position.Row - 2, piece.Position.Column + 2));
                                    }
                                }
                            }
                        }
                    }
                    if (piece.Position.Column - 1 >= 0)
                    {
                        if (board[piece.Position.Row - 1][piece.Position.Column - 1].Type == 0)
                        {
                            newPiece.Moves.Add(new Position(piece.Position.Row - 1, piece.Position.Column - 1));
                        }
                        else if (board[piece.Position.Row - 1][piece.Position.Column - 1].Type == 1)
                        {
                            if (piece.Position.Row - 2 >= 0)
                            {
                                if (piece.Position.Column - 2 >= 0)
                                {
                                    if (board[piece.Position.Row - 2][piece.Position.Column - 2].Type == 0)
                                    {
                                        newPiece.Moves.Add(new Position(piece.Position.Row - 2, piece.Position.Column - 2));
                                    }
                                }
                            }
                        }
                    }
                }

                if (piece.King)
                {
                    if (piece.Position.Row + 1 < 8)
                    {
                        if (piece.Position.Column + 1 < 8)
                        {
                            if (board[piece.Position.Row + 1][piece.Position.Column + 1].Type == 0)
                            {
                                newPiece.Moves.Add(new Position(piece.Position.Row + 1, piece.Position.Column + 1));
                            }
                            else if (board[piece.Position.Row + 1][piece.Position.Column + 1].Type == 1)
                            {
                                if (piece.Position.Row + 2 < 8)
                                {
                                    if (piece.Position.Column + 2 < 8)
                                    {
                                        if (board[piece.Position.Row + 2][piece.Position.Column + 2].Type == 0)
                                        {
                                            newPiece.Moves.Add(new Position(piece.Position.Row + 2, piece.Position.Column + 2));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (piece.Position.Column - 1 >= 0)
                    {
                        if (board[piece.Position.Row + 1][piece.Position.Column - 1].Type == 0)
                        {
                            newPiece.Moves.Add(new Position(piece.Position.Row + 1, piece.Position.Column - 1));
                        }
                        else if (board[piece.Position.Row + 1][piece.Position.Column - 1].Type == 1)
                        {
                            if (piece.Position.Row + 2 < 8)
                            {
                                if (piece.Position.Column - 2 >= 0)
                                {
                                    if (board[piece.Position.Row + 2][piece.Position.Column - 2].Type == 0)
                                    {
                                        newPiece.Moves.Add(new Position(piece.Position.Row + 2, piece.Position.Column - 2));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            board[piece.Position.Row][piece.Position.Column] = newPiece;
            return newPiece;
        }

        public static ObservableCollection<ObservableCollection<Piece>> DeletePiece(ObservableCollection<ObservableCollection<Piece>> board, Position pos, Piece piece)
        { 
            if (pos.Row > 1)
            {
                if (pos.Column < -1)
                {
                    board[piece.Position.Row - 1][piece.Position.Column + 1].ShownImage = board[piece.Position.Row - 1][piece.Position.Column + 1].HiddenImage;
                    board[piece.Position.Row - 1][piece.Position.Column + 1].Type = 0;
                }
                if (pos.Column > 1)
                {
                    board[piece.Position.Row + 1][piece.Position.Column - 1].ShownImage = board[piece.Position.Row + 1][piece.Position.Column - 1].HiddenImage;
                    board[piece.Position.Row + 1][piece.Position.Column - 1].Type = 0;
                }
            }
            if (pos.Row < -1)
            {
                if (pos.Column < -1)
                {
                    board[piece.Position.Row + 1][piece.Position.Column + 1].ShownImage = board[piece.Position.Row + 1][piece.Position.Column + 1].HiddenImage;
                    board[piece.Position.Row + 1][piece.Position.Column + 1].Type = 0;
                }
                if (pos.Column > 1)
                {
                    board[piece.Position.Row - 1][piece.Position.Column - 1].ShownImage = board[piece.Position.Row - 1][piece.Position.Column - 1].HiddenImage;
                    board[piece.Position.Row - 1][piece.Position.Column - 1].Type = 0;
                }
            }
            return board;
        }

        public static ObservableCollection<ObservableCollection<Piece>> UpdateBoard(ObservableCollection<ObservableCollection<Piece>> board)
        {
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Count; j++)
                {
                    board[i][j] = UpdatePiece(board, board[i][j]);
                }
            }
            return board;
        }

        public static Player UpdatePlayer(Player play, string text)
        {
            play.Name = text;
            return play;
        }
    }
}
