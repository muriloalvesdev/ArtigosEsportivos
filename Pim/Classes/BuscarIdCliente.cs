using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class BuscarIdCliente
    {
        public Clientes getClienteEdit(int id)
        {
            Clientes c = new Clientes();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "select * from cliente where id ="+ id +";";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    c.id_cliente = Convert.ToInt32(leitor["id"].ToString());
                    c.nome = leitor["nome"].ToString();
                    c.cpf = leitor["cpf"].ToString();
                    c.cidade = leitor["cidade"].ToString();
                    c.logradouro = leitor["logradouro"].ToString();
                    c.uf = leitor["uf"].ToString();
                    c.telfixo = leitor["telfixo"].ToString();
                    c.celular = leitor["celular"].ToString();
                    c.bairro = leitor["bairro"].ToString();
                    c.cep = leitor["cep"].ToString();
                    c.complemento = leitor["complemento"].ToString();
                    c.dataNascimento = leitor["datanascimento"].ToString();
                    c.sexo = leitor["sexo"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return c;
        }
    }
}
