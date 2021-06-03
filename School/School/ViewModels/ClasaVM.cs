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
    public class ClasaVM
    {
        public ClasaVM()
        {
            ClasList = clasBl.GetClase();
            SpecList = specBl.GetSpecials();
        }

        SpecializareBL specBl = new SpecializareBL();
        ClasaBL clasBl = new ClasaBL();

        public ObservableCollection<Specializare> SpecList
        {
            get
            {
                return specBl.Specials;
            }
            set
            {
                specBl.Specials = value;
            }
        }

        public ObservableCollection<Clasa> ClasList
        {
            get
            {
                return clasBl.Clase;
            }
            set
            {
                clasBl.Clase = value;
            }
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<Clasa>(clasBl.AddClasa);
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
                    updateCommand = new RelayCommand<Clasa>(clasBl.ModClasa);
                }
                return updateCommand;
            }
        }
    }
}
