using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class PaymentMethod
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("public_name")]
        public string Public_Name { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}