using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Notebook
{
    class NotebookFile
    {

        // Making new files
        public static bool newFile(string bodyInfo = " ") // Optional argument for when creating a new file 
        {
            string newFileName = "";
            string newFileTitle = "";
            newFileEntry nf = new newFileEntry();

            if (nf.ShowDialog() == DialogResult.OK)
            {
                newFileName = nf.fileName + ".xml";
                newFileTitle = nf.fileTitle;
                
                using (XmlWriter writer = XmlWriter.Create(newFileName))
                {
                    writer.WriteStartElement("entry");
                    writer.WriteElementString("title", newFileTitle);
                    writer.WriteElementString("dateCreated", Convert.ToString(DateTime.Now));
                    writer.WriteElementString("body", bodyInfo);
                    writer.WriteEndElement();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        // Reading files
        public static bool readFile(ref string titleTxt, ref string date, ref string fileName, ref string body)
        // This should be changed to an object that contains all of these values instead of each individually
        // Code will be much easier to manage that way
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            
            titleTxt = file.FileName;
            if (titleTxt == "")
            {
                return false; // Exits if no titleTxt is provided. Happens when the user exits the file browser
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(titleTxt);

            XmlNode titleNode = doc.DocumentElement.SelectSingleNode("title");
            XmlNode dateNode = doc.DocumentElement.SelectSingleNode("dateCreated");
            XmlNode bodyNode = doc.DocumentElement.SelectSingleNode("body");

            titleTxt = titleNode.InnerText;
            date = dateNode.InnerText;
            fileName = file.FileName;
            body = bodyNode.InnerText;
            return true;
        }

        // Saving files: Updating files
        public static void saveFile(string bodyText, string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlNode bodyNode = doc.DocumentElement.SelectSingleNode("body");
            bodyNode.InnerText = bodyText;

            doc.Save(fileName);
        }

    }
}
