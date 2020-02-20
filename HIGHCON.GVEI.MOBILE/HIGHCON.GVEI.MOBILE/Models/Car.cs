using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HIGHCON.GVEI.MOBILE.Models
{
   public class Car
    {
        [JsonProperty("id")]
        public int id { get; set; }


        public string placa { get; set; }

        [JsonProperty("ano")]
        public string ano { get; set; }

        [JsonProperty("modelo")]
        public string Modelo { get; set; }

        [JsonProperty("dataDaCompra")]
        public DateTime DataCompra { get; set; }

        [JsonProperty("dataDaVenda")]
        public DateTime DataVenda { get; set; }

     
        public decimal valorCompra { get; set; }

        public decimal valorVenda { get; set; }

        
        public string cor { get; set; }

     
        public string veiculo { get; set; }
    }
}
