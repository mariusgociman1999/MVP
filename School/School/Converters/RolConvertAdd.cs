using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class RolConvertAdd : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() == "")
            {
                return null;
            }
            return new Rol()
            {
                IdRol = 0,
                Descriere = values[0].ToString()
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
