using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class RolBL
    {
        public ObservableCollection<Rol> Roluri { get; set; }

        RolDA roluriDA = new RolDA();

        public ObservableCollection<Rol> GetRoluri()
        {
            return roluriDA.GetRol();
        }

        public void AddRol(Rol rol)
        {
            roluriDA.AddRol(rol);
            Roluri.Add(rol);
        }

        public void ModAbsenta(Rol rol)
        {
            roluriDA.ModRol(rol);
        }
    }
}