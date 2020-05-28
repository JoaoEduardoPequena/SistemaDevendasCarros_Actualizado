using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;

using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class Item_VendaBLL
    {
        public void InserirItemVendaBLL(Item_VendaDTO dto)
        {
            AcessoBancoDados bd;
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //string comando = "INSERT INTO item_venda(id_venda,cod_carro,quantidade,total) VALUES(" + dto.id_venda+ "," + dto.cod_carro+ ",'" + dto.quantidade+ "'," + dto.valorTotal+ " )";
                string comando = "INSERT INTO item_venda(id_venda,cod_carro,quantidade,total) VALUES(" + dto.id_venda+ "," + dto.cod_carro+ ",'" + dto.quantidade+ "'," + dto.valorTotal+ " )";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Efectuar Uma Nova Venda. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Item de Venda. Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }
    }
}
