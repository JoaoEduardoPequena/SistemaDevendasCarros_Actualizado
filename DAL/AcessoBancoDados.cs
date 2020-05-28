using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class AcessoBancoDados
    {

        // Variveis Para Conexão Com o Banco De Dados
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        //private MySqlDataReader dr;
        private MySqlCommandBuilder cb;
        private MySqlCommand cmd;

        //private string server = "localhost";
        //private string user = "root";
        //private string password = "1993";
        //private string database = "gestao_carros_venda";


        // Metodos Para A Conexão Com Banco de Dados MySQL

        public void Conectar()
        {
            if (conn != null)
                conn.Close();

            ////string connStr = string.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, user, password, database);
            
            //string connStr = "datasource=localhost; port=3306; database=gestao_carros_venda; username=root; password=1993";

            string connStr = Properties.Settings.Default.CaminhoConexao;
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }

            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Metdo para executar comandos SQL

        public object ExecutarComandoSQL(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            return comando.ExecuteScalar();
            conn.Close();
        }

        // Metodo para preencher os dados no datagrid

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        // Metodo Para Retronar um Id numerico
        public int RetDataTable_Id_Numerico(string sql)
        {
            data = new DataTable();

            da = new MySqlDataAdapter();

            cmd = new MySqlCommand(sql, conn);
            da.SelectCommand=cmd;

            da.Fill(data);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Metedo para fazer a leitura de dados da tabela 

        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            return dr;
        }
    }
}
