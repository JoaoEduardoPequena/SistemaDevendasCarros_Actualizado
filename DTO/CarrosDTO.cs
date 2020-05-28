using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CarrosDTO
    {
        public int cod_carro { get; set; }
        public int cod_cat_carro { get; set; }
        public int cod_transmissao { get; set; }
        public int cod_combustivel { get; set; }
        public string modelo_carro { get; set; }
        public string marca_carro { get; set; }
        public string kilometragem { get; set; }
        public string origem { get; set; }
        public string cor_carro { get; set; }
        public string imagem_carro { get; set; }
        //public byte[] imagem_carro { get; set; }
       
    }
}
