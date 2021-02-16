using DataCollection.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class KeyWords
    {
        /// <summary>
        /// Key Topics
        /// </summary>
        public HashSet<Word> Topics { get; set; } = new HashSet<Word>(new WordComparer());

        /// <summary>
        /// Key Phrases
        /// </summary>
        public HashSet<Word> Phrases { get; set; } = new HashSet<Word>(new WordComparer());
    }
}
