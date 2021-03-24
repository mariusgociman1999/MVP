using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace Dictionar
{
    public class MyDictionary : INotifyPropertyChanged
    {
        static string filePath = "..\\Resources\\dictionary.xml";
        public static string defaultPath = "..\\Images\\NoImage.jpg";
        public static string defaultCategory = "All Categories";

        public SortedDictionary<string, List<Word>> _MyDict;
        public SortedDictionary<string, List<Word>> MyDict
        {
            get { return _MyDict; }
            set
            {
                if (value != _MyDict)
                {
                    _MyDict = value;
                    NotifyPropertyChanged();
                }
            }
        }

        XmlWriterSettings settings;

        public event PropertyChangedEventHandler PropertyChanged;

        public MyDictionary()
        {
            Init();
        }

        public void Init()
        {
            MyDict = new SortedDictionary<string, List<Word>>();
            settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            ReadFile();

        }

        public void ReadFile()
        {
            string category = "", name = "", def = "", path = "";
            bool change = false;
            Word newWord;
            XmlReader reader;
            if (File.Exists(filePath) && new FileInfo(filePath).Length != 0)
            {
                reader = XmlReader.Create(filePath);
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "category":
                                category = reader.ReadString();
                                break;
                            case "name":
                                name = reader.ReadString();
                                break;
                            case "definition":
                                def = reader.ReadString();
                                break;
                            case "image":
                                path = reader.ReadString();
                                change = true;
                                break;
                            default:
                                category = "";
                                name = "";
                                def = "";
                                path = defaultPath;
                                break;

                        }
                        if (category != "" && name != "" && def != "")
                        {

                            if (!MyDict.ContainsKey(category))
                            {
                                MyDict[category] = new List<Word>();
                            }

                            newWord = new Word(name, def, path);

                            if (!MyDict[category].Any(n => n.Name == newWord.Name))
                            {
                                MyDict[category].Add(newWord);
                            }

                            if (change)
                            {
                                MyDict[category].Find(n => n.Name == newWord.Name).ImagePath = path;
                            }

                            if (!MyDict.ContainsKey(defaultCategory))
                            {
                                MyDict[defaultCategory] = new List<Word>();
                            }

                            if (!MyDict[defaultCategory].Any(n => n.Name == newWord.Name))
                            {
                                MyDict[defaultCategory].Add(newWord);
                            }
                            
                        }
                    }
                }
                MyDict[category].Sort();
                MyDict[defaultCategory].Sort();
                reader.Close();
            }
            else
            {
                CreateFile();
            }
        }

        internal bool RemoveCategory(string cat)
        {
            if (MyDict.Remove(cat))
            {
                NotifyPropertyChanged();
                return true;
            }
            return false;
        }

        internal void RemoveWord(string cat, string wrd)
        {
            MyDict[cat].RemoveAll(n => n.Name == wrd);
            NotifyPropertyChanged();
        }

        internal void UpdateDef(string cat, string word, string def)
        {
            if (MyDict[cat].Any(n => n.Name == word))
            {
                MyDict[cat].Find(n => n.Name == word).Definition = def;
                NotifyPropertyChanged();
            }
            else
            {
                MessageBox.Show("Add the word first.", "Warning");
            }
        }

        internal void AddWord(string cat, Word word)
        {
            MyDict[cat].Add(word);
            MyDict[cat].Sort();
            MyDict[defaultCategory].Add(word);
            MyDict[defaultCategory].Sort();
            NotifyPropertyChanged();
        }

        public void CreateFile()
        {
            XmlWriter writer = XmlWriter.Create(filePath, settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("dictionary");

            writer.WriteStartElement("word");
            writer.WriteElementString("category", "");
            writer.WriteElementString("name", "");
            writer.WriteElementString("definition", "");
            writer.WriteElementString("image", "");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        internal void SetPath(string cat, string word, string path)
        {
            MyDict[cat].Find(n => n.Name == word).ImagePath = path;
            NotifyPropertyChanged();
        }

        public void WriteFile()
        {
            XmlWriter writer = XmlWriter.Create(filePath, settings);
            bool isEmpty = MyDict.Count == 0;
            if (!isEmpty)
            {
                writer.WriteStartElement("dictionary");
                foreach (KeyValuePair<string, List<Word>> category in MyDict)
                {
                    foreach (Word word in category.Value)
                    {
                        if (category.Key != defaultCategory)
                        {
                            writer.WriteStartElement("word");
                            writer.WriteElementString("category", category.Key);
                            writer.WriteElementString("name", word.Name);
                            writer.WriteElementString("definition", word.Definition);
                            writer.WriteElementString("image", word.ImagePath);
                            writer.WriteEndElement();
                        }
                    }
                }
                writer.WriteEndDocument();
                writer.Close();
            }
            else
            {
                MessageBox.Show("The dictionary is empty. Please add some words and categories.", "Warning");
                writer.Close();
            }
        }

        public void AddCategory(string cat)
        {
            MyDict[cat] = new List<Word>();
            NotifyPropertyChanged();
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
