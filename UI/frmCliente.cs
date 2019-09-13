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
        }

        private void btGRAVAR_Click(object sender, EventArgs e)
        {

        }
    }
}
