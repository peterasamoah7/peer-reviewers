using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class MainSentence
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }
}
