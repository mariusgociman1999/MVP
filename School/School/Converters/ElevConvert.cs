using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class ElevConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int elevID;
            if (!int.TryParse(values[0].ToString(), out elevID))
            {
                return null;
            }
            return new Elev()
            {
                IdElev = elevID,
                Nume = values[1].ToString(),
                Prenume = values[2].ToString(),
                IdPers = int.Parse(values[3].ToString())
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
