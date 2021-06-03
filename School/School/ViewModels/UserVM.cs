using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using School.Models;

namespace School.ViewModels
{
    class UserVM
    {
        UserBL userBL = new UserBL();

        public UserVM()
        {
            UserList = userBL.GetUsers();
        }

        public ObservableCollection<User> UserList
        {
            get
            {
                return userBL.Users;
            }
            set
            {
                userBL.Users = value;
            }
        }

        public User CheckUser(string name, string pass)
        {
            User result = null;
            foreach (User user in UserList)
            {
                if (user.IdUser == name && user.Parola == pass)
                {
                    result = user;
                }
            }
            return result;
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand<User>(userBL.AddUser);
                }
                return addCommand;
            }
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new RelayCommand<User>(userBL.ModUser);
                }
                return updateCommand;
            }
        }
    }
}
