using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Checkers
{
    public class PieceVM : Notification
    {
        GameLogic gl;
        public PieceVM(Piece piece, GameLogic gl)
        {
            Piece = piece;
            this.gl = gl;
        }
        
        private Piece _piece;
        
        public Piece Piece
        {
            get { return _piece; }
            set
            {
                _piece = value;
                NotifyPropertyChanged("Piece");
            }
        }

        private ICommand clickCommand;

        public ICommand ClickCommand
        {
            get{
                if(clickCommand == null)
                {
                    clickCommand = new RelayCommand<Piece>(gl.ClickAction);
                }
                return clickCommand;
            }
        }
    }
}
