using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaRegimental.Models
{
    public class Cep
    {
        public Int32 Cod_cep { get; set; }
        public string Desc_cep { get; set; }
        public decimal Lat_cep { get; set; }
        public decimal Long_cep { get; set; }

        public Cep() { }
        public Cep(Int32 cod_cep, string desc_cep, decimal lat_cep, decimal long_cep)
        {
            Cod_cep = cod_cep;
            Desc_cep = desc_cep;
            Lat_cep = lat_cep;
            Long_cep = long_cep;
        }
    }
}