using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HIGHCON.GVEI.MOBILE.Models
{
   public class CarDetail
    {
        public int veiculo { get; set; }

        public int marca { get; set; }

        public int ano { get; set; }

        public int placa { get; set; }

        public int cor { get; set; }

        public int valorCompra { get; set; }

        public int valorVenda { get; set; }

        public int Chassis { get; set; }

        public int dat_compra { get; set; }

        public int cpf_cnpj_fornec { get; set; }

        public int cpf_cnpj_cli { get; set; }

        public int c { get; set; }

        public int desc_desp1 { get; set; }

        public int vlr_desp2 { get; set; }

        public int desc_desp2 { get; set; }

        public int vlr_desp3 { get; set; }

        public int desc_desp3 { get; set; }

        public int vlr_desp4 { get; set; }

        public int desc_desp4 { get; set; }

    }
}
