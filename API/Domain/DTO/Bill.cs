using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class Bill
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("code")]
        public object Code { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("installments")]
        public long Installments { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("billing_at")]
        public object BillingAt { get; set; }

        // aceitar null
        [JsonPropertyName("due_at")]
        public DateTimeOffset? Due_At { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset Created_At { get; set; }

        [JsonPropertyName("charges")]
        public List<Charge> Charges { get; set; }

        [JsonPropertyName("payment_profile")]
        public object PaymentProfile { get; set; }
    }
}