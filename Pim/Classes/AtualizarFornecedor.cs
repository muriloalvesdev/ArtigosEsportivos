using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class AtualizarFornecedor: ConnectSql
    {
        public bool AtualizaFornecedor(Fornecedor f)
        {
            try
            {
                conn = new MySqlConnection(connectionString);

                String query = "UPDATE fornecedor SET nome=@nome, contato=@contato, razaoSocial=@razaoSocial," +
                    "cnpj=@cnpj, logradouro=@logradouro, bairro=@bairro, cidade=@cidade, estado=@estado, " +
                    "estado=estado, cep=@cep, complemento=@complemento WHERE id=@id;";

                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", f.id_fornecedor));
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
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar o cliente: " + e.ToString());
                return false;
            }
        }
    }
}
