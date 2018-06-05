using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class BuscarClientesCadastrados: ConnectSql
    {
        public List<Clientes> buscarCliente()
        {
            List<Clientes> cliente = new List<Clientes>();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "select * from cliente Order by nome asc;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    Clientes c = new Clientes()
                    {
                        id_cliente = Convert.ToInt32(leitor["id"].ToString()),
                        nome = leitor["nome"].ToString(),
                        cpf = leitor["cpf"].ToString(),
                        cidade = leitor["cidade"].ToString(),
                        logradouro = leitor["logradouro"].ToString(),
                        uf = leitor["uf"].ToString(),
                        telfixo = leitor["telfixo"].ToString(),
                        celular = leitor["celular"].ToString(),
                        bairro = leitor["bairro"].ToString(),
                        cep = leitor["cep"].ToString(),
                        complemento = leitor["complemento"].ToString(),
                        dataNascimento = leitor["datanascimento"].ToString(),
                        sexo = leitor["sexo"].ToString()
                    };
                    cliente.Add(c);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return cliente;
        }
    }
}
