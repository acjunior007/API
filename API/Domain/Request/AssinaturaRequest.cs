using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Request
{
    public class AssinaturaRequest
    {
        [JsonPropertyName("start_at")]
        public string Start_at { get; set; }

        [JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        [JsonPropertyName("customer_id")]
        public long CustomerId { get; set; }

        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        [JsonPropertyName("installments")]
        public int Installments { get; set; }

        [JsonPropertyName("payment_method_code")]
        public string PaymentMethodCode { get; set; }

        [JsonPropertyName("payment_profile")]
        public PaymentProfileRequest PaymentProfileRequest { get; set; }

        [JsonPropertyName("product_items")]
        public List<ProductItemsRequest> ProductItems { get; set; }
    }
}