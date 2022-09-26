﻿using Newtonsoft.Json;

namespace XmlParser.AutoGeneratedModels
{
    public class Product
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("product_image")]
        public string ProductImage { get; set; }

        [JsonProperty("catalog_item")]
        public List<CatalogItem> CatalogItem { get; set; }
    }
}
