using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class CurrentPeriod
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("billing_at")]
        public DateTimeOffset Billing_At { get; set; }

        [JsonPropertyName("cycle")]
        public long Cycle { get; set; }

        [JsonPropertyName("start_at")]
        public DateTimeOffset Start_At { get; set; }

        [JsonPropertyName("end_at")]
        public DateTimeOffset End_At { get; set; }

        [JsonPropertyName("duration")]
        public long Duration { get; set; }
    }
}