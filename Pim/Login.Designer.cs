namespace Pim3Semestre_Original_
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTextLogin = new System.Windows.Forms.Label();
            this.lblTextInfoLogin = new System.Windows.Forms.Label();
            this.lblTextUsuario = new System.Windows.Forms.Label();
            this.lblTextSenha = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.btnAcessarSistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextLogin
            // 
            this.lblTextLogin.AutoSize = true;
            this.lblTextLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblTextLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextLogin.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextLogin.ForeColor = System.Drawing.Color.White;
            this.lblTextLogin.Location = new System.Drawing.Point(13, 13);
            this.lblTextLogin.Name = "lblTextLogin";
            this.lblTextLogin.Size = new System.Drawing.Size(96, 35);
            this.lblTextLogin.TabIndex = 0;
            this.lblTextLogin.Text = "Login";
            // 
            // lblTextInfoLogin
            // 
            this.lblTextInfoLogin.AutoSize = true;
            this.lblTextInfoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblTextInfoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextInfoLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextInfoLogin.ForeColor = System.Drawing.Color.White;
            this.lblTextInfoLogin.Location = new System.Drawing.Point(16, 73);
            this.lblTextInfoLogin.Name = "lblTextInfoLogin";
            this.lblTextInfoLogin.Size = new System.Drawing.Size(338, 13);
            this.lblTextInfoLogin.TabIndex = 1;
            this.lblTextInfoLogin.Text = "Informe seus dados de acesso corretamente para acessar o sistema.";
            // 
            // lblTextUsuario
            // 
            this.lblTextUsuario.AutoSize = true;
            this.lblTextUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTextUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextUsuario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTextUsuario.Location = new System.Drawing.Point(95, 151);
            this.lblTextUsuario.Name = "lblTextUsuario";
            this.lblTextUsuario.Size = new System.Drawing.Size(65, 16);
            this.lblTextUsuario.TabIndex = 2;
            this.lblTextUsuario.Text = "Usuário: ";
            // 
            // lblTextSenha
            // 
            this.lblTextSenha.AutoSize = true;
            this.lblTextSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblTextSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextSenha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSenha.ForeColor = System.Drawing.Color.White;
            this.lblTextSenha.Location = new System.Drawing.Point(98, 199);
            this.lblTextSenha.Name = "lblTextSenha";
            this.lblTextSenha.Size = new System.Drawing.Size(57, 16);
            this.lblTextSenha.TabIndex = 3;
            this.lblTextSenha.Text = "Senha: ";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(167, 151);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(167, 199);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 22);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            this.textBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenha_KeyDown);
            // 
            // btnAcessarSistema
            // 
            this.btnAcessarSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAcessarSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcessarSistema.FlatAppearance.BorderSize = 0;
            this.btnAcessarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessarSistema.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessarSistema.ForeColor = System.Drawing.Color.Black;
            this.btnAcessarSistema.Location = new System.Drawing.Point(167, 281);
            this.btnAcessarSistema.Name = "btnAcessarSistema";
            this.btnAcessarSistema.Size = new System.Drawing.Size(100, 31);
            this.btnAcessarSistema.TabIndex = 3;
            this.btnAcessarSistema.Text = "Acessar";
            this.btnAcessarSistema.UseVisualStyleBackColor = false;
            this.btnAcessarSistema.Click += new System.EventHandler(this.btnAcessarSistema_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(421, 346);
            this.Controls.Add(this.btnAcessarSistema);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.lblTextSenha);
            this.Controls.Add(this.lblTextUsuario);
            this.Controls.Add(this.lblTextInfoLogin);
            this.Controls.Add(this.lblTextLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextLogin;
        private System.Windows.Forms.Label lblTextInfoLogin;
        private System.Windows.Forms.Label lblTextUsuario;
        private System.Windows.Forms.Label lblTextSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button btnAcessarSistema;
    }
}