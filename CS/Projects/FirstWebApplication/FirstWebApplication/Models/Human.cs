using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FirstWebApplication.Models
{
    public class Human
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("age")]
        public int age { get; set; }

        [JsonPropertyName("eyeColr")]
        public string eyeColor { get; set; }

        [JsonPropertyName("isAdult")]
        public bool isAdult { get; set; }

        [JsonPropertyName("height")]
        public float height { get; set; }

        [JsonPropertyName("picture")]
        public string picture { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Human>(this);
    }
}
