using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class ProfConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int profID;
            if (!int.TryParse(values[0].ToString(), out profID))
            {
                return null;
            }
            return new Profesor()
            {
                IdProf = profID,
                Nume = values[1].ToString(),
                Prenume = values[2].ToString(),
                IdPers = int.Parse(values[3].ToString())
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Profesor prof = value as Profesor;
            object[] res = new object[] { prof.IdProf, prof.Nume, prof.Prenume, prof.IdPers };
            return res;
        }
    }
}
