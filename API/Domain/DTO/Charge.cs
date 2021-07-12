using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class Charge
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("due_at")]
        public DateTimeOffset Due_At { get; set; }

        [JsonPropertyName("paid_at")]
        public string Paid_At { get; set; }

        [JsonPropertyName("installments")]
        public long Installments { get; set; }

        [JsonPropertyName("attempt_count")]
        public long AttemptCount { get; set; }

        [JsonPropertyName("next_attempt")]
        public object NextAttempt { get; set; }

        [JsonPropertyName("print_url")]
        public object PrintUrl { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset Created_At { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset Updated_At { get; set; }

        [JsonPropertyName("last_transaction")]
        public LastTransaction Last_Transaction { get; set; }

        [JsonPropertyName("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }
    }
}