using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class Phone
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("phone_type")]
        public string Phone_Type { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("extension")]
        public object Extension { get; set; }
    }
}