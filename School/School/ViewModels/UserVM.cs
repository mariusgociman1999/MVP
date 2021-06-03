using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using School.Models;
using School.Views;

namespace School.ViewModels
{
    class UserVM
    {
        UserBL userBL = new UserBL();
        PersoanaBL persoanaBL = new PersoanaBL();

        public UserVM()
        {
            UserList = userBL.GetUsers();
            PeopleList = persoanaBL.GetPeople();
        }
        public ObservableCollection<Persoana> PeopleList
        {
            get
            {
                return persoanaBL.Prople;
            }
            set
            {
                persoanaBL.Prople = value;
            }
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

        public void CheckUser(User user)
        {
            if (user != null)
            {
                foreach (User use in UserList)
                {
                    if (use.IdUser == user.IdUser && use.Parola == user.Parola)
                    {
                        startWindow(use);
                    }
                }
            }
        }

        public void startWindow(User user)
        {
            switch (user.RolUs.IdRol)
            {
                case 1:
                    Admin adminWin = new Admin();
                    adminWin.Show();
                    break;
            }
        }

        private ICommand checkCommand;
        public ICommand CheckCommand
        {
            get
            {
                if (checkCommand == null)
                {
                    checkCommand = new RelayCommand<User>(CheckUser);
                }
                return checkCommand;
            }
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
