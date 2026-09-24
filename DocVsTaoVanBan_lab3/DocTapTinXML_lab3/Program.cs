using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DocTapTinXML_lab3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("..\\..\\books.xml");
            var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");
            foreach(XmlNode node in nodeList)
            {
                var isbn = node.Attributes["ISBN"].Value;
                var title = node.SelectSingleNode("title").InnerText;
                var price = node.SelectSingleNode("price").InnerText;
                var firstName = node.SelectSingleNode("author/first-name").InnerText;
                var lastName = node.SelectSingleNode("author/last-name").InnerText;
                Console.WriteLine("{0,-15}{1,-50}{2,-15}{3,-15}{4,6}", isbn, title, firstName, lastName, price);

            }
        }
    }
}
