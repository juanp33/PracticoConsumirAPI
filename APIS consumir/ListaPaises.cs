
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Api
{
    public class ListaPaises
    {
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public long? Success { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result[] Result { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("country_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryKey { get; set; }

        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        [JsonProperty("country_iso2", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIso2 { get; set; }

        [JsonProperty("country_logo", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CountryLogo { get; set; }
    }
}



