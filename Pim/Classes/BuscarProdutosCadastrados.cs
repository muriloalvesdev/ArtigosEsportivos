using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class BuscarProdutosCadastrados: ConnectSql
    {
        public List<Produto> buscarProdutos()
        {
            List<Produto> produto = new List<Produto>();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "select * from produto Order by nome asc;";
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Prepare();

                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    Produto p = new Produto()
                    {
                        idProduto = Convert.ToInt32(leitor["id"]),
                        nome = leitor["nome"].ToString(),
                        quantidade = leitor["quantidade"].ToString(),
                        descricao = leitor["descricao"].ToString(),
                        precoCusto = leitor["precocusto"].ToString(),
                        precoVenda = leitor["precovenda"].ToString(),
                        modelo = leitor["modelo"].ToString()
                    };
                    produto.Add(p);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return produto;
        }
    }
}
