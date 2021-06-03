using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using School.Models;

namespace School.ViewModels
{
    public class SpecializareVM
    {
        ObservableCollection<Specializare> Specs = new ObservableCollection<Specializare>();
        SpecializareBL specBL = new SpecializareBL();

        public SpecializareVM()
        {
            Specs = specBL.GetSpecials();
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<Specializare>(specBL.AddSpecializare);
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
                    updateCommand = new RelayCommand<Specializare>(specBL.ModSpecializare);
                }
                return updateCommand;
            }
        }
    }
}
