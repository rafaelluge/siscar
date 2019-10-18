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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void ZeraCampos() 
        {
            //Limpa Todos os campos
            txtNOME.Clear();
            txtCPF.Clear();
            txtDATA_NASC.Clear();
            txtENDERECO.Clear();
            txtBAIRRO.Clear();
            txtCEP.Clear();
            txtCIDADE.Clear();
            txtFONE1.Clear();
            txtFONE2.Clear();
            cbESTADO.SelectedIndex = -1;
            rbMASCULINO.Checked = false;
            rbFEMININO.Checked = false;
            ckRESTRICAO.Checked = false;
            txtCOD_CLIENTE.Enabled = false;
            txtNOME.Focus();
        }

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNOME_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_KeyDown(object sender, KeyEventArgs e)
        {
           
            /*if (e.KeyCode == Keys.Escape)
                ZeraCampos();
            
            if (e.KeyCode == Keys.Escape)
                SendKeys.Send("{TAB}");*/ 
            
            ClienteBLL clientebll = new ClienteBLL();
            Cliente cliente = new Cliente();

            clientebll.inserirCodigo(cliente);
            txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
            btEXCLUIR.Enabled = false;
            txtCOD_CLIENTE.Enabled = false;
            

        }

        private void btGRAVAR_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBLL clientebll = new ClienteBLL();

            try 
            {
                cliente.Cod_Cliente = txtCOD_CLIENTE.Text;
                cliente.Nome = txtNOME.Text;
                cliente.CPF = txtNOME.Text;
                cliente.Data_Nasc = txtCPF.Text;
                cliente.Endereco = txtENDERECO.Text;
                cliente.Bairro = txtBAIRRO.Text;
                cliente.CEP = txtCEP.Text;
                cliente.Cidade = txtCIDADE.Text;
                cliente.Fone1 = txtFONE1.Text;
                cliente.Fone2 = txtFONE2.Text;
                cliente.Estado = cbESTADO.Text;

                if (rbMASCULINO.Checked)
                    cliente.Sexo = "M";
                else
                    cliente.Sexo = "F";

                if (ckRESTRICAO.Checked)
                    cliente.Resticao = "S";
                else
                    cliente.Resticao = "N";

                clientebll.verificarCampos(cliente);
                clientebll.inserirCliente(cliente);

                MessageBox.Show("O usuário" + cliente.Nome + "foi cadastro!", "Cadastro Efetuado com sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                ZeraCampos();
                clientebll.inserirCodigo(cliente);
                txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            }

        private void txtDATA_NASC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        }
    
}
