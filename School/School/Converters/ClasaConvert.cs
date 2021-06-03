using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters 
{
    class ClasaConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int clasaID;
            if (!int.TryParse(values[0].ToString(), out clasaID))
            {
                return null;
            }
            return new Clasa()
            {
                IdClasa = clasaID,
                Descriere = values[1].ToString(),
                Special = new Specializare(int.Parse(values[2].ToString()), values[3].ToString())
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
