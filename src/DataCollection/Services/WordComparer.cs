using DataCollection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Services
{
    public class WordComparer : IEqualityComparer<Word>
    {
        /// <summary>
        /// Compare word str
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool Equals(Word x, Word y)
        {
            return x.Value.Equals(y.Value, StringComparison.OrdinalIgnoreCase); 
        }

        /// <summary>
        /// Get Object hashcode
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(Word obj)
        {
            return obj.Value.GetHashCode(); 
        }
    }
}
