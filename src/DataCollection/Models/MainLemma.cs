using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class MainLemma
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }

        [JsonProperty("positions")]
        public List<Position> Positions { get; set; }
    }
}
