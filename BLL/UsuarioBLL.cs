using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;

using System.Windows.Forms;
using System.Data;


namespace BLL
{
    public class UsuarioBLL
    {
        AcessoBancoDados bd;
        int retorno;
        public void InserirNovos_UsuariosBLL(UsuariosDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_usuarios(nome_usuario,senha_usuario,funcao_usuario) VALUES('"+dto.nome_usuario+"','"+dto.senha_usuario+"','"+dto.funcao_usuario+"' )";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Novo Usuario.Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }

        

        public void ExcluirUsuarioBLL(UsuariosDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM tb_usuarios WHERE cod_usuario="+dto.cod_usuario+" ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Excluir o Usuário. Detalhes: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
        // Metodo Para os Usuários Entrarem No Sistema
        public int Login_UsuarioBLL(string nome, string senha)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "SELECT * FROM tb_usuarios WHERE (nome_usuario='"+nome+"' AND senha_usuario='"+senha+"' )";
                retorno= bd.RetDataTable_Id_Numerico(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Efectuar Login no Sistema.Datalhe:" + ex.Message);
                MessageBox.Show("Erro ao Efectuar Login no Sistema.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return retorno;

        }

        public DataTable SelecionarUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_usuarios");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Usuários.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;

        }


        public DataTable PesquisarUsuarioPorCodigo(int codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_usuarios WHERE cod_usuario= "+codigo+" ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Dados do Usuário.Datalhe:"+ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

        public DataTable PesquisarUsuarioPorNome(string valor)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_usuarios WHERE nome_usuario LIKE '%" + valor + "%' ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Pesquisar Usuario.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

        public void AlterarUsuarioBLL(UsuariosDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE tb_usuarios set nome_usuario='" + dto.nome_usuario + "',senha_usuario='" + dto.senha_usuario + "',funcao_usuario='" + dto.funcao_usuario + "' Where cod_usuario=" + dto.cod_usuario + " ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Tentar Alterar Dado de usuario.Detalhes:" + ex.Message);
            }

            finally
            {
                bd = null;
            }


        }
    }
}
