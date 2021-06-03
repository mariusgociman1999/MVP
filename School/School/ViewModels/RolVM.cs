using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Models;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace School.ViewModels
{
    class RolVM
    {
        ObservableCollection<Rol> roluri { get; set; }

        RolBL rolBL = new RolBL();

        public RolVM()
        {
            roluri = rolBL.GetRoluri();
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<Rol>(rolBL.AddRol);
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
                    updateCommand = new RelayCommand<Rol>(rolBL.ModRol);
                }
                return updateCommand;
            }
        }
    }
}
