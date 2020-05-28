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
    public class TransmissaoMotorBLL
    {
        AcessoBancoDados bd;

        public DataTable SelecionarTransmissao()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_transmissao");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Um Tipo de Transimssão.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;

        }
    }  
}