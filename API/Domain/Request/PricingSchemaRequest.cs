using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Request
{
    public class PricingSchemaRequest
    {
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}