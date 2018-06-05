namespace Pim3Semestre_Original_
{
    partial class TelaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            this.lblTextControleEstoque = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.btnFecharJanela = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.lblTextNomeProduto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPrecoCusto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.btnConcluirCadastro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextControleEstoque
            // 
            this.lblTextControleEstoque.AutoSize = true;
            this.lblTextControleEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblTextControleEstoque.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextControleEstoque.ForeColor = System.Drawing.Color.Black;
            this.lblTextControleEstoque.Location = new System.Drawing.Point(27, 14);
            this.lblTextControleEstoque.Name = "lblTextControleEstoque";
            this.lblTextControleEstoque.Size = new System.Drawing.Size(373, 42);
            this.lblTextControleEstoque.TabIndex = 0;
            this.lblTextControleEstoque.Text = "Controle de estoque";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(33, 444);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(643, 217);
            this.dataGridViewProdutos.TabIndex = 1;
            this.dataGridViewProdutos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProdutos_CellMouseClick);
            this.dataGridViewProdutos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProdutos_CellMouseDoubleClick);
            // 
            // btnFecharJanela
            // 
            this.btnFecharJanela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharJanela.BackgroundImage")));
            this.btnFecharJanela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFecharJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharJanela.FlatAppearance.BorderSize = 0;
            this.btnFecharJanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharJanela.Location = new System.Drawing.Point(638, 12);
            this.btnFecharJanela.Name = "btnFecharJanela";
            this.btnFecharJanela.Size = new System.Drawing.Size(46, 44);
            this.btnFecharJanela.TabIndex = 8;
            this.btnFecharJanela.UseVisualStyleBackColor = true;
            this.btnFecharJanela.Click += new System.EventHandler(this.btnFecharJanela_Click);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantidade.Location = new System.Drawing.Point(495, 192);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(65, 22);
            this.textBoxQuantidade.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Preço de custo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Preço de venda: ";
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeProduto.Location = new System.Drawing.Point(169, 192);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(100, 22);
            this.textBoxNomeProduto.TabIndex = 1;
            // 
            // lblTextNomeProduto
            // 
            this.lblTextNomeProduto.AutoSize = true;
            this.lblTextNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblTextNomeProduto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNomeProduto.ForeColor = System.Drawing.Color.Black;
            this.lblTextNomeProduto.Location = new System.Drawing.Point(30, 192);
            this.lblTextNomeProduto.Name = "lblTextNomeProduto";
            this.lblTextNomeProduto.Size = new System.Drawing.Size(133, 18);
            this.lblTextNomeProduto.TabIndex = 17;
            this.lblTextNomeProduto.Text = "Nome do produto: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Descrição: ";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(169, 342);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(231, 77);
            this.textBoxDescricao.TabIndex = 6;
            // 
            // maskedTextBoxPrecoCusto
            // 
            this.maskedTextBoxPrecoCusto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPrecoCusto.Location = new System.Drawing.Point(169, 245);
            this.maskedTextBoxPrecoCusto.Name = "maskedTextBoxPrecoCusto";
            this.maskedTextBoxPrecoCusto.Size = new System.Drawing.Size(65, 22);
            this.maskedTextBoxPrecoCusto.TabIndex = 3;
            // 
            // maskedTextBoxPrecoVenda
            // 
            this.maskedTextBoxPrecoVenda.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPrecoVenda.Location = new System.Drawing.Point(495, 245);
            this.maskedTextBoxPrecoVenda.Name = "maskedTextBoxPrecoVenda";
            this.maskedTextBoxPrecoVenda.Size = new System.Drawing.Size(65, 22);
            this.maskedTextBoxPrecoVenda.TabIndex = 4;
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCancelarCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCadastro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelarCadastro.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarCadastro.Location = new System.Drawing.Point(439, 392);
            this.btnCancelarCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(88, 27);
            this.btnCancelarCadastro.TabIndex = 8;
            this.btnCancelarCadastro.Text = "Cancelar";
            this.btnCancelarCadastro.UseVisualStyleBackColor = false;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCadastro_Click);
            // 
            // btnConcluirCadastro
            // 
            this.btnConcluirCadastro.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnConcluirCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConcluirCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluirCadastro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConcluirCadastro.FlatAppearance.BorderSize = 0;
            this.btnConcluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirCadastro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirCadastro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConcluirCadastro.Location = new System.Drawing.Point(578, 392);
            this.btnConcluirCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnConcluirCadastro.Name = "btnConcluirCadastro";
            this.btnConcluirCadastro.Size = new System.Drawing.Size(98, 27);
            this.btnConcluirCadastro.TabIndex = 7;
            this.btnConcluirCadastro.Text = "Salvar";
            this.btnConcluirCadastro.UseVisualStyleBackColor = false;
            this.btnConcluirCadastro.Click += new System.EventHandler(this.btnConcluirCadastro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Modelo: ";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(169, 294);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 22);
            this.textBoxModelo.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(604, 678);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 30);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizar.Location = new System.Drawing.Point(578, 392);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(98, 27);
            this.btnAtualizar.TabIndex = 30;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // TelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 720);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelarCadastro);
            this.Controls.Add(this.btnConcluirCadastro);
            this.Controls.Add(this.maskedTextBoxPrecoVenda);
            this.Controls.Add(this.maskedTextBoxPrecoCusto);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.lblTextNomeProduto);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFecharJanela);
            this.Controls.Add(this.lblTextControleEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 40);
            this.Name = "TelaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Controle de estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextControleEstoque;
        private System.Windows.Forms.Button btnFecharJanela;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label lblTextNomeProduto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoCusto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoVenda;
        public System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.Button btnConcluirCadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
    }
}