using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using BLL;

namespace UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             try
             {    
                Usuario usuario = new Usuario();
                usuario.Login = txtUsuario.Text;
                usuario.Senha = txtSenha.Text ;

                LoginBLL usuarioBll = new LoginBLL();

                if (usuarioBll.verificarLogin(usuario))
                {
                    Login.User = usuario.Login;
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.usuario = usuario.Login;
                    frmPrincipal.Show();
                    this.Dispose(false);
                }

                else
                {
                    MessageBox.Show("Usuário ou senha Incorreto! Tente novamente!", "Autentificaçao",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
