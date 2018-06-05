using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class DaoFornecedor : ConnectSql
    {
        public bool SalvarFornecedor(Fornecedor f)
        {
            try
            {
                String insertDados = "INSERT INTO fornecedor(nome, contato, razaosocial, cnpj, " +
                    "logradouro, bairro, cidade, estado, cep, complemento) " +
                    "VALUES (@nome, @contato, @razaosocial, @cnpj, @logradouro, @bairro, @cidade, @estado, @cep, @complemento);";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", f.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("contato", f.contato));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("razaosocial", f.razaoSocial));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cnpj", f.cnpj));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("logradouro", f.logradouro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("bairro", f.bairro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cidade", f.cidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("estado", f.estado));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep", f.cep));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("complemento", f.complemento));

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ou cadastrar cliente, verifique a conexão com o banco de dados: " + ex.ToString());
                return false;
            }
        }
    }
}
