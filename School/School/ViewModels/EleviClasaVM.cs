using School.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels
{
    class EleviClasaVM
    {
        EleviBL eleviBL = new EleviBL();

        public EleviClasaVM(int clasaID)
        {
            Elevi = eleviBL.GetEleviClasa(clasaID);
        }

        public ObservableCollection<Elev> Elevi
        {
            get
            {
                return eleviBL.Elevi;
            }
            set
            {
                eleviBL.Elevi = value;
            }
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new RelayCommand<Elev>(eleviBL.ModElev);
                }
                return updateCommand;
            }
        }
    }
}