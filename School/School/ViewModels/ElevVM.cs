using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels
{
    class ElevVM
    {
        ElevBL elevBL = new ElevBL();

        public ElevVM(int persID)
        {
            Elev = elevBL.GetElev(persID);
        }

        public Elev Elev
        {
            get
            {
                return elevBL.elev;
            }
            set
            {
                elevBL.elev = value;
            }
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<Elev>(elevBL.AddElev);
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
                    updateCommand = new RelayCommand<Elev>(elevBL.ModElev);
                }
                return updateCommand;
            }
        }
    }
}