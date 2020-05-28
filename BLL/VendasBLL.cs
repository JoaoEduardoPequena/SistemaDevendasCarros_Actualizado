using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class VendasBLL
    {
        AcessoBancoDados bd;

        //Metodo Para Efectuar Uma Nova Venda

        public int GerarCodigoVenda()
        {
           bd = new AcessoBancoDados();
           bd.Conectar();
           string comando = "select MAX(id_venda) from tb_venda";
           return Convert.ToInt32(bd.ExecutarComandoSQL(comando));
        }

        public void InserirNovoVendaBLL(VendaDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_venda(cod_carro,preco_venda,total_venda) VALUES(" +dto.cod_carro+ ","+dto.preco_venda+", "+dto.total_venda+" )";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Efectuar Uma Nova Venda. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Efectuar Uma Nova Venda. Detalhe:"+ ex.Message);
            }

            finally
            {
                bd = null;
            }
        }

        // Metodo Que Retorna Os Dados Dos Carros  No Estoque Para Vendas
        public DataTable SelecionaProdutos_Em_EstoqueParaVendaBLL()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select tb_carros.cod_carro,tb_carros.marca_carro,tb_carros.modelo_carro,tb_estoque.qtd_estoque FROM tb_estoque INNER JOIN tb_carros ON tb_estoque.cod_carro = tb_carros.cod_carro ORDER BY tb_carros.cod_carro");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Um Produto Em Estoque.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }
        
        // Metodos Que Retorna Os Detalhes Das Vendas Efectuadas
        public  MySqlDataReader ConsultarCarrosParaVenda( int codigoCarro)
        {
            MySqlDataReader dr;
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dr = bd.RetDataReader("SELECT tb_carros.marca_carro,tb_carros.modelo_carro,tb_venda.preco_venda FROM tb_carros INNER JOIN tb_venda ON tb_venda.cod_carro=tb_carros.cod_carro where tb_carros.cod_carro="+codigoCarro+" ");
                //dt = bd.RetDataTable("SELECT tb_venda.id_venda,tb_carros.modelo_carro,tb_venda.data_venda,tb_venda.preco_venda,SUM(tb_venda.quantidade_venda) AS Qtde_Total_Vendas, SUM(tb_venda.quantidade_venda)*(tb_venda.preco_venda) AS ValorTotalVendas FROM tb_venda INNER JOIN tb_carros ON tb_venda.cod_carro=tb_carros.cod_carro GROUP BY tb_carros.modelo_carro ORDER BY tb_venda.id_venda");
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Um Produto Em Estoque.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dr;
        }


        public void ExcluirVendaBLL(VendaDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM tb_venda WHERE id_venda= " + dto.id_venda+ "  ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Excluir o Dado do Carro. Detalhes: " + ex.Message);
                MessageBox.Show("Erro ao Excluir o Dado de Uma Venda. Detalhes: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
