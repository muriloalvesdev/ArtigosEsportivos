using Pim3Semestre_Original_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_
{
    public partial class TelaPesquisar : Form
    {

        BuscarClientesCadastrados bc = new BuscarClientesCadastrados();
        BuscarProdutosCadastrados bp = new BuscarProdutosCadastrados();
        BuscarFornecedorCadastrados bf = new BuscarFornecedorCadastrados();

        public TelaPesquisar()
        {
            InitializeComponent();
            AlteraFonteBotoes();
            AlterarVisibilidadePaineis();
            AtualizaGridViewCliente();
            AtualizaGridViewFornecedor();
            AtualizaGridViewProdutos();
        }
        
        public void AtualizaGridViewProdutos()
        {
            dataGridViewProdutos.DataSource = bp.buscarProdutos();
            dataGridViewProdutos.Columns[0].Visible = false;
            dataGridViewProdutos.Columns[1].HeaderText = "Nome";
            dataGridViewProdutos.Columns[2].HeaderText = "Venda";
            dataGridViewProdutos.Columns[3].HeaderText = "Custo";
            dataGridViewProdutos.Columns[4].HeaderText = "Quantidade";
            dataGridViewProdutos.Columns[5].HeaderText = "Descrição";
        }
        
        public void AtualizaGridViewFornecedor()
        {
            dataGridViewFornecedor.DataSource = bf.buscarFornecedor();
            dataGridViewFornecedor.Columns[0].Visible = false;
            dataGridViewFornecedor.Columns[1].HeaderText = "Nome";
            dataGridViewFornecedor.Columns[2].HeaderText = "Contato";
            dataGridViewFornecedor.Columns[3].HeaderText = "Razão Social";
            dataGridViewFornecedor.Columns[4].HeaderText = "CNPJ";
            dataGridViewFornecedor.Columns[5].HeaderText = "Logradouro";
            dataGridViewFornecedor.Columns[6].HeaderText = "Bairro";
            dataGridViewFornecedor.Columns[7].HeaderText = "Cidade";
            dataGridViewFornecedor.Columns[8].HeaderText = "Estado";
            dataGridViewFornecedor.Columns[9].HeaderText = "Complemento";
            dataGridViewFornecedor.Columns[10].HeaderText = "CEP";

            dataGridViewFornecedor.Columns[2].Width = 110;
            dataGridViewFornecedor.Columns[3].Width = 140;
            dataGridViewFornecedor.Columns[4].Width = 130;
        }
       
        public void AtualizaGridViewCliente()
        {
            dataGridViewCliente.DataSource = bc.buscarCliente();
            dataGridViewCliente.Columns[0].Visible = false;
            dataGridViewCliente.Columns[1].HeaderText = "Nome";
            dataGridViewCliente.Columns[2].HeaderText = "CPF";
            dataGridViewCliente.Columns[3].HeaderText = "Data Nasc.";
            dataGridViewCliente.Columns[4].HeaderText = "Sexo";
            dataGridViewCliente.Columns[5].HeaderText = "CEP";
            dataGridViewCliente.Columns[6].HeaderText = "Logradouro";
            dataGridViewCliente.Columns[7].HeaderText = "Cidade";
            dataGridViewCliente.Columns[8].HeaderText = "Estado";
            dataGridViewCliente.Columns[9].HeaderText = "Complemento";
            dataGridViewCliente.Columns[10].HeaderText = "Celular";
            dataGridViewCliente.Columns[11].HeaderText = "Fixo";
            dataGridViewCliente.Columns[12].HeaderText = "Bairro";
            dataGridViewCliente.Columns[0].Width = 40;
            dataGridViewCliente.Columns[1].Width = 150;
            dataGridViewCliente.Columns[3].Width = 80;
            dataGridViewCliente.Columns[4].Width = 75;
            dataGridViewCliente.Columns[5].Width = 80;
        }

        
        private void AlteraFonteBotoes()
        {
            btnPesquisarFornecedor.Font = new Font("Tahoma", 16);
            btnPesquisarCliente.Font = new Font("Tahoma", 16);
            btnPesquisarProduto.Font = new Font("Tahoma", 16);
        }

        private void AlterarVisibilidadePaineis()
        {
            panelFornecedor.Visible = false;
            panelCliente.Visible = false;
            panelProduto.Visible = false;
        }

        private void btnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            try { 
                if (panelFornecedor.Visible == false)
                {
                    AlterarVisibilidadePaineis();
                    AlteraFonteBotoes();
                    panelFornecedor.Visible = true;
                    textBoxNomeFornecedor.Focus();
                    btnPesquisarFornecedor.Font = new Font("Tahoma", 16, FontStyle.Bold);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao tentar abrir a pesquisa do fornecedor:" + ex.ToString());
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try{
                if (panelCliente.Visible == false)
                {
                    AlterarVisibilidadePaineis();
                    AlteraFonteBotoes();
                    panelCliente.Visible = true;
                    textBoxNomeCliente.Focus();
                    btnPesquisarCliente.Font = new Font("Tahoma", 16, FontStyle.Bold);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao tentar abrir a pesquisa do cliente:" + ex.ToString());
            }
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelProduto.Visible == false)
                {
                    AlterarVisibilidadePaineis();
                    AlteraFonteBotoes();
                    panelProduto.Visible = true;
                    textBoxNomeProduto.Focus();
                    btnPesquisarProduto.Font = new Font("Tahoma", 16, FontStyle.Bold);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao tentar abrir a pesquisa do produto:" + ex.ToString());
            }
        }

        private void btnCloseFecharTelaDePEsquisa_Click(object sender, EventArgs e)
        {
            try {
                Hide();
                Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void validaCamposFornecedor()
        {
            if (textBoxNomeFornecedor.Text == "" && maskedTextBoxCnpj.Text == "")
            {
                MessageBox.Show("Preencha ao menos um campo antes de efetuar a pesquisa");
            }
        }

        private void validaCamposCliente()
        {
            if(textBoxNomeCliente.Text == "" && maskedTextBoxCpf.Text == "")
            {
                MessageBox.Show("Preencha ao menos um campo antes de efetuar a pesquisa");
            }
        }

        private void validaCamposProduto()
        {
            if(textBoxNomeProduto.Text == "")
            {
                MessageBox.Show("Preencha o campo 'Nome' antes de efetuar a pesquisa");
            }
        }
        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            validaCamposFornecedor();  
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            validaCamposProduto();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            validaCamposCliente();
        }
    }
}