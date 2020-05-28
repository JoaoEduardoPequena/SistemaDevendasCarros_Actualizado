using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class Item_VendaDTO
    {
        public int id_venda { get; set; }
        public int cod_carro { get; set; }
        public int quantidade { get; set; }
        public decimal valorTotal { get; set; }
    }
}
