using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HIGHCON.GVEI.MOBILE.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password{ get; set; }

    }
}
