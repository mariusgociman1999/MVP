using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Models;

namespace School.Converters
{
    class AbsentaConvert
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int absentaID;
            if (!int.TryParse(values[0].ToString(), out absentaID))
            {
                return null;
            }
            return new Absenta()
            {
                idAbsenta = absentaID,
                Data = DateTime.Parse(values[1].ToString()),
                Materie = new Materie(int.Parse(values[2].ToString()), values[3].ToString()),
                Motivata = bool.Parse(values[4].ToString())
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Absenta abs = value as Absenta;
            object[] res = new object[] { abs.idAbsenta, abs.Data, abs.Materie.IdMaterie, abs.Materie.Descriere, abs.Motivata };
            return res;
        }
    }
}
