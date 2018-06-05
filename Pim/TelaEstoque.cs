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
    public partial class TelaEstoque : Form
    {
        DaoProduto daoProduto = new DaoProduto();
        BuscarIdProduto idProd = new BuscarIdProduto();
        Produto p = new Produto();
        public TelaEstoque()
        {
            InitializeComponent();
            AtualizarTableProdutos();
            AtualizarTableProdutos();
            textBoxNomeProduto.Focus();
            btnAtualizar.Visible = false;
        }
        BuscarProdutosCadastrados bp = new BuscarProdutosCadastrados();
        public void AtualizarTableProdutos()
        {
            dataGridViewProdutos.DataSource = bp.buscarProdutos();
            dataGridViewProdutos.Columns[0].Visible = false;
            dataGridViewProdutos.Columns[1].HeaderText = "Nome";
            dataGridViewProdutos.Columns[2].HeaderText = "Venda";
            dataGridViewProdutos.Columns[3].HeaderText = "Custo";
            dataGridViewProdutos.Columns[4].HeaderText = "Quantidade";
            dataGridViewProdutos.Columns[5].HeaderText = "Descrição";
            dataGridViewProdutos.Columns[6].HeaderText = "Modelo";
        }
        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void setLimparCampos()
        {
            textBoxNomeProduto.Text = "";
            textBoxQuantidade.Text = "";
            textBoxDescricao.Text = "";
            maskedTextBoxPrecoCusto.Text = "";
            maskedTextBoxPrecoVenda.Text = "";
            textBoxModelo.Text = "";
        }

        public bool validaCampos()
        {
            if (textBoxNomeProduto.Text == "" || textBoxQuantidade.Text == ""
               || textBoxDescricao.Text == "" || maskedTextBoxPrecoCusto.Text == ""
               || maskedTextBoxPrecoVenda.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridViewProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridViewProdutos.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = dataGridViewProdutos.SelectedRows[0];
                    var value = row.Cells[0].Value;
                    id = Convert.ToInt32(value);

                    AtualizarTableProdutos();

                    p = idProd.getProdutoEdit(id);
                    
                    textBoxNomeProduto.Text = p.nome;
                    textBoxDescricao.Text = p.descricao;
                    maskedTextBoxPrecoCusto.Text = p.precoCusto;
                    maskedTextBoxPrecoVenda.Text = p.precoVenda;
                    textBoxModelo.Text = p.modelo;
                    textBoxQuantidade.Text = p.quantidade;

                    btnAtualizar.Visible = true;
                    btnConcluirCadastro.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConcluirCadastro_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                Produto produto = new Produto();

                produto.nome = textBoxNomeProduto.Text;
                produto.quantidade = textBoxQuantidade.Text;
                produto.descricao = textBoxDescricao.Text;
                produto.precoCusto = maskedTextBoxPrecoCusto.Text;
                produto.precoVenda = maskedTextBoxPrecoVenda.Text;
                produto.modelo = textBoxModelo.Text;

                daoProduto.SalvarProduto(produto);
                setLimparCampos();
                AtualizarTableProdutos();

                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de salvar o produto");
            }
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        RemoverDados excluir = new RemoverDados();
        int id = 0;
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir.excluirProduto(id);
            AtualizarTableProdutos();
        }

        private void dataGridViewProdutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewProdutos.SelectedRows[0];
                    var value = row.Cells[0].Value;
                    id = Convert.ToInt32(value);
                    p = idProd.getProdutoEdit(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarProdutos atualizar = new AtualizarProdutos();
            Produto produto = new Produto();

            try
            {
                if (validaCampos())
                {
                    produto.idProduto = id;
                    produto.nome = textBoxNomeProduto.Text;
                    produto.quantidade = textBoxQuantidade.Text;
                    produto.descricao = textBoxDescricao.Text;
                    produto.precoCusto = maskedTextBoxPrecoCusto.Text;
                    produto.precoVenda = maskedTextBoxPrecoVenda.Text;
                    produto.modelo = textBoxModelo.Text;

                    atualizar.AtualizaProduto(produto);

                    setLimparCampos();
                    
                    MessageBox.Show("Produto atualizado com sucesso!");

                    AtualizarTableProdutos();
                    btnAtualizar.Visible = false;
                    btnConcluirCadastro.Visible = true;
                }
                else
                {
                    btnConcluirCadastro.Visible = true;
                    MessageBox.Show("Preencha todos os campos antes de atualizar o produto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o produto: " + ex.ToString());
            }

        }
    }
}