﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Exit();
        }

        public string usuario;

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
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
    }
}
