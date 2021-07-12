using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class ProductItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("uses")]
        public int Uses { get; set; }

        [JsonPropertyName("cycles")]
        public string Cycles { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset Created_at { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset Updated_at { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("pricing_schema")]
        public PricingSchema Pricing_Schema { get; set; }
    }
}