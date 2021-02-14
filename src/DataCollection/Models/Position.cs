using Newtonsoft.Json;

namespace DataCollection.Models
{
    public class Position
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }
}
