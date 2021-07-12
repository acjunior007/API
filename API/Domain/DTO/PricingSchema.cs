using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class PricingSchema
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("short_format")]
        public string Short_format { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("minimum_price")]
        public string Minimum_Price { get; set; }

        [JsonPropertyName("schema_type")]
        public string Schema_type { get; set; }

        [JsonPropertyName("pricing_ranges")]
        public List<PricingRanges> Pricing_ranges { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset Created_At { get; set; }
    }
}