using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DemoApplicationWeb_A.Models
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int book_id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize<Book>(this);
        }
    }
}
