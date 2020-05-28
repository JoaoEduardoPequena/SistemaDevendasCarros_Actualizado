using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VendaDTO
    {
        public int id_venda { get; set; }
        public string nome { get; set; }
        public int cod_usuario { get; set; }
        public int quantidade_venda { get; set; }
        public decimal preco_venda { get; set; }
        public decimal total_venda { get; set; }
        public string  data_venda { get; set; }
        public int cod_carro { get; set; }
    }
}
