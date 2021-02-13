using Newtonsoft.Json;
using System.Collections.Generic;

namespace Search.Models
{
    public class SearchResult
    {
        /// <summary>
        /// Odata blob context
        /// </summary>
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        /// <summary>
        /// Results value
        /// </summary>
        [JsonProperty("value")]
        public List<SearchDetails> Value { get; set; }
    }

    public class SearchDetails
    {
        /// <summary>
        /// Score from Azure Search Service
        /// </summary>
        [JsonProperty("@search.score")]
        public decimal Score { get; set; }

        /// <summary>
        /// Metadata Storage Name (File name include ext.)
        /// </summary>
        [JsonProperty("metadata_storage_name")]
        public string Paper { get; set; }
    }
}
