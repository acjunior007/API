using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Response
{
    public class ListCustomers
    {
        public ListCustomers()
        {
            this.Customers = new List<Customer>();
        }

        [JsonPropertyName("customers")]
        public List<Customer> Customers { get; set; }
    }
}