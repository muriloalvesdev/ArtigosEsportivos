using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class DaoProduto : ConnectSql
    {
        public bool SalvarProduto(Produto p)
        {
            try
            {
                conn = new MySqlConnection(connectionString);

                String insertDados = "INSERT INTO produto(nome, quantidade, descricao, precovenda, precocusto, modelo)" +
                    " VALUES (@nome, @quantidade, @descricao, @precovenda, @precocusto, @modelo);";

                conn.Open();

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", p.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("quantidade", p.quantidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("descricao", p.descricao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("precovenda", p.precoVenda));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("precocusto", p.precoCusto));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("modelo", p.modelo));

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar o produto: " + ex.ToString());
                return false;
            }
        }
    }
}