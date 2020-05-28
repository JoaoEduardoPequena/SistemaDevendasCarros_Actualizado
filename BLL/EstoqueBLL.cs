using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class EstoqueBLL
    {
       AcessoBancoDados bd;

       public void InserirNovoProduto_Em_Estoque_BLL(EstoqueDTO dto)
       {
           try
           {
               bd = new AcessoBancoDados();
               bd.Conectar();
               string comando = "INSERT INTO tb_estoque(cod_carro,qtd_estoque) VALUES("+dto.cod_carro+","+dto.qtd_estoque+")";
               bd.ExecutarComandoSQL(comando);
           }
           catch (Exception ex)
           {
               throw new Exception("Erro ao Inserir Um Nova Quantidade De Produto Em Estoque. Detalhe:" + ex.Message);
               //MessageBox.Show("Erro ao Inserir Dados de Carro. Detalhe:" + ex.Message);
           }

           finally
           {
               bd = null;
           }
       }

        public DataTable SelecionaProdutos_Em_EstoqueBLL()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //dt = bd.RetDataTable("select COUNT(tb_estoque.cod_estoque) AS TotalModelo ,tb_carros.marca_carro,tb_carros.modelo_carro, tb_estoque.qtd_estoque FROM tb_carros INNER JOIN tb_estoque ON tb_estoque.cod_carro = tb_carros.cod_carro GROUP BY modelo_carro");
                dt = bd.RetDataTable("select tb_estoque.cod_estoque,tb_carros.marca_carro,tb_carros.modelo_carro, tb_estoque.qtd_estoque FROM tb_carros INNER JOIN tb_estoque ON tb_estoque.cod_carro = tb_carros.cod_carro");
                //dt = bd.RetDataTable("SELECT modelo_carro, COUNT(modelo_carro) AS TotalModeloCarro from tb_carros GROUP BY modelo_carro");
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

        public DataTable SelecionaProdutos_Em_EstoquePorNomeDaMarcaDoCarroBLL( string nomeMarcaCarro)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //dt = bd.RetDataTable("select COUNT(tb_estoque.cod_estoque) AS TotalModelo ,tb_carros.marca_carro,tb_carros.modelo_carro, tb_estoque.qtd_estoque FROM tb_carros INNER JOIN tb_estoque ON tb_estoque.cod_carro = tb_carros.cod_carro GROUP BY modelo_carro");
                dt = bd.RetDataTable("select tb_estoque.cod_estoque,tb_carros.marca_carro,tb_carros.modelo_carro, tb_estoque.qtd_estoque FROM tb_carros INNER JOIN tb_estoque ON tb_estoque.cod_carro = tb_carros.cod_carro WHERE tb_carros.marca_carro LIKE '%" + nomeMarcaCarro + "%' ");
                //dt = bd.RetDataTable("SELECT modelo_carro, COUNT(modelo_carro) AS TotalModeloCarro from tb_carros GROUP BY modelo_carro");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Procurar Ua marca de Carro Em Estoque.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

        public DataTable PesquisarPorNomeDaCategoriaDoCarro_EstoqueBLL( int codigoCategoriaCarro)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_carros INNER JOIN tb_categoria_carro ON tb_categoria_carro.cod_cat_carro = tb_carros.cod_cat_carro WHERE tb_categoria_carro.cod_cat_carro=" + codigoCategoriaCarro + "  ");               
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

        public void AlterarEstoqueBLL(EstoqueDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE tb_estoque set cod_carro=" + dto.cod_carro + ",qtd_estoque="+dto.qtd_estoque+" Where cod_estoque=" + dto.cod_estoque + " ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Tentar Alterar Dado de Carro No Estoque.Detalhes:" + ex.Message);
            }

            finally
            {
                bd = null;
            }

        }
            public void ExcluirEstoqueBLL(EstoqueDTO dto)
            {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM tb_estoque WHERE cod_estoque= "+dto.cod_estoque+"  ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Excluir o Dado do Carro No Estoque. Detalhes: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

    }
    
}
