using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class Word
    {
        public Word() { }

        public Word(string value, decimal score)
        {
            this.Value = value;
            this.Score = score; 
        }

        /// <summary>
        /// Word string
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Word Score
        /// </summary>
        public decimal Score { get; set; }
    }
}
