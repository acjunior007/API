using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO
{
    public class PricingRanges
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_quantity")]
        public int Start_quantity { get; set; }

        [JsonProperty("end_quantity")]
        public int End_quantity { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("overage_price")]
        public decimal Overage_price { get; set; }
    }
}