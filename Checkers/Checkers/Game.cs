using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Checkers
{
    class Game
    {
        public ObservableCollection<ObservableCollection<Piece>> _board;
        public ObservableCollection<ObservableCollection<Piece>> Board
        {
            get => _board;
            set => _board = value;
        }
        
        public Game()
        {
            InitBoard();
        }

        private void InitBoard()
        {
            Board = new ObservableCollection<ObservableCollection<Piece>>();
            for (int i = 0; i < 8; i++)
            {
                Board.Add(new ObservableCollection<Piece>());
                for (int j = 0; j < 8; j++)
                {
                    Board[i].Add(new Piece());
                }  
            }

            InitReds();
            InitBlacks();
        }

        private void InitBlacks()
        {
            int n = 5;
            int i;
            while (n <= 7)
            {
                i = n % 2 == 0 ? 1 : 0;
                for (; i < 8; i += 2)
                {
                    Board[n][i] = new Piece(new Position(n, i), 2);
                }
                n++;
            }
        }

        private void InitReds()
        {
            int n = 0;
            int i;
            while (n <= 2)
            {
                i = n % 2 == 0 ? 1 : 0;
                for (; i < 8; i += 2)
                {
                    Board[n][i] = new Piece(new Position(n, i), 1);
                }
                n++;
            }
        }
    }
}
