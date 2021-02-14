using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class KeyPhraseRequest
    {
        /// <summary>
        /// Document wrapper model
        /// </summary>
        [JsonProperty("document")]
        public Document Document { get; set; }
    }

    public class Document
    {
        /// <summary>
        /// Text content
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
