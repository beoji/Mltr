using Mltr.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mltr.Serializers;

public class JsonProductSerializer : IProductSerializer
{
    public List<Product> Deserialize(string path)
    {
        throw new NotImplementedException();
    }
}

