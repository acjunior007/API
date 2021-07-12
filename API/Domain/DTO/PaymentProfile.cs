using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.DTO
{
    public class PaymentProfile
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("holder_name")]
        public string HolderName { get; set; }

        [JsonPropertyName("registry_code")]
        public object RegistryCode { get; set; }

        [JsonPropertyName("bank_branch")]
        public object BankBranch { get; set; }

        [JsonPropertyName("bank_account")]
        public object BankAccount { get; set; }

        [JsonPropertyName("card_expiration")]
        public DateTimeOffset CardExpiration { get; set; }

        [JsonPropertyName("allow_as_fallback")]
        public object AllowAsFallback { get; set; }

        [JsonPropertyName("card_number_first_six")]
        [Newtonsoft.Json.JsonConverter(typeof(ParseStringConverter))]
        public string CardNumberFirstSix { get; set; }

        [JsonPropertyName("card_number_last_four")]
        [Newtonsoft.Json.JsonConverter(typeof(ParseStringConverter))]
        public string CardNumberLastFour { get; set; }

        [JsonPropertyName("token")]
        public Guid Token { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("payment_company")]
        public Customer PaymentCompany { get; set; }
    }

    internal class ParseStringConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}