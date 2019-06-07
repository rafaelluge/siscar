using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar o SisCar?", "SisCar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            
                Application.Exit();
        }

        public string usuario;

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar o SisCar?", "SisCar", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                
                Application.Exit();

        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Bem-Vindo " + usuario + "!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Data:  "+DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = "Hora:  "+DateTime.Now.ToShortTimeString();

        }

        private void caulculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

       

        private void consultaDetranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "https://www.portaldetransito.rs.gov.br/dtw2/app/servico/vei/consulta-veiculo-form.xhtml");
        }

        private void exibiBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exibiBarraToolStripMenuItem.Checked)
                toolStrip1.Show();
            else
                toolStrip1.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            DialogResult dlg1 = new DialogResult();
            
            if (this.BackgroundImage != null)
            {
                dlg1 = MessageBox.Show("Desja descartar o papel de parede atual?", 
                       "Cor de Fundo", MessageBoxButtons.YesNo,MessageBoxIcon.Question, 
                       MessageBoxDefaultButton.Button2);
            };

            if ((dlg1 == DialogResult.Yes) || (dlg1 == DialogResult.None))
            {
                colorDialog1.ShowDialog();
                this.BackColor = colorDialog1.Color;
                this.BackgroundImage = null;
            };
            
        }

        private void papelDeParedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Seleciona a figura para o fundo";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de Imagen | (*.bmp; *.jpg; *.gif) | Todos os arquivos |*.*";
            openFileDialog1.Multiselect = false;


            if (openFileDialog1.FileName != "")
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                
        }
    }
}
