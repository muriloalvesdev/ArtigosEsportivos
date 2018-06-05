using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class DaoVenda : ConnectSql
    {
        public bool SalvarVenda(Vendas v)
        {
            try
            {
                conn = new MySqlConnection(connectionString);

                String insertDados = "INSERT INTO vendas(nome, precounidade, quantidade, total)" +
                    " VALUES (@nome, @precoUnidade, @quantidade, @total);";

                conn.Open();

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", v.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("precounidade", v.precoUnidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("quantidade", v.quantidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("total", v.total));

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar o produto: " + ex.ToString());
                return false;
            }
        }
    }
}
