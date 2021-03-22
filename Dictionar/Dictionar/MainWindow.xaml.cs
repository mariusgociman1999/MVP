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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dictionar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DictMain_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Dictionary.Visibility = Visibility.Visible;
        }

        private void GameMain_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Game.Visibility = Visibility.Visible;
        }

        private void AdminMain_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Admin.Visibility = Visibility.Visible;
        }

        private void BackAdmin_Click(object sender, RoutedEventArgs e)
        {
            Admin.Visibility = Visibility.Hidden;
            Main.Visibility = Visibility.Visible;
        }

        private void BackSearch_Click(object sender, RoutedEventArgs e)
        {
            Dictionary.Visibility = Visibility.Hidden;
            Main.Visibility = Visibility.Visible;
        }

        private void BackGame_Click(object sender, RoutedEventArgs e)
        {
            Game.Visibility = Visibility.Hidden;
            Main.Visibility = Visibility.Visible;
        }

        private void RestartGame_Click(object sender, RoutedEventArgs e)
        {
            NextGame.Content = "Next";
        }
    }
}
