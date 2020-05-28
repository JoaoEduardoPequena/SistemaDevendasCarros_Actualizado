using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


using DTO;
using DAL;

namespace BLL
{
    public class CarrosBLL
    { 
        AcessoBancoDados bd;

        public void InserirNovoCarroBLL(CarrosDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_carros(cod_carro,cod_cat_carro,cod_transmissao,cod_combustivel,modelo_carro,marca_carro,kilometragem,origem,cor_carro,imagem_carro) VALUES(" + dto.cod_carro + "," + dto.cod_cat_carro + "," + dto.cod_transmissao + "," + dto.cod_combustivel + ",'" + dto.modelo_carro + "','" + dto.marca_carro + "','" + dto.kilometragem + "','" + dto.origem + "','" + dto.cor_carro + "','"+dto.imagem_carro+"' )";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Dados de Carro. Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }

        public void AlterarCarroBLL(CarrosDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando="UPDATE tb_carros set cod_cat_carro="+dto.cod_cat_carro+",cod_transmissao="+dto.cod_transmissao+",cod_combustivel="+dto.cod_combustivel+",modelo_carro='"+dto.modelo_carro+"',marca_carro='"+dto.marca_carro+"',kilometragem='"+dto.kilometragem+"',origem='"+dto.origem+"',cor_carro='"+dto.cor_carro+"' Where cod_carro="+dto.cod_carro+" ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Tentar Alterar Dado de Carro.Detalhes:" + ex.Message);
            }

            finally
            {
                bd = null;
            }


        }

