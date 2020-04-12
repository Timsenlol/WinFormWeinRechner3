using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace WeinRechnerWinForm.Business
{
    public static class XmlHelper
    {
        public static bool Read()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            using (FileStream fs = new FileStream("settings.xml", FileMode.Open, FileAccess.Read))
            {
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("zugestimmt");
                var retval = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                return Convert.ToBoolean(retval);
            }
               
         
    

           
        }

        internal static void WriteSettings(bool best)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("settings.xml");
            XmlNodeList aNodes = doc.SelectNodes("/settings");
            XmlNode val = aNodes[0];
            XmlElement ele =doc.CreateElement("zugestimmt");
            ele.InnerText = "true";

            val.ReplaceChild(ele, val.ChildNodes.Item(0));
            doc.Save("settings.xml");


        }
    }
}
