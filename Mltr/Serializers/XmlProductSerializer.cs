using Mltr.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace Mltr.Serializers;

public class XmlProductSerializer : IProductSerializer
{
    public List<Product> Deserialize(string path)
    {
        List<Product> l = new List<Product>();

        XmlDocument doc = new XmlDocument();
        doc.Load(path);

        XmlNode root = doc.DocumentElement;

        foreach (XmlNode node in root)
        {
            l.Add(DeserializeProduct(node));
        }

        return l;
    }

    private Product DeserializeProduct(XmlNode node)
    {
        List<Image> images = new List<Image>();

        foreach (XmlElement item in node["zdjecia"].ChildNodes)
        {
            images.Add(new Image() { url = item.InnerText });
        }

        return new Product()
        {
            Id = Convert.ToInt32(node["id"].InnerText),
            Name = node["nazwa"].InnerText,
            LongDescription = node["dlugi_opis"].InnerText,
            TechnicalData = node["dane_techniczne"].InnerText,
            Weight = float.Parse(node["waga"].InnerText, CultureInfo.InvariantCulture.NumberFormat),
            Images = images,
            Code = node["kod"].InnerText,
            Ean = node["ean"].InnerText,
            Status = node["status"].InnerText,
            Type = node["typ"].InnerText,
            WholesalePrice = Convert.ToDecimal(node["cena_zewnetrzna_hurt"].InnerText, CultureInfo.InvariantCulture.NumberFormat),
            ExternalPrice = Convert.ToDecimal(node["cena_zewnetrzna"].InnerText, CultureInfo.InvariantCulture.NumberFormat),
            Tax = Convert.ToDecimal(node["vat"].InnerText, CultureInfo.InvariantCulture.NumberFormat),
            NumberOfVariants = Convert.ToInt32(node["ilosc_wariantow"].InnerText)
        };
    }
}

