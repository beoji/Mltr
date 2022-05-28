using Mltr.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mltr.Serializers
{
    public class XmlSerializer : ISerializer
    {
        public Product Deserialize(XmlNode node)
        {
            List<Image> images = new List<Image>();

            foreach (XmlElement item in node["zdjecia"].ChildNodes)
            {
                images.Add(new Image() { url = item.InnerText});
            }

            //int Id = Convert.ToInt32(node["id"].InnerText);
            //string Name = node["nazwa"].InnerText;
            //string LongDescription = node["dlugi_opis"].InnerText;
            //string TechnicalData = node["dane_techniczne"].InnerText;
            //float Weight = float.Parse(node["waga"].InnerText, CultureInfo.InvariantCulture.NumberFormat);
            //List<Image> Images = images;
            //string Code = node["kod"].InnerText;
            //string Ean = node["ean"].InnerText;
            //string Status = node["status"].InnerText;
            //string Type = node["typ"].InnerText;
            //decimal WholesalePrice = Convert.ToDecimal(node["cena_zewnetrzna_hurt"].InnerText, CultureInfo.InvariantCulture.NumberFormat);
            //decimal ExternalPrice = Convert.ToDecimal(node["cena_zewnetrzna"].InnerText, CultureInfo.InvariantCulture.NumberFormat);
            //decimal Tax = Convert.ToDecimal(node["vat"].InnerText, CultureInfo.InvariantCulture.NumberFormat);
            //int NumberOfVariants = Convert.ToInt32(node["ilosc_wariantow"].InnerText);

            return new Product() 
                {
                    Id =                Convert.ToInt32(node["id"].InnerText),
                    Name =              node["nazwa"].InnerText,
                    LongDescription =   node["dlugi_opis"].InnerText,
                    TechnicalData =     node["dane_techniczne"].InnerText,
                    Weight =            float.Parse(node["waga"].InnerText, CultureInfo.InvariantCulture.NumberFormat),
                    Images =            images,
                    Code =              node["kod"].InnerText,
                    Ean =               node["ean"].InnerText,
                    Status =            node["status"].InnerText,
                    Type =              node["typ"].InnerText,
                    WholesalePrice =    Convert.ToDecimal(node["cena_zewnetrzna_hurt"].InnerText, CultureInfo.InvariantCulture.NumberFormat),
                    ExternalPrice =     Convert.ToDecimal(node["cena_zewnetrzna"].InnerText, CultureInfo.InvariantCulture.NumberFormat),
                    Tax =               Convert.ToDecimal(node["vat"].InnerText, CultureInfo.InvariantCulture.NumberFormat),
                    NumberOfVariants =  Convert.ToInt32(node["ilosc_wariantow"].InnerText)               
                };
        }
    }
}
