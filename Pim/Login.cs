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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxSenha.PasswordChar = '*';
        }

        
        private void validaUsuario()
        {
            if (textBoxUsuario.Text.Equals("aluno") && textBoxSenha.Text.Equals("aluno"))
            {
                this.Hide();
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, informe novamente.");
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
        }
        
        private void btnAcessarSistema_Click(object sender, EventArgs e)
        {
            validaUsuario();
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validaUsuario();
            }
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}