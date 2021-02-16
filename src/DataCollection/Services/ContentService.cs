using DataCollection.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UglyToad.PdfPig;

namespace DataCollection.Services
{
    public class ContentService
    {
        private int PageSearchLimit = 10; 

        public ContentService() { }

        /// <summary>
        /// Extract Text from Pdf
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public List<string> GetText(byte[] file)
        {
            var content = new List<string>();

            using (var document = PdfDocument.Open(file))
            {
                ///Limit page data extraction to 5 pages or less if less
                int numberOfPages = document.NumberOfPages
                    > PageSearchLimit ? PageSearchLimit : document.NumberOfPages; 

                ///Loop and build content for each page
                for(int i = 1; i <= document.NumberOfPages; i++)
                {
                    var builder = new StringBuilder();
                    var page = document.GetPage(i); 
                    foreach (var word in page.GetWords())
                    {
                        builder.Append($"{word.Text} ");
                    }
                    content.Add(builder.ToString());
                }
            }
            return content;
        }

        /// <summary>
        /// Get Keywords from API Response
        /// </summary>
        /// <param name="keyPhrases"></param>
        /// <returns></returns>
        public KeyWords GetKeyWords(List<KeyPhraseReponse> keyPhrases)
        {
            var keyWords = new KeyWords();

            foreach(var item in keyPhrases)
            {
                ///Get the top scoring topics and phrase from each batch
                var topics = item.Data.Topics
                    .OrderByDescending(x => x.Score)
                    .Take(1);
                var phrases = item.Data.MainPhrases
                    .OrderByDescending(x => x.Score)
                    .Take(1);

                ///Add top topics to keywords list
                foreach (var topic in topics)
                {
                    keyWords.Topics.Add(
                        new Word(topic.Label, topic.Score));
                }

                ///Add top phrases to keywords list
                foreach (var phrase in phrases)
                {
                    keyWords.Phrases.Add(
                        new Word(phrase.Value, phrase.Score));
                }
            }

            return keyWords; 
        }
    }


}
