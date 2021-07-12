using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class Subscription
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("start_at")]
        public DateTimeOffset Start_At { get; set; }

        [JsonPropertyName("end_at")]
        public object End_At { get; set; }

        [JsonPropertyName("next_billing_at")]
        public DateTimeOffset? Next_Billing_At { get; set; }

        [JsonPropertyName("overdue_since")]
        public object OverdueSince { get; set; }

        [JsonPropertyName("code")]
        public object Code { get; set; }

        [JsonPropertyName("cancel_at")]
        public object CancelAt { get; set; }

        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        [JsonPropertyName("interval_count")]
        public int Interval_Count { get; set; }

        [JsonPropertyName("billing_trigger_type")]
        public string Billing_Trigger_Type { get; set; }

        [JsonPropertyName("billing_trigger_day")]
        public long BillingTriggerDay { get; set; }

        [JsonPropertyName("billing_cycles")]
        public object BillingCycles { get; set; }

        [JsonPropertyName("installments")]
        public long Installments { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset Created_At { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset Updated_At { get; set; }

        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        [JsonPropertyName("plan")]
        public Plan Plan { get; set; }

        [JsonPropertyName("product_items")]
        public List<ProductItem> Product_Items { get; set; }

        [JsonPropertyName("payment_method")]
        public PaymentMethod Payment_Method { get; set; }

        [JsonPropertyName("current_period")]
        public CurrentPeriod Current_Period { get; set; }

        [JsonPropertyName("payment_profile")]
        public object PaymentProfile { get; set; }

        [JsonPropertyName("invoice_split")]
        public bool InvoiceSplit { get; set; }
    }
}