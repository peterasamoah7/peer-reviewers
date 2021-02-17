using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Models
{
    public class ReviewerResult
    {
        /// <summary>
        /// Reviewer Data
        /// </summary>
        public Data Data { get; set; }

        /// <summary>
        /// File Location in Public blob
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Doc Similarity Score
        /// </summary>
        public decimal Score { get; set; }
    }
}
