using Checkers.Services;
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
        private ObservableCollection<ObservableCollection<PieceVM>> _board;

        public ObservableCollection<ObservableCollection<PieceVM>> BoardVM
        {
            get => _board;
            set => _board = value;
        }

        private GameLogic gl;
        public GameVM()
        {
            ObservableCollection<ObservableCollection<Piece>> temp = Helper.InitBoard();
            gl = new GameLogic(temp);
            BoardVM = ToVM(temp);
        }

        private ObservableCollection<ObservableCollection<PieceVM>> ToVM(ObservableCollection<ObservableCollection<Piece>> board)
        {
            ObservableCollection<ObservableCollection<PieceVM>> res = new ObservableCollection<ObservableCollection<PieceVM>>();
            for (int i = 0; i< board.Count; i++)
            {
                ObservableCollection<PieceVM> line = new ObservableCollection<PieceVM>();
                for (int j = 0; j < board[i].Count; j++)
                {
                    Piece p = board[i][j];
                    PieceVM pvm = new PieceVM(p, gl);
                    line.Add(pvm);
                }
                res.Add(line);
            }
            return res;
        }

        public GameVM(ObservableCollection<ObservableCollection<PieceVM>> board)
        {
            this.BoardVM = board;
        }
    }
}
