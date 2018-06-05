using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class AtualizarCliente: ConnectSql
    {
        public bool AtualizaCliente(Clientes c)
        {
            try
            {
                conn = new MySqlConnection(connectionString);

                String query = "UPDATE cliente SET nome=@nome, datanascimento=@dataNascimento, celular=@celular, cidade=@cidade," +
                    "logradouro=@logradouro, sexo=@sexo, cpf=@cpf, telfixo=@telfixo, cep=@cep, uf=uf, complemento=@complemento, bairro=@bairro WHERE id=@id;";

                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", c.id_cliente));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", c.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("datanascimento", c.dataNascimento));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("celular", c.celular));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cidade", c.cidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("logradouro", c.logradouro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("sexo", c.sexo));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpf", c.cpf));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("telfixo", c.telfixo));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep", c.cep));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("uf", c.uf));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("complemento", c.complemento));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("bairro", c.bairro));

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar o cliente: " + e.ToString());
                return false;
            }
        }
    }
}
