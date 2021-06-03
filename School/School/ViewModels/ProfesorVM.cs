using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels
{
    public class ProfesorVM
    {
        ProfesorBL profBL = new ProfesorBL();

        public ProfesorVM(int persID)
        {
            Profesor = profBL.GetProfesor(persID);
        }

        public Profesor Profesor
        {
            get
            {
                return profBL.prof;
            }
            set
            {
                profBL.prof = value;
            }
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<Profesor>(profBL.AddProf);
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
                    updateCommand = new RelayCommand<Profesor>(profBL.ModProf);
                }
                return updateCommand;
            }
        }
    }
}
