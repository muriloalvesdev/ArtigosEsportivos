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
    
    public partial class TelaCadastroFornecedor : Form
    {
        Fornecedor fornecedor = new Fornecedor();
        DaoFornecedor daoFornecedor = new DaoFornecedor();
        public TelaCadastroFornecedor()
        {
            InitializeComponent();
            FormatarTextBox format = new FormatarTextBox();
            MaskedTextBoxCnpj.Mask = format.Cnpj();
            MaskedTextBoxContato.Mask = format.Cel();
            textBoxNomeFornecedor.Focus();
            AtualizaGridViewFornecedor();
            //Classes.BuscarEstados buscEstados = new Classes.BuscarEstados();
            //comboBoxEstado.DataSource = buscEstados.buscarEstados();
            //comboBoxEstado.DisplayMember = "nome";
            //comboBoxEstado.ValueMember = "id_estado";
            maskedTextBoxCep.Mask = format.Cep();
            btnAtualizarCadastro.Visible = false;
        }
        int id = 0;

        private void btrnFecharTela_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
        
        private void limparDados()
        {
            textBoxNomeFornecedor.Text = "";
            MaskedTextBoxCnpj.Text = "";
            textBoxCadRazaoSocial.Text = "";
            MaskedTextBoxCnpj.Text = "";
            textBoxLogradouro.Text = "";
            textBoxBairro.Text = "";
            comboBoxCidade.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
            MaskedTextBoxContato.Text = "";
            maskedTextBoxCep.Text = "";
            textBoxComplemento.Text = "";
            atualizaCidadeCombobox();
            atualizarEstadoCombobox();
        }

        
        public void AtualizaGridViewFornecedor()
        {
            BuscarFornecedorCadastrados bf = new BuscarFornecedorCadastrados();
            dataGridViewControleFornecedor.DataSource = bf.buscarFornecedor();
            dataGridViewControleFornecedor.Columns[0].Visible = false;
            dataGridViewControleFornecedor.Columns[1].HeaderText = "Nome";
            dataGridViewControleFornecedor.Columns[2].HeaderText = "Contato";
            dataGridViewControleFornecedor.Columns[3].HeaderText = "Razão Social";
            dataGridViewControleFornecedor.Columns[4].HeaderText = "CNPJ";
            dataGridViewControleFornecedor.Columns[5].HeaderText = "Logradouro";
            dataGridViewControleFornecedor.Columns[6].HeaderText = "Bairro";
            dataGridViewControleFornecedor.Columns[7].HeaderText = "Cidade";
            dataGridViewControleFornecedor.Columns[8].HeaderText = "Estado";
            dataGridViewControleFornecedor.Columns[9].HeaderText = "Complemento";
            dataGridViewControleFornecedor.Columns[10].HeaderText = "CEP";

            dataGridViewControleFornecedor.Columns[2].Width = 110;
            dataGridViewControleFornecedor.Columns[3].Width = 140;
            dataGridViewControleFornecedor.Columns[4].Width = 130;
        }

        private bool validaCampos()
        {
            if (textBoxNomeFornecedor.Text != "" || maskedTextBoxCep.Text != "" ||
                textBoxCadRazaoSocial.Text != "" || MaskedTextBoxCnpj.Text != "" ||
                textBoxLogradouro.Text != "" || textBoxBairro.Text != "" ||
                comboBoxCidade.Text != "" || comboBoxEstado.Text != "" ||
                textBoxComplemento.Text != "" || MaskedTextBoxCnpj.Text != "")
            { 
                return true;
            }
            MessageBox.Show("Preencha todos os campos antes de salvar o fornecedor");
            return false;
        }
        
        private void btnConcluirCadastro_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                fornecedor.nome = textBoxNomeFornecedor.Text;
                fornecedor.contato = MaskedTextBoxContato.Text;
                fornecedor.razaoSocial = textBoxCadRazaoSocial.Text;
                fornecedor.cnpj = MaskedTextBoxCnpj.Text;
                fornecedor.logradouro = textBoxLogradouro.Text;
                fornecedor.bairro = textBoxBairro.Text;
                fornecedor.cidade = comboBoxCidade.Text;
                fornecedor.estado = comboBoxEstado.Text;
                fornecedor.cep = maskedTextBoxCep.Text;
                fornecedor.complemento = textBoxComplemento.Text;

                daoFornecedor.SalvarFornecedor(fornecedor);

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                limparDados();
                AtualizaGridViewFornecedor();
            }
        }

        private void atualizaCidadeCombobox()
        {
            Classes.BuscarCidadeDeEstado buscar = new Classes.BuscarCidadeDeEstado();
            List<Cidades> city = buscar.buscarCidadesPorUf(comboBoxEstado.Text);
            comboBoxCidade.DataSource = city;
            comboBoxCidade.DisplayMember = "uf";
            comboBoxCidade.ValueMember = "nome";
        }
        private void comboBoxEstado_TextChanged(object sender, EventArgs e)
        {
            atualizaCidadeCombobox();
        }
        
        
        
        private void dataGridViewControleFornecedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewControleFornecedor.SelectedRows.Count != 0)
            {
                Fornecedor f = new Fornecedor();
                BuscarIdFornecedor idFornec = new BuscarIdFornecedor();
                atualizarEstadoCombobox();
                DataGridViewRow row = dataGridViewControleFornecedor.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);

                f = idFornec.getFornecedorEdit(id);
                
                textBoxNomeFornecedor.Text = f.nome;
                MaskedTextBoxContato.Text = f.contato;
                MaskedTextBoxCnpj.Text = f.cnpj;
                textBoxCadRazaoSocial.Text = f.razaoSocial;
                comboBoxEstado.Text = f.estado;
                comboBoxCidade.Text = f.cidade;
                textBoxBairro.Text = f.bairro;
                textBoxLogradouro.Text = f.logradouro;
                textBoxComplemento.Text = f.complemento;
                maskedTextBoxCep.Text = f.cep;

                btnAtualizarCadastro.Visible = true;
                btnConcluirCadastro.Visible = false;
            }
        }
        
        private void dataGridViewControleFornecedor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewControleFornecedor.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewControleFornecedor.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
            }
        }

        RemoverDados excluir = new RemoverDados();
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir.excluirFornecedor(id);
            limparDados();
            AtualizaGridViewFornecedor();
        }

        private void atualizarEstadoCombobox()
        {
            Classes.BuscarEstados buscEstados = new Classes.BuscarEstados();
            comboBoxEstado.DataSource = buscEstados.buscarEstados();
            comboBoxEstado.DisplayMember = "nome";
            comboBoxEstado.ValueMember = "id_estado";
        }
        private void comboBoxEstado_MouseClick(object sender, MouseEventArgs e)
        {
            atualizarEstadoCombobox();
        }

        private void btnAtualizarCadastro_Click(object sender, EventArgs e)
        {
            btnAtualizarCadastro.Visible = false;
            btnConcluirCadastro.Visible = true;
            AtualizarFornecedor atualiza = new AtualizarFornecedor();
            try
            {
                if (validaCampos())
                {
                    fornecedor.id_fornecedor = id;
                    fornecedor.nome = textBoxNomeFornecedor.Text;
                    fornecedor.contato = MaskedTextBoxContato.Text;
                    fornecedor.razaoSocial = textBoxCadRazaoSocial.Text;
                    fornecedor.cnpj = MaskedTextBoxCnpj.Text;
                    fornecedor.logradouro = textBoxLogradouro.Text;
                    fornecedor.bairro = textBoxBairro.Text;
                    fornecedor.cidade = comboBoxCidade.Text;
                    fornecedor.estado = comboBoxEstado.Text;
                    fornecedor.cep = maskedTextBoxCep.Text;
                    fornecedor.complemento = textBoxComplemento.Text;

                    atualiza.AtualizaFornecedor(fornecedor);

                    MessageBox.Show("Cadastro atualizado com sucesso");
                    limparDados();
                    AtualizaGridViewFornecedor();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o fornecedor" + ex.ToString());
            }
        }
    }
}
