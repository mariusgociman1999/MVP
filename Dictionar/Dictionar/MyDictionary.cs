using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows;

namespace Dictionar
{
    public class MyDictionary
    {
        Dictionary<string, Dictionary<string, Word>> myDictionary 
        { get; set; }

        public void WriteFile()
        {
            using (XmlWriter writer = XmlWriter.Create("dictionary.xml"))
            {
                bool isEmpty = myDictionary.Count == 0;
                if (!isEmpty)
                {
                    writer.WriteStartElement("dictionary");
                    foreach (KeyValuePair<string, Dictionary<string, Word>> category in myDictionary)
                    {
                        foreach (KeyValuePair<string, Word> word in category.Value)
                        {
                            writer.WriteStartElement("word");
                            writer.WriteElementString("category", category.Key);
                            writer.WriteElementString("name", word.Key);
                            writer.WriteElementString("definition", word.Value.definition);
                            writer.WriteElementString("image", word.Value.imagePath);
                            writer.WriteEndElement();
                        }
                    }
                    writer.WriteEndElement();
                    writer.Flush();
                }
                else
                {
                    MessageBox.Show("The dictionary is empty. Please add some words and categories.");
                }
            }
        }
    }
}
