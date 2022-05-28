using Mltr.Domain;
using System.Xml;

namespace Mltr.Serializers
{
    internal interface ISerializer
    {
        Product Deserialize(XmlNode node);
    }
}
