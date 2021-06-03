using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels
{
    class NotaVM
    {
        int idElev { get; set; }
        Nota notaVM { get; set; }

        NotaBL notaBL = new NotaBL();

        public NotaVM(int idelev)
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
                    addCommand = new RelayCommand<Nota>(delegate { notaBL.AddNota(idElev, notaVM); });
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
                    updateCommand = new RelayCommand<Nota>(delegate { notaBL.ModNota(idElev, notaVM); });
                }
                return updateCommand;
            }
        }
    }
}