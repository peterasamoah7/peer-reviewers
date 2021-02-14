using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class MainSyncon
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }

        [JsonProperty("syncon")]
        public int Syncon { get; set; }

        [JsonProperty("positions")]
        public List<Position> Positions { get; set; }
    }
}
