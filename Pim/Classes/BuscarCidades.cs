using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class BuscarCidades : ConnectSql
    {
        public List<Cidades> buscarCidades()
        {
            List<Cidades> cidades = new List<Cidades>();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "SELECT * FROM cidades;";

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Prepare();

                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    Cidades c = new Cidades()
                    {
                        id_cidade = leitor["id"].ToString(),
                        nome = leitor["nome"].ToString()
                    };
                    cidades.Add(c);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return cidades;
        }
    }
}