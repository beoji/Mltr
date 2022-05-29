using Mltr.Domain;
using System.Collections.Generic;

namespace Mltr.Serializers;

public interface IProductSerializer
{
    List<Product> Deserialize(string path);
}
