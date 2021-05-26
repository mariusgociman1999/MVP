using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class GameVM
    {
        public ObservableCollection<ObservableCollection<PieceVM>> BoardVM
        { get; set; }

        public ObservableCollection<PlayerVM> myPlayer { get; set; }

        private GameLogic gl;
        public GameVM()
        {
            ObservableCollection<ObservableCollection<Piece>> temp = Helper.InitBoard();
            gl = new GameLogic(temp);
            BoardVM = ToVM(gl.Board);
            myPlayer = ToVM(gl.player);
        }

        private ObservableCollection<ObservableCollection<PieceVM>> ToVM(ObservableCollection<ObservableCollection<Piece>> board)
        {
            ObservableCollection<ObservableCollection<PieceVM>> res = new ObservableCollection<ObservableCollection<PieceVM>>();
            for (int i = 0; i < board.Count; i++)
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

        private ObservableCollection<PlayerVM> ToVM(Player play)
        {
            ObservableCollection<PlayerVM> temp = new ObservableCollection<PlayerVM>();
            temp.Add(new PlayerVM(play));
            return temp;
        }
    }
}
