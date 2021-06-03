using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels
{
    class AbsentaVM
    {
        int idElev { get; set; }
        Absenta abs { get; set; }

        AbsentaBL absBL = new AbsentaBL();

        public AbsentaVM(int idelev)
        {
            idElev = idelev;
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<Absenta>(delegate { absBL.AddAbsenta(idElev, abs); });
                }
                return addCommand;
            }
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new RelayCommand<Absenta>(delegate { absBL.ModAbsenta(idElev, abs); });
                }
                return updateCommand;
            }
        }
    }
}

