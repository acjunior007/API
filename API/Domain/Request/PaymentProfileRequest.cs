using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Request
{
    public class PaymentProfileRequest
    {
        [JsonPropertyName("gateway_token")]
        public Guid Gateway_token { get; set; }
    }
}