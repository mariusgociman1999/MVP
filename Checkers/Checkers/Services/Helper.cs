using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Services
{
    public class Helper
    {
        public static ObservableCollection<ObservableCollection<Piece>> InitBoard()
        {
            ObservableCollection<ObservableCollection<Piece>> board = new ObservableCollection<ObservableCollection<Piece>>();
            for (int i = 0; i < 8; i++)
            {
                board.Add(new ObservableCollection<Piece>());
                for (int j = 0; j < 8; j++)
                {
                    board[i].Add(new Piece());
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
                    board[n][i] = new Piece(new Position(n, i), 2);
                }
                n++;
            }
        }

        private static void InitReds(ObservableCollection<ObservableCollection<Piece>> board)
        {
            int n = 0;
            int i;
            while (n <= 2)
            {
                i = n % 2 == 0 ? 1 : 0;
                for (; i < 8; i += 2)
                {
                    board[n][i] = new Piece(new Position(n, i), 1);
                }
                n++;
            }
        }
    }
}
