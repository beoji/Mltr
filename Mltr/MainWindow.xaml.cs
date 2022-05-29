using Mltr.Serializers;
using Mltr.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mltr;

public partial class MainWindow : Window
{
    ProductService service;

    public MainWindow()
    {
        var fileName = "light_obce.xml";
        var serializer = new XmlProductSerializer();

        service = new ProductService(fileName, serializer);

        InitializeComponent();
    }

    private void ButtonAddName_Click(object sender, RoutedEventArgs e)
    {
        var l = service.ConvertToList();

        foreach(var item in l)
        {
            lstNames.Items.Add(item);
        }
    }
}
