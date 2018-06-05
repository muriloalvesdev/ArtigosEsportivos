using MySql.Data.MySqlClient;
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
    public partial class BtnCaixa : Form
    {
        TelaPrincipal tela;
        DaoVenda daoVenda = new DaoVenda();
        ListarVendas list = new ListarVendas();
        Produto p = new Produto();
        BuscarIdProduto buscar = new BuscarIdProduto();
        RemoverDados excluir = new RemoverDados();
        int id = 0;
        float totalVenda = 0;
        public BtnCaixa()
        {
            InitializeComponent();
        }
        
        public void nomearDataGridViewCaixa()
        {
            dataGridViewProdutosCaixa.ColumnCount = 5;
            dataGridViewProdutosCaixa.Columns[0].HeaderText = "Código";
            dataGridViewProdutosCaixa.Columns[1].HeaderText = "Produto";
            dataGridViewProdutosCaixa.Columns[2].HeaderText = "Preço Unid.";
            dataGridViewProdutosCaixa.Columns[3].HeaderText = "Quantidade";
            dataGridViewProdutosCaixa.Columns[4].HeaderText = "Total";
        }

        public BtnCaixa(TelaPrincipal _tela)
        {
            InitializeComponent();
            textBoxNomeProd.Focus();
            tela = _tela;
        }
        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            tela.BtnCaixa.Font = new Font("Tahoma", 18);
            Hide();
            Close();
        }

        private void atualizaComboboxProdutos()
        {
            BuscarProdutosCadastrados buscar = new BuscarProdutosCadastrados();
            List<Produto> produto = buscar.buscarProdutos();
            comboBoxProdutos.DataSource = produto;
            comboBoxProdutos.DisplayMember = "nome";
            comboBoxProdutos.ValueMember = "idProduto";
        }
        private void comboBoxProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            atualizaComboboxProdutos();
        }

        private void dataGridViewProdutosCaixa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewProdutosCaixa.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewProdutosCaixa.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
            }
        }

        private void textBoxCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Produto p = new Produto();
                int valorInformado = 0;

                valorInformado = Convert.ToInt32(textBoxCodProduto.Text);
                if (valorInformado == 1234)
                {
                    textBoxCodProduto.Text = "Outros";
                    textBoxCodProduto.Enabled = false;
                }
            }
        }

        private bool validaCampos()
        {
            if (textBoxNomeProd.Text == "" || textBoxlQuantidadeProduto.Text == "" ||
                textBoxlValorUnitario.Text == "" || maskedTextBoxValorTotalVenda.Text == "" )
            {
                MessageBox.Show("Não é possível adicionar um produto se os campos estiverem vazios");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Vendas venda = new Vendas();

            try
            {
                if (validaCampos())
                {
                    dataGridViewProdutosCaixa.Rows.Add(textBoxCodProduto.Text, textBoxNomeProd.Text,
                    textBoxlQuantidadeProduto.Text, textBoxlValorUnitario.Text, maskedTextBoxValorTotalVenda.Text);

                    venda.nome = textBoxNomeProd.Text;
                    venda.quantidade = textBoxlQuantidadeProduto.Text;
                    venda.precoUnidade = textBoxlValorUnitario.Text;
                    venda.total = maskedTextBoxValorTotalVenda.Text;

                    nomearDataGridViewCaixa();
                    daoVenda.SalvarVenda(venda);
                    setLimparCampos();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível adicionar a venda deste produto\nVerifique o ERRO: " + ex.ToString());
            }
        }

        private void setLimparCampos()
        {
            textBoxNomeProd.Text = "";
            textBoxlQuantidadeProduto.Text = "";
            textBoxlValorUnitario.Text = "";
            maskedTextBoxValorTotalVenda.Text = "";
        }
        List<Produto> tprod = new List<Produto>();
        private void btnAdicionarProdutosEsquerda_Click(object sender, EventArgs e)
        {
            Vendas venda = new Vendas();
            try
            {
                if (validaCampos())
                {
                    dataGridViewProdutosCaixa.Rows.Add(textBoxCodProduto.Text, textBoxNomeProd.Text,
                    textBoxlQuantidadeProduto.Text, textBoxlValorUnitario.Text, maskedTextBoxValorTotalVenda.Text);

                    totalVenda += float.Parse(maskedTextBoxValorTotalVenda.Text);
                    textBoxTotalVendaCompleta.Text = Convert.ToString(totalVenda);
                    textBoxTotalVendaCompleta.Enabled = false;

                    venda.nome = textBoxNomeProd.Text;
                    venda.quantidade = textBoxlQuantidadeProduto.Text;
                    venda.precoUnidade = textBoxlValorUnitario.Text;
                    venda.total = maskedTextBoxValorTotalVenda.Text;
                    
                    daoVenda.SalvarVenda(venda);
                    setLimparCampos();
                    nomearDataGridViewCaixa();

                    /*BuscarIdProduto pb = new BuscarIdProduto();
                    Produto vende = new Produto();
                    vende = pb.getProdutoEdit(Convert.ToInt32(textBoxCodProduto.Text));
                    tprod.Add(vende);


                    InserirVenda Salvar = new InserirVenda();
                    Vendas v = new Vendas();
                    InserirItem item = new InserirItem();
                    
                    v.id_funcionario = "1";
                    v.dia = Convert.ToString(DateTime.Now);
                    long id = Salvar.SalvaVenda(v);
                    item.SalvaItem(tprod, Convert.ToInt32(id), 1);

                    v.nome = textBoxNomeProd.Text;
                    v.quantidade = textBoxlQuantidadeProduto.Text;
                    v.precoUnidade = textBoxlValorUnitario.Text;
                    v.total = maskedTextBoxValorTotalVenda.Text; */

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possível adicionar a venda deste produto\nVerifique o ERRO: " + ex.ToString());
            }
        }

        private void validaCamposNumericos()
        {

        }

        private void textBoxlValorUnitario_TextChanged(object sender, EventArgs e)
        {
            int quantidade = 0;
            float precoUnita = 0;
            float total = 0;
            maskedTextBoxValorTotalVenda.Font = new Font("Tahoma", 12, FontStyle.Bold);
            if (textBoxlQuantidadeProduto.Text != "" && textBoxlValorUnitario.Text != "")
            {

                precoUnita = float.Parse(textBoxlValorUnitario.Text);
                quantidade = Convert.ToInt32(textBoxlQuantidadeProduto.Text);
                total = quantidade * precoUnita;
                maskedTextBoxValorTotalVenda.Enabled = false;
                maskedTextBoxValorTotalVenda.Text = Convert.ToString(total);
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            textBoxTotalVenda.Text = textBoxTotalVendaCompleta.Text;
            textBoxTotalVendaCompleta.Text = "";
            textBoxCodProduto.Text = "";
            textBoxTotalVenda.Enabled = false;
            btnFinalizarCompra.Visible = false;
            try {
                FinalizandoCompraBotoes();
                btnFinalizarVenda.Visible = true;
                textBoxCodProduto.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível finalizar a venda"+ ex.ToString());
            }
        }
        private void BtnCaixa_Load(object sender, EventArgs e)
        {
            textBoxNomeProd.Focus();
            nomearDataGridViewCaixa();
            btnFinalizarVenda.Visible = false;
            ConcluindoCompraBotoes();
        }
        private void FinalizandoCompraBotoes()
        {
            lblTextCodVenda.Visible = false;
            lblTxtnomeProduto.Visible = false;
            lblQuantidade.Visible = false;
            lblTextValorUnitario.Visible = false;
            lblTotalVenda.Visible = false;

            textBoxCodProduto.Visible = false;
            textBoxNomeProd.Visible = false;
            textBoxlQuantidadeProduto.Visible = false;
            textBoxlValorUnitario.Visible = false;
            maskedTextBoxValorTotalVenda.Visible = false;
            lblTextTotal.Visible = false;
            btnAdicionarProdutosEsquerda.Visible = false;
            textBoxTotalVendaCompleta.Visible = false;

            comboBoxProdutos.Enabled = false;
            btnAdicionarProduto.Enabled = false;

            comboBoxFormaPagamento.Visible = true;
            textBoxValorPagamento.Visible = true;
            textBoxTroco.Visible = true;
            lblFormaPagamento.Visible = true;
            lblPagamento.Visible = true;
            lblTroco.Visible = true;
            lblTotal.Visible = true;
            textBoxTotalVenda.Visible = true;
        }

        private void ConcluindoCompraBotoes()
        {
            lblTextCodVenda.Visible = true;
            lblTxtnomeProduto.Visible = true;
            lblQuantidade.Visible = true;
            lblTextValorUnitario.Visible = true;
            lblTotalVenda.Visible = true;

            textBoxCodProduto.Visible = true;
            textBoxNomeProd.Visible = true;
            textBoxlQuantidadeProduto.Visible = true;
            textBoxlValorUnitario.Visible = true;
            maskedTextBoxValorTotalVenda.Visible = true;
            lblTextTotal.Visible = true;
            btnAdicionarProdutosEsquerda.Visible = true;
            textBoxTotalVendaCompleta.Visible = true;

            comboBoxProdutos.Enabled = true;
            btnAdicionarProduto.Enabled = true;

            comboBoxFormaPagamento.Visible = false;
            textBoxValorPagamento.Visible = false;
            textBoxTroco.Visible = false;
            lblFormaPagamento.Visible = false;
            lblPagamento.Visible = false;
            lblTroco.Visible = false;
            lblTotal.Visible = false;
            textBoxTotalVenda.Visible = false;
        }
        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {


            btnFinalizarVenda.Visible = false;
            btnFinalizarCompra.Visible = true;
            setLimparCampos();
            dataGridViewProdutosCaixa.Rows.Clear();
            MessageBox.Show("Venda concluída com sucesso!");
            ConcluindoCompraBotoes();
        }

        private void textBoxValorPagamento_TextChanged(object sender, EventArgs e)
        {
            btnFinalizarVenda.Visible = true;
            btnFinalizarCompra.Visible = false;
            Double valorPagamento = 0;
            Double total = 0;
            Double troco = 0;

            if (textBoxValorPagamento.Text != "" || textBoxTroco.Text != "") {
                valorPagamento = Convert.ToDouble(textBoxValorPagamento.Text);
                total = Convert.ToDouble(textBoxTotalVenda.Text);
                troco = valorPagamento - total;
                textBoxTroco.Text = Convert.ToString(troco);
                textBoxTroco.Enabled = false;
            }else if (textBoxValorPagamento.Text == "" || textBoxTroco.Text == "")
            {
                textBoxValorPagamento.Text = "0";
                textBoxTroco.Text = "0";
                valorPagamento = Convert.ToDouble(textBoxValorPagamento.Text);
                troco = Convert.ToDouble(textBoxTroco.Text);
            }
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            excluir.excluirVenda(id);
        }

        private void textBoxlQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))

            {
                MessageBox.Show("Digite apenas números inteiros");
                e.Handled = true;
            }
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Digite apenas números inteiros");
                e.Handled = true;
            }
        }

        private void textBoxCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))

            {
                MessageBox.Show("Digite apenas números inteiros");
                e.Handled = true;
            }
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Digite apenas números inteiros");
                e.Handled = true;
            }
        }

        private void textBoxlValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula");
            }
        }

        private void textBoxValorPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula");
            }
        }

        private void comboBoxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormaPagamento.SelectedIndex != 0)
            {
                textBoxValorPagamento.Text = textBoxTotalVenda.Text;
                textBoxTroco.Text = "0";
                textBoxValorPagamento.Enabled = false;
                textBoxTroco.Enabled = false;
                maskedTextBoxValorTotalVenda.Enabled = false;
            }else if (comboBoxFormaPagamento.SelectedIndex == 0)
            {
                if (textBoxValorPagamento.Text != "" || textBoxTroco.Text != "")
                {
                    MessageBox.Show("Forma de pagamento alterada para DINHEIRO, verifique o TROCO!");
                    Double valorPagamento;
                    Double total;
                    Double troco;
                    valorPagamento = Convert.ToDouble(textBoxValorPagamento.Text);
                    total = Convert.ToDouble(textBoxTotalVenda.Text);
                    troco = valorPagamento - total;
                    textBoxTroco.Text = Convert.ToString(troco);
                    textBoxTroco.Enabled = false;
                }
            }
        }
    }
}