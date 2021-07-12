using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Response
{
    public class AssinaturaResponse
    {
        [JsonPropertyName("subscription")]
        public Subscription Subscription { get; set; }

        [JsonPropertyName("bill")]
        public Bill Bill { get; set; }
    }
}