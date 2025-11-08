using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("gram")]
        public double Gram { get; set; }

        [JsonProperty("kilogram")]
        public double Kilogram { get; set; }

        [JsonProperty("ounce")]
        public double Ounce { get; set; }

        [JsonProperty("lastUpdated")]
        public int LastUpdated { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
