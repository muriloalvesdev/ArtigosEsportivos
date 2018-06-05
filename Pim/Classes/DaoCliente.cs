using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class DaoCliente: ConnectSql
    {
        public bool SalvarCliente(Clientes c)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                String insertDados = "INSERT INTO cliente(nome, datanascimento, celular, " +
                    "cidade, logradouro, bairro, sexo, cpf, telfixo, cep, uf, complemento) " +
                    "VALUES (@nome, @datanascimento, @celular, @cidade, @logradouro, " +
                    "@bairro, @sexo, @cpf, @telfixo, @cep, @uf, @complemento);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o cliente, verifique a conexão com o banco de dados: " + ex.ToString());
                return false;
            }
        } 
    }
}