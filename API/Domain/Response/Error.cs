using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Response
{
    public class Error
    {
        public Error()
        {
            this.Errors = new List<ResponseError>();
        }

        [JsonPropertyName("errors")]
        public List<ResponseError> Errors { get; set; }
    }
}