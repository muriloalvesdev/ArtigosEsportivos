using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    
    public class ListarVendas: ConnectSql
    {
        public List<Vendas> listarProdutos()
        {
            List<Vendas> listar = new List<Vendas>();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "select * from vendas order by id, nome, quantidade, " +
                    "precounidade, modelo, total;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    Vendas v = new Vendas()
                    {
                        id_produto = leitor["id"].ToString(),
                        nome = leitor["nome"].ToString(),
                        modelo = leitor["modelo"].ToString(),
                        quantidade = leitor["quantidade"].ToString(),
                        precoUnidade = leitor["precounidade"].ToString(),
                        total = leitor["total"].ToString()
                    };
                    listar.Add(v);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return listar;
        }
    }
}
