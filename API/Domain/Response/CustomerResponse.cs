using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Response
{
    public class CustomerResponse
    {
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    }
}