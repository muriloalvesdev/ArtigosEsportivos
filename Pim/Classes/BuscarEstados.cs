using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class BuscarEstados : ConnectSql
    {
        public List<Estados> buscarEstados()
        {
            List<Estados> estados = new List<Estados>();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();

                String query = "select * from estado;";

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Prepare();

                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    Estados e = new Estados()
                    {
                        id_estado = leitor["id"].ToString(),
                        nome = leitor["uf"].ToString()
                    };
                    estados.Add(e);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return estados;
        }
    }
}