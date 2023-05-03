using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace drug_store.Controller.Database
{
    public class Database
    {
        public string connectionString { get; set; }
        public Database() {
            string debugPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(Directory.GetParent(debugPath).FullName).FullName;
            string configPath = Path.Combine(
                projectPath,
                "config.xml"
                );
            XmlDocument xml = new XmlDocument();
            xml.Load(configPath);
            XmlNodeList nodeL = xml.GetElementsByTagName("datasource");
            foreach(XmlNode node  in nodeL)
            {
                string db = node.SelectSingleNode("database").InnerText;
                connectionString = Path.Combine(
                    projectPath,
                    db
                    );
            }
        }
    }
}
