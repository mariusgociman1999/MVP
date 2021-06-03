using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using School.Models;

namespace School.Converters
{
    class UserConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() == "" )
            {
                return null;
            }
            if (values.Length == 2)
            {
                return new User()
                {
                    IdUser = values[0].ToString(),
                    Parola = values[1].ToString()
                };
            }
            return new User()
            {
                IdUser = values[0].ToString(),
                Parola = values[1].ToString(),
                IdPers = int.Parse(values[2].ToString()),
                RolUs = new Rol(int.Parse(values[3].ToString()), "")
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            User user = value as User;
            object[] res = new object[] { user.IdPers, user.IdUser, user.Parola, user.RolUs.IdRol, user.RolUs.Descriere };
            return res;
        }
    }
}
