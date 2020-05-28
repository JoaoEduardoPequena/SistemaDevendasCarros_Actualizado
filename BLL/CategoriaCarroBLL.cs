using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class CategoriaCarroBLL
    {
        AcessoBancoDados bd;

        public DataTable SelecionarCategoriaDeCarroBLL()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_categoria_carro");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Uma Categoria de Carro.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

        
    }
}