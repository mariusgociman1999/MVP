using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class RolConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int rolID;
            if (!int.TryParse(values[0].ToString(), out rolID))
            {
                return null;
            }
            return new Rol()
            {
                IdRol = rolID,
                Descriere = values[1].ToString()
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Rol rol = value as Rol;
            object[] res = new object[] { rol.IdRol, rol.Descriere };
            return res;
        }
    }
}
