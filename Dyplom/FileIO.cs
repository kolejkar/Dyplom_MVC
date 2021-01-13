using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Dyplom
{
    public class FileIO
    {
        public List<LogicSymbol> logicSymbols;

        public FileIO()
        {
            logicSymbols = new List<LogicSymbol>();
        }

        public void LoadFromFile(string file)
        {
            XmlSerializer xml = new XmlSerializer(typeof(LogicSymbol));
            StreamReader reader = new StreamReader(file);
            LogicSymbol symbol = (LogicSymbol)xml.Deserialize(reader);
            reader.Close();
            logicSymbols.Add(symbol);
        }

        public void SaveToFile(string file, LogicSymbol symbol)
        {
            XmlSerializer xml = new XmlSerializer(typeof(LogicSymbol));
            FileStream temp = File.Create(file);
            xml.Serialize(temp, symbol);
            temp.Close();
        }

        public void LoadTemplates()
        {
            try
            {
                string path = HttpRuntime.AppDomainAppPath;
                string[] filenames = Directory.GetFiles(path+"/templates", "*.xml");
                foreach (string filename in filenames)
                {
                    LoadFromFile(filename);
                }
            }
            finally
            {

            }
        }
    }
}