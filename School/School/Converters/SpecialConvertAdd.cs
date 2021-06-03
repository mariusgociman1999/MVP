using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class SpecialConvertAdd : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() == "")
            {
                return null;
            }
            return new Specializare()
            {
                IdSpecializare = 0,
                Descriere = values[0].ToString()
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
