using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class GatewayResponseFields
    {
        [JsonPropertyName("nsu")]
        public string Nsu { get; set; }
    }
}