using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlParser.Models
{
    public class CatalogItem
    {
        public string Gender { get; set; }

        public string ItemNumber { get; set; }

        public decimal Price { get; set; }

        public List<Size> Sizes { get; set; }
    }
}
