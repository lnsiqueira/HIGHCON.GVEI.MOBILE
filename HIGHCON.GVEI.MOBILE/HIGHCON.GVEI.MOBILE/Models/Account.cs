using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HIGHCON.GVEI.MOBILE.Models
{
   public class Account
    {
       
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("photo")]
            public string Photo { get; set; }
        }
    
}
