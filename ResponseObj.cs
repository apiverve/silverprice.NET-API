using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("currency")]
    public string currency { get; set; }

    [JsonProperty("gram")]
    public double gram { get; set; }

    [JsonProperty("kilogram")]
    public double kilogram { get; set; }

    [JsonProperty("ounce")]
    public double ounce { get; set; }

    [JsonProperty("lastUpdated")]
    public int lastUpdated { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
