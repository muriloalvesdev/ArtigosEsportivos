namespace Pim3Semestre_Original_
{
    partial class PesquisarRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarRelatorios));
            this.panelDashboardRelatorios = new System.Windows.Forms.Panel();
            this.lblTextRelatorios = new System.Windows.Forms.Label();
            this.btnRelatoriosVendas = new System.Windows.Forms.Button();
            this.panelVendas = new System.Windows.Forms.Panel();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.BtnFecharJanelaPrincipal = new System.Windows.Forms.Button();
            this.panelDashboardRelatorios.SuspendLayout();
            this.panelVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDashboardRelatorios
            // 
            this.panelDashboardRelatorios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDashboardRelatorios.BackgroundImage")));
            this.panelDashboardRelatorios.Controls.Add(this.lblTextRelatorios);
            this.panelDashboardRelatorios.Controls.Add(this.btnRelatoriosVendas);
            this.panelDashboardRelatorios.Location = new System.Drawing.Point(0, 1);
            this.panelDashboardRelatorios.Name = "panelDashboardRelatorios";
            this.panelDashboardRelatorios.Size = new System.Drawing.Size(240, 774);
            this.panelDashboardRelatorios.TabIndex = 4;
            // 
            // lblTextRelatorios
            // 
            this.lblTextRelatorios.AutoSize = true;
            this.lblTextRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.lblTextRelatorios.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextRelatorios.ForeColor = System.Drawing.Color.White;
            this.lblTextRelatorios.Location = new System.Drawing.Point(32, 51);
            this.lblTextRelatorios.Name = "lblTextRelatorios";
            this.lblTextRelatorios.Size = new System.Drawing.Size(181, 39);
            this.lblTextRelatorios.TabIndex = 3;
            this.lblTextRelatorios.Text = "Relatórios";
            // 
            // btnRelatoriosVendas
            // 
            this.btnRelatoriosVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatoriosVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatoriosVendas.FlatAppearance.BorderSize = 0;
            this.btnRelatoriosVendas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRelatoriosVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRelatoriosVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRelatoriosVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatoriosVendas.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatoriosVendas.ForeColor = System.Drawing.Color.White;
            this.btnRelatoriosVendas.Location = new System.Drawing.Point(0, 178);
            this.btnRelatoriosVendas.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatoriosVendas.Name = "btnRelatoriosVendas";
            this.btnRelatoriosVendas.Size = new System.Drawing.Size(240, 41);
            this.btnRelatoriosVendas.TabIndex = 2;
            this.btnRelatoriosVendas.Text = "Vendas efetuadas";
            this.btnRelatoriosVendas.UseVisualStyleBackColor = false;
            this.btnRelatoriosVendas.Click += new System.EventHandler(this.btnRelatoriosVendas_Click);
            // 
            // panelVendas
            // 
            this.panelVendas.Controls.Add(this.btnExcluirVenda);
            this.panelVendas.Controls.Add(this.dataGridViewVendas);
            this.panelVendas.Controls.Add(this.btnBuscarProduto);
            this.panelVendas.Controls.Add(this.maskedTextBoxCnpj);
            this.panelVendas.Controls.Add(this.textBoxNomeProduto);
            this.panelVendas.Controls.Add(this.lblCodProduto);
            this.panelVendas.Controls.Add(this.lblNomeProduto);
            this.panelVendas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelVendas.Location = new System.Drawing.Point(300, 114);
            this.panelVendas.Name = "panelVendas";
            this.panelVendas.Size = new System.Drawing.Size(599, 507);
            this.panelVendas.TabIndex = 5;
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.BackColor = System.Drawing.Color.Red;
            this.btnExcluirVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirVenda.FlatAppearance.BorderSize = 0;
            this.btnExcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVenda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVenda.ForeColor = System.Drawing.Color.White;
            this.btnExcluirVenda.Location = new System.Drawing.Point(369, 474);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(84, 30);
            this.btnExcluirVenda.TabIndex = 16;
            this.btnExcluirVenda.Text = "Excluir";
            this.btnExcluirVenda.UseVisualStyleBackColor = false;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Location = new System.Drawing.Point(6, 116);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.Size = new System.Drawing.Size(447, 331);
            this.dataGridViewVendas.TabIndex = 4;
            this.dataGridViewVendas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVendas_CellMouseClick);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarProduto.BackgroundImage")));
            this.btnBuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProduto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.Location = new System.Drawing.Point(350, 74);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(103, 36);
            this.btnBuscarProduto.TabIndex = 3;
            this.btnBuscarProduto.Text = "Pesquisar";
            this.btnBuscarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(59, 88);
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(107, 22);
            this.maskedTextBoxCnpj.TabIndex = 2;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeProduto.Location = new System.Drawing.Point(59, 53);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(193, 22);
            this.textBoxNomeProduto.TabIndex = 1;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(3, 90);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(56, 16);
            this.lblCodProduto.TabIndex = 1;
            this.lblCodProduto.Text = "Código: ";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(3, 55);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(50, 16);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome: ";
            // 
            // BtnFecharJanelaPrincipal
            // 
            this.BtnFecharJanelaPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFecharJanelaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFecharJanelaPrincipal.FlatAppearance.BorderSize = 0;
            this.BtnFecharJanelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFecharJanelaPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("BtnFecharJanelaPrincipal.Image")));
            this.BtnFecharJanelaPrincipal.Location = new System.Drawing.Point(984, 12);
            this.BtnFecharJanelaPrincipal.Name = "BtnFecharJanelaPrincipal";
            this.BtnFecharJanelaPrincipal.Size = new System.Drawing.Size(39, 36);
            this.BtnFecharJanelaPrincipal.TabIndex = 9;
            this.BtnFecharJanelaPrincipal.UseVisualStyleBackColor = true;
            this.BtnFecharJanelaPrincipal.Click += new System.EventHandler(this.BtnFecharJanelaPrincipal_Click);
            // 
            // PesquisarRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 643);
            this.Controls.Add(this.BtnFecharJanelaPrincipal);
            this.Controls.Add(this.panelVendas);
            this.Controls.Add(this.panelDashboardRelatorios);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 40);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PesquisarRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PesquisarRelatórios";
            this.Load += new System.EventHandler(this.PesquisarRelatorios_Load);
            this.panelDashboardRelatorios.ResumeLayout(false);
            this.panelDashboardRelatorios.PerformLayout();
            this.panelVendas.ResumeLayout(false);
            this.panelVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelDashboardRelatorios;
        private System.Windows.Forms.Label lblTextRelatorios;
        private System.Windows.Forms.Button btnRelatoriosVendas;
        private System.Windows.Forms.Panel panelVendas;
        public System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.Button btnBuscarProduto;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxCnpj;
        public System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Button btnExcluirVenda;
        private System.Windows.Forms.Button BtnFecharJanelaPrincipal;
    }
}