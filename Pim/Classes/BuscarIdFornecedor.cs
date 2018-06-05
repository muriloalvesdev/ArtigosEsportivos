using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class BuscarIdFornecedor
    {
        public Fornecedor getFornecedorEdit(int id)
        {
            Fornecedor f = new Fornecedor();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "select * from fornecedor where id =" + id + ";";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    f.id_fornecedor = Convert.ToInt32(leitor["id"].ToString());
                    f.nome = leitor["nome"].ToString();
                    f.cnpj = leitor["cnpj"].ToString();
                    f.cidade = leitor["cidade"].ToString();
                    f.logradouro = leitor["logradouro"].ToString();
                    f.estado = leitor["estado"].ToString();
                    f.contato = leitor["contato"].ToString();
                    f.bairro = leitor["bairro"].ToString();
                    f.cep = leitor["cep"].ToString();
                    f.complemento = leitor["complemento"].ToString();
                    f.razaoSocial = leitor["razaosocial"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return f;
        }
    }
}