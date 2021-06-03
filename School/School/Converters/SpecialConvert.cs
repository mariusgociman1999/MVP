using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class SpecialConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int specID;
            if (!int.TryParse(values[0].ToString(), out specID))
            {
                return null;
            }
            return new Specializare()
            {
                IdSpecializare = specID,
                Descriere = values[1].ToString()
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Specializare spec = value as Specializare;
            object[] res = new object[] { spec.IdSpecializare, spec.Descriere };
            return res;
        }
    }
}
