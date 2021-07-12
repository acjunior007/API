using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class Product
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}