        public void ExcluirCarroBLL(CarrosDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM tb_carros WHERE cod_carro= "+dto.cod_carro+"  ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Excluir o Dado do Carro. Detalhes: " + ex.Message);
                MessageBox.Show("Erro ao Excluir o Dado do Carro. Detalhes: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        // Seleccion Todos Dados Das tres Tabelas relacionadas tb_carros,tb_categoria_carro, tb_transmissao, tb_combustivel
        public DataTable SelecionarCarroBLL()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //dt = bd.RetDataTable("SELECT tb_carros.cod_carro AS Codigo,tb_transmissao.nome AS Transmissao,tb_carros.modelo_carro AS Modelo,tb_carros.marca_carro AS Marca,tb_carros.kilometragem AS Velocidade,tb_carros.origem AS Origem,tb_carros.cor_carro AS Cor, tb_combustivel.combustivel AS Combustivel,tb_categoria_carro.nome_cat AS CategoriaCarro, imagem_carro as Imagem FROM tb_carros INNER JOIN tb_transmissao ON  tb_carros.cod_transmissao=tb_transmissao.cod_transmissao INNER JOIN tb_combustivel ON tb_carros.cod_combustivel=tb_combustivel.cod_combustivel INNER JOIN tb_categoria_carro ON tb_carros.cod_cat_carro=tb_categoria_carro.cod_cat_carro ORDER BY tb_carros.cod_carro");
                dt = bd.RetDataTable("SELECT tb_carros.cod_carro,tb_transmissao.nome,tb_carros.modelo_carro,tb_carros.marca_carro,tb_carros.kilometragem,tb_carros.origem,tb_carros.cor_carro, tb_combustivel.combustivel,tb_categoria_carro.nome_cat, imagem_carro FROM tb_carros INNER JOIN tb_transmissao ON  tb_carros.cod_transmissao=tb_transmissao.cod_transmissao INNER JOIN tb_combustivel ON tb_carros.cod_combustivel=tb_combustivel.cod_combustivel INNER JOIN tb_categoria_carro ON tb_carros.cod_cat_carro=tb_categoria_carro.cod_cat_carro ORDER BY tb_carros.cod_carro");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Dados Do Carro.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;

        }


        public DataTable PesquisarCarrosPorNomeDaMarcaDOCarroBLL(string valor)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //dt = bd.RetDataTable("SELECT * FROM tb_carros WHERE marca_carro LIKE '%"+valor+"%' ");
                
                //dt = bd.RetDataTable("SELECT tb_carros.cod_carro,tb_categoria_carro.nome_cat,tb_transmissao.nome,tb_combustivel.combustivel,tb_carros.modelo_carro,tb_carros.marca_carro,tb_carros.kilometragem,tb_carros.origem,tb_carros.cor_carro,tb_transmissao. FROM tb_carros INNER JOIN tb_combustivel ON tb_carros.cod_carro= tb_combustivel INNER JOIN tb_transmissao ON tb_carros.cod_carro= tb_transmissao.cod_carro" );
                //dt = bd.RetDataTable("SELECT tb_carros.cod_carro AS Codigo,tb_transmissao.nome AS Transmissao,tb_carros.modelo_carro AS Modelo,tb_carros.marca_carro AS Marca,tb_carros.kilometragem AS Velocidade,tb_carros.origem AS Origem,tb_carros.cor_carro AS Cor,tb_carros.imagem_carro AS Imagem, tb_combustivel.combustivel AS Combustivel,tb_categoria_carro.nome_cat AS CategoriaCarro FROM tb_carros INNER JOIN tb_transmissao ON  tb_carros.cod_transmissao=tb_transmissao.cod_transmissao INNER JOIN tb_combustivel ON tb_carros.cod_combustivel=tb_combustivel.cod_combustivel INNER JOIN tb_categoria_carro ON tb_carros.cod_cat_carro=tb_categoria_carro.cod_cat_carro WHERE tb_carros.marca_carro LIKE'%"+valor+"%' ");
                dt = bd.RetDataTable("SELECT tb_carros.cod_carro AS Codigo,tb_transmissao.nome AS Transmissao,tb_carros.modelo_carro AS Modelo,tb_carros.marca_carro AS Marca,tb_carros.kilometragem AS Velocidade,tb_carros.origem AS Origem,tb_carros.cor_carro AS Cor,tb_combustivel.combustivel AS Combustivel,tb_categoria_carro.nome_cat AS CategoriaCarro FROM tb_carros INNER JOIN tb_transmissao ON  tb_carros.cod_transmissao=tb_transmissao.cod_transmissao INNER JOIN tb_combustivel ON tb_carros.cod_combustivel=tb_combustivel.cod_combustivel INNER JOIN tb_categoria_carro ON tb_carros.cod_cat_carro=tb_categoria_carro.cod_cat_carro WHERE tb_carros.marca_carro LIKE'%" + valor + "%' ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Paciente.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }


        public DataTable PesquisarCarrosPorCodigoBLL(int codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT tb_carros.cod_carro,tb_transmissao.nome AS Transmissao,tb_carros.modelo_carro AS Modelo,tb_carros.marca_carro AS Marca,tb_carros.kilometragem AS Velocidade,tb_carros.origem AS Origem,tb_carros.cor_carro AS Cor, tb_combustivel.combustivel AS Combustivel,tb_categoria_carro.nome_cat AS CategoriaCarro FROM tb_carros INNER JOIN tb_transmissao ON  tb_carros.cod_transmissao=tb_transmissao.cod_transmissao INNER JOIN tb_combustivel ON tb_carros.cod_combustivel=tb_combustivel.cod_combustivel INNER JOIN tb_categoria_carro ON tb_carros.cod_cat_carro=tb_categoria_carro.cod_cat_carro WHERE tb_carros.cod_carro="+codigo+" ");
              
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar O Código do Carro.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }
        // Metodo Para seleccionar uma Categoria De Carro Por Codigo
        public DataTable PesquisarCarrosPorCodigoDaCategoriaBLL(int codigoCat_Carro)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_carros WHERE cod_cat_carro="+codigoCat_Carro+" ");
                //dt = bd.RetDataTable("SELECT tb_carros.marca_carro FROM tb_carros INNER JOIN tb_categoria_carro ON tb_carros.cod_cat_carro=tb_categoria_carro.cod_cat_carro WHERE tb_categoria_carro.cod_cat_carro="+codigoCat_Carro+" ");
              
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar A Marca do Carro.Datalhe:"+ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

            // Metodo que Selecciona Todos Dados Na LisBox De Marcas De Carros No Estoque
            // OBS: Este Metod Esta Somente Na Tela de cadastro de Estoque
            public DataTable SeleccionarTodosDadosNaListBox_BLL( )
            {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_carros");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar A Marca do Carro.Datalhe:"+ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }  
    }

}
