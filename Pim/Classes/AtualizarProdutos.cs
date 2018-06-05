using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class AtualizarProdutos: ConnectSql
    {
        public bool AtualizaProduto(Produto p)
        {
            try
            {
                conn = new MySqlConnection(connectionString);

                String query = "UPDATE produto SET modelo=@modelo, nome=@nome," +
                    " quantidade=@quantidade, precocusto=@precoCusto, precovenda=@precoVenda," +
                    "descricao=@descricao WHERE id=@id;";

                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", p.idProduto));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("modelo", p.modelo));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", p.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("quantidade", p.quantidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("precocusto", p.precoCusto));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("precovenda", p.precoVenda));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("descricao", p.descricao));
                
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar o produto: " + e.ToString());
                return false;
            }
        }
    }
}
