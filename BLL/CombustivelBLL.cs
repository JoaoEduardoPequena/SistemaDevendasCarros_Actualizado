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
    public class CombustivelBLL
    {
        AcessoBancoDados bd;

        public DataTable SelecionarCombustivelMotorBLL()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_combustivel");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Um tipo de Fucionamento de Motor.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;

        }

    }
}
