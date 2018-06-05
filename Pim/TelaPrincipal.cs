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
    public partial class TelaPrincipal : Form
    {
        TelaCadastroCliente telaCadClientes = new TelaCadastroCliente();
        TelaCadastroFornecedor telaCadFornecedor = new TelaCadastroFornecedor();
        TelaEstoque estoque = new TelaEstoque();
        TelaPesquisar pesq = new TelaPesquisar();
        BtnCaixa telaCaixa = new BtnCaixa();
        ConnectSql connect = new ConnectSql();
        
        public TelaPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
            SetAlteraFonteBotoes();
            VisibilidadePaineis();

            BtnCaixa.BackColor = Color.Transparent;
            BtnEstoque.BackColor = Color.Transparent;
            btnPanelEstoque.BackColor = Color.Transparent;
        }
        
        public void SetAlteraFonteBotoes()
        {
            BtnEstoque.Font = new Font("Tahoma", 18);
            BtnCaixa.Font = new Font("Tahoma", 18);
            BtnCadastro.Font = new Font("Tahoma", 18);
            BtnRelatorios.Font = new Font("Tahoma", 18);
            btnAllPesquisar.Font = new Font("Tahoma", 18);
            btnSetaPesquisar.Visible = false;
            btnSetaRelatorios.Visible = false;
        }
        
        private void VisibilidadePaineis()
        {
            panelMenuPrincipalEstoque.Visible = false;
            pesq.Visible = false;
            panelMenuPrincipalCadastro.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (panelMenuPrincipalEstoque.Visible == false)
            {
                VisibilidadePaineis();
                SetAlteraFonteBotoes();
                BtnEstoque.Font = new Font("Tahpma", 20, FontStyle.Bold);
                panelMenuPrincipalEstoque.Visible = true;
            }
            else if (panelMenuPrincipalEstoque.Visible == true)
            {
                SetAlteraFonteBotoes();
                VisibilidadePaineis();
            }
        }

        public void BtnMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (telaCaixa.Visible == false)
            {
                telaCaixa = new BtnCaixa(this);

                VisibilidadePaineis();
                SetAlteraFonteBotoes();

                BtnCaixa.Font = new Font("Tahoma", 20, FontStyle.Bold);
                telaCaixa.Visible = true;

            }
            if (telaCaixa.Visible == true)
            {
                SetAlteraFonteBotoes();

                BtnCaixa.Font = new Font("Tahoma", 20, FontStyle.Bold);

                telaCaixa.Focus();
            }
        }
        
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (panelMenuPrincipalCadastro.Visible == false) {

                SetAlteraFonteBotoes();
                VisibilidadePaineis();
                BtnCadastro.Font = new Font("Tahoma", 20, FontStyle.Bold);
                panelMenuPrincipalCadastro.Visible = true;

            }else if (panelMenuPrincipalCadastro.Visible == true)
            {
                SetAlteraFonteBotoes();
                VisibilidadePaineis();
            }
        }

        private void btnPanelEstoque_Click(object sender, EventArgs e)
        {
            if (estoque.Visible == false)
            {
                estoque = new TelaEstoque();
                estoque.Visible = true;
            }
            else if (estoque.Visible == true)
            {
                estoque.Focus();
            }
        }
        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {   
            if (telaCadFornecedor.Visible == false)
            {
                telaCadFornecedor = new TelaCadastroFornecedor();
                telaCadFornecedor.Visible = true;
            }
            else if (telaCadFornecedor.Visible == true)
            {
                telaCadFornecedor.Focus();
            }
        }

        private void btnCadastroClientes_Click(object sender, EventArgs e)
        {
            if (telaCadClientes.Visible == false)
            {
                telaCadClientes = new TelaCadastroCliente();
                telaCadClientes.Visible = true;
            }else if(telaCadClientes.Visible == true)
            {
                telaCadClientes.Focus();
            }
        }

        private void BtnFecharJanelaPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void tempoSegundos_Tick(object sender, EventArgs e)
        {
            dataSistemaPc.Text = (DateTime.Now.ToString("HH:mm:ss"));
            dateSistemaData.Text = (DateTime.Now.ToString("yyyy-MM-dd"));
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            PesquisarRelatorios relatorios = new PesquisarRelatorios();
            
            if (relatorios.Visible == false)
            {
                relatorios.Visible = true;
                SetAlteraFonteBotoes();
                VisibilidadePaineis();
                btnSetaRelatorios.Visible = true;
                BtnRelatorios.Font = new Font("Tahoma", 20, FontStyle.Bold);
            }else if (relatorios.Visible == true)
            {
                relatorios.Focus();
                SetAlteraFonteBotoes();
                VisibilidadePaineis();
                btnSetaRelatorios.Visible = true;
                BtnRelatorios.Font = new Font("Tahoma", 20, FontStyle.Bold);
            }
        }

        private void btnAllPesquisar_Click(object sender, EventArgs e)
        {
            VisibilidadePaineis();
            SetAlteraFonteBotoes();
            if (pesq.Visible == false)
            {
                pesq = new TelaPesquisar();
                pesq.Visible = true;
                btnAllPesquisar.Font = new Font("Tahoma", 20, FontStyle.Bold);
                btnSetaPesquisar.Visible = true;
            }
            else if (pesq.Visible == true)
            {
                SetAlteraFonteBotoes();
                btnSetaPesquisar.Visible = true;
                btnAllPesquisar.Font = new Font("Tahoma", 20, FontStyle.Bold);
                pesq.Focus();
            }
        }
    }
}