using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class BuscarIdProduto
    {
        public Produto getProdutoEdit(int id)
        {
            Produto p = new Produto();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "select * from produto where id =" + id + ";";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    p.idProduto = Convert.ToInt32(leitor["id"].ToString());
                    p.nome = leitor["nome"].ToString();
                    p.quantidade = leitor["quantidade"].ToString();
                    p.precoCusto = leitor["precocusto"].ToString();
                    p.precoVenda = leitor["precovenda"].ToString();
                    p.modelo = leitor["modelo"].ToString();
                    p.descricao = leitor["descricao"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return p;
        }
    }
}
