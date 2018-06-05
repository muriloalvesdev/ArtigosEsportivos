using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class BuscarFornecedorCadastrados: ConnectSql
    {
        public List<Fornecedor> buscarFornecedor()
        {
            List<Fornecedor> fornecedor = new List<Fornecedor>();
            try
            {
                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "select * from fornecedor Order by nome asc;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    Fornecedor fornec = new Fornecedor()
                    {
                        id_fornecedor = Convert.ToInt32(leitor["id"].ToString()),
                        nome = leitor["nome"].ToString(),
                        contato = leitor["contato"].ToString(),
                        razaoSocial = leitor["razaosocial"].ToString(),
                        cnpj = leitor["cnpj"].ToString(),
                        logradouro = leitor["logradouro"].ToString(),
                        bairro = leitor["bairro"].ToString(),
                        cidade = leitor["cidade"].ToString(),
                        estado = leitor["estado"].ToString(),
                        complemento = leitor["complemento"].ToString(),
                        cep = leitor["cep"].ToString()
                    };
                    fornecedor.Add(fornec);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return fornecedor;
        }

        public List<Fornecedor> buscarFornecedorPorNome(String nome)
        {
            List<Fornecedor> fornecedorPorNome = new List<Fornecedor>();
            try
            {
                TelaPesquisar pesq = new TelaPesquisar();

                MySqlConnection conn = new ConnectSql().getConnection();
                String query = "select * from fornecedor where nome like '" + nome + "';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return fornecedorPorNome;
        }

    }
}
