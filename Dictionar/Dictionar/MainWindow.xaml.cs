using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Forms = System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Dictionar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string defaultPath = "..\\Images\\NoImage.jpg";
        public static string defaultDirectory = "..\\Images\\";
        public static string defaultCategory = "All Categories";
        public Stack<int> indexes = new Stack<int>();
        public int score = 0;
        public int count = 0;

        MyDictionary dictionary;

        public MainWindow()
        {
            dictionary = new MyDictionary();
            DataContext = dictionary;
            InitializeComponent();
        }

        private void DictMain_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Dictionary.Visibility = Visibility.Visible;
        }

        private void GameMain_Click(object sender, RoutedEventArgs e)
        {
            GetRandom();
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
            score = 0;
            Score.Content = score.ToString();
            indexes.Clear();
            count = 0;
            Reset();
            GetRandom();
        }

        private void DeleteCategory_Click(object sender, RoutedEventArgs e)
        {
            if (AdminComboCat.Text != "" && dictionary.RemoveCategory(AdminComboCat.Text))
            {
                MessageBox.Show("Category removed", "Message");
                dictionary.WriteFile();
                Refresh();
            }
        }

        private void AddCategAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (AdminComboCat.Text != "" && !dictionary.MyDict.ContainsKey(AdminComboCat.Text))
            {
                dictionary.AddCategory(AdminComboCat.Text);
                MessageBox.Show("Category added", "Message");
                AdminComboCat.Text = "";
                dictionary.WriteFile();
                Refresh();
            }
        }

        private void DeleteWord_Click(object sender, RoutedEventArgs e)
        {
            if (AdminComboCat.Text != "")
            {
                dictionary.RemoveWord(AdminComboCat.Text, AdminCombo.Text);
                MessageBox.Show("Word removed", "Message");
                dictionary.WriteFile();
                Refresh();
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a category, or insert a word and/or a definition.", "Warning");
            }
        }

        private void AddWordAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (AdminComboCat.Text != "" && dictionary.MyDict.ContainsKey(AdminComboCat.Text) && AdminCombo.Text != "" && AdminText.Text != "")
            {
                string source;
                if (AdminImage.Source != null)
                {
                    source = AdminImage.Source.ToString();
                }
                else
                {
                    source = defaultPath;
                }
                dictionary.AddWord(AdminComboCat.Text, new Word(AdminCombo.Text, AdminText.Text, source));
                AdminComboCat.Text = "";
                AdminCombo.Text = "";
                AdminText.Text = "";
                MessageBox.Show("Word added", "Message");
                dictionary.WriteFile();
                Refresh();
            }
            else
            {
                MessageBox.Show("Please select a category, or insert a word and/or a definition.", "Warning");
            }
        }

        private void DeleteDefinition_Click(object sender, RoutedEventArgs e)
        {
            if (AdminText.Text != "")
            {
                AdminText.Text = "";
            }
        }

        private void UpdateDefAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (AdminComboCat.Text != "" && dictionary.MyDict.ContainsKey(AdminComboCat.Text) && AdminCombo.Text != "" && AdminText.Text != "")
            {
                dictionary.UpdateDef(AdminComboCat.Text, AdminCombo.Text, AdminText.Text);
            }
            else
            {
                MessageBox.Show("Definition cannot be blank.", "Warning");
            }
        }

        private void DeleteImage_Click(object sender, RoutedEventArgs e)
        {
            if (AdminImage.Source != null)
            {
                dictionary.MyDict[AdminComboCat.Text].Find(n => n.Name == AdminCombo.Text).ImagePath = defaultPath;
                dictionary.WriteFile();
                Refresh();
            }
        }

        private void ChooseImageAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (AdminComboCat.Text != "" && dictionary.MyDict.ContainsKey(AdminComboCat.Text) && AdminCombo.Text != "" && AdminText.Text != "")
            {
                using (Forms.OpenFileDialog openFileDialog = new Forms.OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    string newPath, oldPath;

                    if (openFileDialog.ShowDialog() == Forms.DialogResult.OK)
                    {
                        oldPath = openFileDialog.FileName;
                        newPath = defaultDirectory + Path.GetFileName(openFileDialog.FileName);
                        if (oldPath != Path.GetFullPath(newPath))
                        {
                            File.Copy(oldPath, newPath, true);
                        }
                        dictionary.SetPath(AdminComboCat.Text, AdminCombo.Text, newPath);
                        dictionary.WriteFile();
                        Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category, or insert a word and/or a definition.", "Warning");
            }
        }

        private void Refresh()
        {
            DataContext = null;
            DataContext = dictionary;
        }

        private void GetRandom()
        {
            int num = new Random().Next(dictionary.MyDict[defaultCategory].Count);
            if (count < 5 && !indexes.Contains(num))
            {
                indexes.Push(num);
                Word word = dictionary.MyDict[defaultCategory][indexes.Peek()];
                int choice = new Random().Next(0, 2);
                if (choice == 0)
                {
                    GameLabel.Text = word.Definition;
                    ++count;
                }
                else if (choice == 1 && word.ImagePath != defaultPath)
                {
                    GameImage.Source = new BitmapImage(new Uri(Path.GetFullPath(word.ImagePath)));
                    ++count;
                }
                if (count == 5)
                {
                    NextGame.Content = "Finish";
                }
            }
            else if (count > 5)
            {
                MessageBox.Show(string.Format("Game Finished. Score is {0}", score), "Message");
            }
            else
            {
                GetRandom();
            }
        }

        private void Reset()
        {
            GameEntry.Text = "";
            GameLabel.Text = "";
            GameImage.Source = null;
            Feed.Content = "";
        }

        private void NextGame_Click(object sender, RoutedEventArgs e)
        {
            _ = Check();
            Reset();
            GetRandom();
        }

        public async Task Check()
        {
            if (dictionary.MyDict[defaultCategory][indexes.Peek()].Name == GameEntry.Text)
            {
                Score.Content = Convert.ToString(++score);
                Feed.Content = "CORRECT";
            }
            else
            {
                Feed.Content = "INCORRECT";
            }
            await Task.Delay(2000);
        }
    }
}
