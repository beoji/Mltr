using Mltr.Domain;
using Mltr.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml;

namespace Mltr.Services;
internal class ProductService
{
    string path = String.Empty;
    public ProductService(string path)
    {
        this.path = path;
    }
    public void ConvertToXLS(ListBox list)
    {
        string workingDirectory = Environment.CurrentDirectory;
        string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        XmlDocument doc = new XmlDocument();
        doc.Load(path + "/light_obce.xml");

        XmlNode root = doc.DocumentElement;

        ISerializer serializer = new XmlSerializer();

        foreach (XmlNode node in root)
        {
            list.Items.Add(serializer.Deserialize(node));
        }
    }
}

