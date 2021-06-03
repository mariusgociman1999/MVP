using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class ClasaConvertAdd : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            
            if (values[0].ToString()!= "")
            {
                return null;
            }
            return new Clasa()
            {
                IdClasa = 0,
                Descriere = values[0].ToString(),
                Special = new Specializare(int.Parse(values[1].ToString()), "")
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Clasa cls = value as Clasa;
            object[] res = new object[] { cls.IdClasa, cls.Descriere, cls.Special.IdSpecializare, cls.Special.Descriere };
            return res;
        }
    }
}
