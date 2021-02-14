using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class KeyPhraseData
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("topics")]
        public List<Topic> Topics { get; set; }

        [JsonProperty("mainPhrases")]
        public List<MainPhrase> MainPhrases { get; set; }

        [JsonProperty("mainSentences")]
        public List<MainSentence> MainSentences { get; set; }

        [JsonProperty("mainSyncons")]
        public List<MainSyncon> MainSyncons { get; set; }

        [JsonProperty("mainLemmas")]
        public List<MainLemma> MainLemmas { get; set; }
    }
}
