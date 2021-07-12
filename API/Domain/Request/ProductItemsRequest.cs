using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Request
{
    public class ProductItemsRequest
    {
        public ProductItemsRequest()
        {
        }

        [JsonPropertyName("product_id")]
        public long Product_id { get; set; }

        [JsonPropertyName("pricing_schema")]
        public PricingSchemaRequest PricingSchema { get; set; }
    }
}