using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class ElevConvertAdd : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() == "")
            {
                return null;
            }
            return new Elev()
            {
                IdElev = 0,
                Nume = values[0].ToString(),
                Prenume = values[1].ToString(),
                IdPers = 0
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Elev elev = value as Elev;
            object[] res = new object[] { elev.IdElev, elev.Nume, elev.Prenume, elev.IdPers };
            return res;
        }
    }
}
