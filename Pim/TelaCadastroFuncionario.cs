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
    public partial class TelaCadastroClientes : Form
    {
        DaoCliente daoCliente = new DaoCliente();
        FormatarTextBox format = new FormatarTextBox();
        Clientes c = new Clientes();
        BuscarIdCliente idClient = new BuscarIdCliente();

        public TelaCadastroClientes()
        {
            InitializeComponent();
            MaskedTextBoxCep.Mask = format.Cep();
            maskedTextBoxCpf.Mask = format.Cpf();
            maskedTextBoxTelFixo.Mask = format.TelFixo();
            maskedTextBoxDataNascimento.Mask = format.DataNascimento();
            MaskedTextBoxCelCelular.Mask = format.Cel();
            textBoxCliente.Focus();
            btnAtualizarCadastro.Visible = false;
            AtualizaGridViewCliente();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        Classes.BuscarClientesCadastrados bc = new Classes.BuscarClientesCadastrados();
        public void AtualizaGridViewCliente()
        {
            dataGridViewControleCliente.DataSource = bc.buscarCliente();
            dataGridViewControleCliente.Columns[0].Visible = false;
            dataGridViewControleCliente.Columns[1].HeaderText = "Nome";
            dataGridViewControleCliente.Columns[2].HeaderText = "CPF";
            dataGridViewControleCliente.Columns[3].HeaderText = "Data Nasc.";
            dataGridViewControleCliente.Columns[4].HeaderText = "Sexo";
            dataGridViewControleCliente.Columns[5].HeaderText = "CEP";
            dataGridViewControleCliente.Columns[6].HeaderText = "Logradouro";
            dataGridViewControleCliente.Columns[7].HeaderText = "Cidade";
            dataGridViewControleCliente.Columns[8].HeaderText = "Estado";
            dataGridViewControleCliente.Columns[9].HeaderText = "Complemento";
            dataGridViewControleCliente.Columns[10].HeaderText = "Celular";
            dataGridViewControleCliente.Columns[11].HeaderText = "Fixo";
            dataGridViewControleCliente.Columns[12].HeaderText = "Bairro";

            dataGridViewControleCliente.Columns[0].Width = 40;
            dataGridViewControleCliente.Columns[1].Width = 150;
            dataGridViewControleCliente.Columns[3].Width = 80;
            dataGridViewControleCliente.Columns[4].Width = 75;
            dataGridViewControleCliente.Columns[5].Width = 80;
        }

        private void setLimparCampos()
        {
            textBoxCliente.Text = "";
            textBoxComplemento.Text = "";
            textBoxLogradouro.Text = "";
            textBoxBairro.Text = "";
            maskedTextBoxDataNascimento.Text = "";
            MaskedTextBoxCelCelular.Text = "";
            maskedTextBoxCpf.Text = "";
            maskedTextBoxTelFixo.Text = "";
            MaskedTextBoxCep.Text = "";
            comboBoxCidades.SelectedIndex = 0;
            comboBoxEstados.SelectedIndex = 0;
            comboBoxSexo.SelectedIndex = 0;
        }

        private bool validaCampos()
        {
            if (textBoxCliente.Text == "" || MaskedTextBoxCelCelular.Text == "" ||
                MaskedTextBoxCelCelular.Text == "" || textBoxLogradouro.Text == "" ||
                textBoxLogradouro.Text == "" || comboBoxSexo.Text == "" ||
                maskedTextBoxCpf.Text == "" || maskedTextBoxTelFixo.Text == "" ||
                MaskedTextBoxCep.Text == "" || comboBoxEstados.Text == "" ||
                textBoxComplemento.Text == "" || textBoxBairro.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes de salvar o cliente");
                return false;
            }else
            {
                return true;
            }
        }

        private void btnConcluirCadastro_Click_1(object sender, EventArgs e)
        {
            try { 
                if (validaCampos()) {

                    Clientes cliente = new Clientes();
                    cliente.nome = textBoxCliente.Text;
                    cliente.dataNascimento = maskedTextBoxDataNascimento.Text;
                    cliente.celular = MaskedTextBoxCelCelular.Text;
                    cliente.logradouro = textBoxLogradouro.Text;
                    cliente.sexo = comboBoxSexo.Text;
                    cliente.cpf = maskedTextBoxCpf.Text;
                    cliente.telfixo = maskedTextBoxTelFixo.Text;
                    cliente.cep = MaskedTextBoxCep.Text;
                    cliente.uf = comboBoxEstados.Text;
                    cliente.complemento = textBoxComplemento.Text;
                    cliente.bairro = textBoxBairro.Text;
                    cliente.cidade = comboBoxCidades.Text;

                    daoCliente.SalvarCliente(cliente);

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    setLimparCampos();
                    AtualizaGridViewCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao concluir o cadastro: " + ex.ToString());
            }
        }

        private void btnCancelarCadastro_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFecharJanela_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        Classes.BuscarCidadeDeEstado buscar = new Classes.BuscarCidadeDeEstado();
        private void comboBoxEstados_TextChanged(object sender, EventArgs e)
        {
            List<Cidades> city = buscar.buscarCidadesPorUf(comboBoxEstados.Text);
            comboBoxCidades.DataSource = city;
            comboBoxCidades.DisplayMember = "uf";
            comboBoxCidades.ValueMember = "nome";
        }

        RemoverDados excluir = new RemoverDados();
        int id = 0;
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            excluir.excluirCliente(id);
            setLimparCampos();
            AtualizaGridViewCliente();
        }
        
        private void dataGridViewControleCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewControleCliente.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewControleCliente.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
            }
        }
        
        private void dataGridViewControleCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewControleCliente.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewControleCliente.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);

                atualizaEstadosCombobox();

                c = idClient.getClienteEdit(id);
                textBoxCliente.Text = c.nome;
                comboBoxSexo.Text = c.sexo;
                maskedTextBoxDataNascimento.Text = c.dataNascimento;
                MaskedTextBoxCelCelular.Text = c.celular;
                maskedTextBoxTelFixo.Text = c.telfixo;
                maskedTextBoxCpf.Text = c.cpf;
                comboBoxEstados.Text = c.uf;
                comboBoxCidades.Text = c.cidade;
                textBoxBairro.Text = c.bairro;
                textBoxLogradouro.Text = c.logradouro;
                textBoxComplemento.Text = c.complemento;
                MaskedTextBoxCep.Text = c.cep;

                btnAtualizarCadastro.Visible = true;
                btnConcluirCadastro.Visible = false;
            }
        }

        private void atualizaEstadosCombobox()
        {
            BuscarEstados buscEstad = new BuscarEstados();
            comboBoxEstados.DataSource = buscEstad.buscarEstados();
            comboBoxEstados.DisplayMember = "nome";
            comboBoxEstados.ValueMember = "id_estado";
        }

        private void comboBoxEstados_MouseClick(object sender, MouseEventArgs e)
        {
            atualizaEstadosCombobox();
        }

        private void btnAtualizarCadastro_Click(object sender, EventArgs e)
        {
            btnConcluirCadastro.Visible = true;
            btnAtualizarCadastro.Visible = false;

            AtualizarCliente atualiza = new AtualizarCliente();
            Clientes cliente = new Clientes();
            try
            {
                if (validaCampos())
                {
                    cliente.id_cliente = id;
                    cliente.nome = textBoxCliente.Text;
                    cliente.sexo = comboBoxSexo.Text;
                    cliente.dataNascimento = maskedTextBoxDataNascimento.Text;
                    cliente.celular = MaskedTextBoxCelCelular.Text;
                    cliente.telfixo = maskedTextBoxTelFixo.Text;
                    cliente.cpf = maskedTextBoxCpf.Text;
                    cliente.uf = comboBoxEstados.Text;
                    cliente.cidade = comboBoxCidades.Text;
                    cliente.bairro = textBoxBairro.Text;
                    cliente.logradouro = textBoxLogradouro.Text;
                    cliente.complemento = textBoxLogradouro.Text;
                    cliente.cep = MaskedTextBoxCep.Text;

                    atualiza.AtualizaCliente(cliente);
                    setLimparCampos();

                    MessageBox.Show("Cadastro atualizado com sucesso");
                    AtualizaGridViewCliente();
                    btnAtualizarCadastro.Visible = false;
                    btnConcluirCadastro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o cliente" + ex.ToString());
            }
        }
    }
}
