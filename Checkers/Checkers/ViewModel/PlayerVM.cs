using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Checkers
{
    public class PlayerVM : Notification
    {
        public PlayerVM(Player play)
        {
            Play = play;
        }

        private Player _play;

        public Player Play
        {
            get { return _play; }
            set
            {
                _play = value;
                NotifyPropertyChanged("Play");
            }
        }
    }
}
