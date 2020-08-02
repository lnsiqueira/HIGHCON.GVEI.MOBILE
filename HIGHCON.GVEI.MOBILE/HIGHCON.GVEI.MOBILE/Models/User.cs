using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HIGHCON.GVEI.MOBILE.Models
{
    public class User
    {
       // [JsonProperty("usuario")]
        public string usuario { get; set; }

        //[JsonProperty("nome")]
        public string nome { get; set; }

        //[JsonProperty("perfil")]
        public string perfil { get; set; }

        //[JsonProperty("senha")]
        public string senha { get; set; }

    }
}
