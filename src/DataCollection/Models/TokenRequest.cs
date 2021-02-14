using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection.Models
{
    public class TokenRequest
    {
        /// <summary>
        /// Portal Username
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Portal Password
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
