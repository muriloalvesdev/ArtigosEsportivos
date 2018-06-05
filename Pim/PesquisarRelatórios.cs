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
    public partial class PesquisarRelatorios : Form
    {
        int id = 0;
        Classes.ListarVendas list = new Classes.ListarVendas();
        Classes.RemoverDados excluir = new Classes.RemoverDados();
        public PesquisarRelatorios()
        {
            InitializeComponent();
        }

        private void AtualizarGridViewVendasEfetuadas()
        {
            dataGridViewVendas.DataSource = list.listarProdutos();
            dataGridViewVendas.Columns[0].Visible = false;
            dataGridViewVendas.Columns[1].HeaderText = "Produto";
            dataGridViewVendas.Columns[2].HeaderText = "Preço Unitário";
            dataGridViewVendas.Columns[3].HeaderText = "Quantidade";
            dataGridViewVendas.Columns[4].Visible = false;
            dataGridViewVendas.Columns[5].HeaderText = "Total";
            dataGridViewVendas.Columns[6].Visible = false;
            dataGridViewVendas.Columns[7].Visible = false;
            dataGridViewVendas.Columns[8].Visible = false;
        }

        private void VisibilidadePaineis()
        {
            panelVendas.Visible = false;
        }

        private void PesquisarRelatorios_Load(object sender, EventArgs e)
        {
            textBoxNomeProduto.Focus();
            AtualizarGridViewVendasEfetuadas();
            VisibilidadePaineis();
        }

        private void btnRelatoriosVendas_Click(object sender, EventArgs e)
        {
            if (panelVendas.Visible == false) {
                btnRelatoriosVendas.Font = new Font("Tahoma", 20, FontStyle.Bold);
                panelVendas.Visible = true;
            }else if (panelVendas.Visible == true)
            {
                panelVendas.Focus();
                btnRelatoriosVendas.Font = new Font("Tahoma", 20, FontStyle.Bold);
            }
        }

        private void PegarIdProduto()
        {
            if (dataGridViewVendas.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewVendas.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
            }
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            excluir.excluirVenda(id);
            AtualizarGridViewVendasEfetuadas();
        }

        private void dataGridViewVendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PegarIdProduto();
        }

        private void BtnFecharJanelaPrincipal_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
