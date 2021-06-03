using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace School.Views
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AddElev_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddProf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddSubj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddSpecial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModElev_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModProf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModSubj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModSpecial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddRol_Click(object sender, RoutedEventArgs e)
        {
            AddRol rolWin = new AddRol();
            rolWin.Show();
        }

        private void AddUserBt_Click(object sender, RoutedEventArgs e)
        {
            AddUser addUsWin = new AddUser();
            addUsWin.Show();
        }

        private void AddSpecialBt_Click(object sender, RoutedEventArgs e)
        {
            AddSpecial addSpecWin = new AddSpecial();
            addSpecWin.Show();
        }

        private void AddClasaBt_Click(object sender, RoutedEventArgs e)
        {
            AddClasa addClsWin = new AddClasa();
            addClsWin.Show();
        }
    }
}
