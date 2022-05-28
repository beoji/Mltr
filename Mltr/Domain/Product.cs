using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mltr.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? LongDescription { get; set; }
        public string? TechnicalData { get; set; }
        public float? Weight { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public string? Code { get; set; }
        public string? Ean { get; set; }
        public string? Status { get; set; }
        public string Type { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal ExternalPrice { get; set; }
        public decimal Tax { get; set; }
        public int NumberOfVariants { get; set; }
        public int GrossMargin { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
