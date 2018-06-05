using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class RemoverDados : ConnectSql
    {
        public void excluirProduto(int id)
        {
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "DELETE FROM produto where id=@id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o produto: " + ex.ToString());
            }
        }

        public void excluirCliente(int id)
        {
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "DELETE FROM cliente where id=@id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o produto: " + ex.ToString());
            }

        }
        public void excluirFornecedor(int id)
        {
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "DELETE FROM fornecedor where id=@id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o fornecedor: " + ex.ToString());
            }
        }

        public void excluirVenda(int id)
        {
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "DELETE FROM vendas where id=@id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a venda: " + ex.ToString());
            }
        }
    }
}