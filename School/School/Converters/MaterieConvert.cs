using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Models;

namespace School.Converters
{
    class MaterieConvert
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int materieID;
            if (!int.TryParse(values[0].ToString(), out materieID))
            {
                return null;
            }
            return new Materie()
            {
                IdMaterie = materieID,
                Descriere = values[1].ToString()
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Materie mat = value as Materie;
            object[] res = new object[] { mat.IdMaterie, mat.Descriere };
            return res;
        }
    }
}
