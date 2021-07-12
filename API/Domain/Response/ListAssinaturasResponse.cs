using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Response
{
    public class ListAssinaturasResponse
    {
        [JsonPropertyName("subscriptions")]
        public List<Subscription> Subscriptions { get; set; }
    }
}