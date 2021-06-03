using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class NotaConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int notaID;
            if (!int.TryParse(values[0].ToString(), out notaID))
            {
                return null;
            }
            return new Nota()
            {
                IdNota = notaID,
                Data = DateTime.Parse(values[1].ToString()),
                Materie = new Materie(int.Parse(values[2].ToString()), values[3].ToString()),
                Teza = bool.Parse(values[4].ToString())
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Nota nota = value as Nota;
            object[] res = new object[] { nota.IdNota, nota.Data, nota.Materie.IdMaterie, nota.Materie.Descriere, nota.Teza };
            return res;
        }
    }
}
