using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class KeyWords
    {
        public HashSet<string> Topics { get; set; } = new HashSet<string>();

        public HashSet<string> Phrases { get; set; } = new HashSet<string>();
    }
}
