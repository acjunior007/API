using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class LastTransaction
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("installments")]
        public long Installments { get; set; }

        [JsonPropertyName("gateway_message")]
        public string Gateway_Message { get; set; }

        [JsonPropertyName("gateway_response_code")]
        public object Gateway_Response_Code { get; set; }

        [JsonPropertyName("gateway_authorization")]
        public string Gateway_Authorization { get; set; }

        [JsonPropertyName("gateway_transaction_id")]
        public Guid Gateway_TransactionId { get; set; }

        [JsonPropertyName("gateway_response_fields")]
        public GatewayResponseFields Gateway_Response_Fields { get; set; }

        [JsonPropertyName("fraud_detector_score")]
        public object Fraud_Detector_Score { get; set; }

        [JsonPropertyName("fraud_detector_status")]
        public object Fraud_Detector_Status { get; set; }

        [JsonPropertyName("fraud_detector_id")]
        public object Fraud_Detector_Id { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("gateway")]
        public Gateway Gateway { get; set; }

        [JsonPropertyName("payment_profile")]
        public PaymentProfile PaymentProfile { get; set; }
    }
}