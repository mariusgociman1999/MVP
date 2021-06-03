using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class UserBL
    {
        public ObservableCollection<User> Users { get; set; }

        UserDA usersDA = new UserDA();

        public ObservableCollection<User> GetUsers()
        {
            return usersDA.GetUsers();
        }

        public void AddUser(User user)
        {
            usersDA.AddUser(user);
        }

        public void ModUser(User user)
        {
            usersDA.ModUser(user);
        }
    }
}
