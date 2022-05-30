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
    string _filename;
    IProductSerializer _serializer;

    public ProductService(string filename, IProductSerializer serializer)
    {
        _filename = filename;
        _serializer = serializer;
    }

    public List<Product> ConvertToList()
    {
        string workingDirectory = Environment.CurrentDirectory;
        string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        string filePath = path + "/" + _filename;

        return _serializer.Deserialize(filePath);
    }
}

