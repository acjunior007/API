using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class Gateway
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("connector")]
        public string Connector { get; set; }
    }
}