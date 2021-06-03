using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Models;

namespace School.Converters
{
    class UserConvert
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() == "")
            {
                return null;
            }
            return new User()
            {
                Username = values[0].ToString(),
                Parola = values[1].ToString()
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            User user = value as User;
            object[] res = new object[] { user.IdPers, user.IdUser, user.Parola, user.Rol.IdRol, user.Rol.Descriere };
            return res;
        }
    }
}
