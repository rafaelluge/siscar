namespace UI
{
    partial class frmClientes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCOD_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtDATA_NASC = new System.Windows.Forms.MaskedTextBox();
            this.texENDERECO = new System.Windows.Forms.TextBox();
            this.txtBAIRRO = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCIDADE = new System.Windows.Forms.TextBox();
            this.txtFONE1 = new System.Windows.Forms.MaskedTextBox();
            this.txtFONE2 = new System.Windows.Forms.MaskedTextBox();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 362);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbESTADO);
            this.tabPage1.Controls.Add(this.txtFONE2);
            this.tabPage1.Controls.Add(this.txtFONE1);
            this.tabPage1.Controls.Add(this.txtCIDADE);
            this.tabPage1.Controls.Add(this.txtCEP);
            this.tabPage1.Controls.Add(this.txtBAIRRO);
            this.tabPage1.Controls.Add(this.texENDERECO);
            this.tabPage1.Controls.Add(this.txtDATA_NASC);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.txtNOME);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCOD_CLIENTE);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 52);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // txtCOD_CLIENTE
            // 
            this.txtCOD_CLIENTE.Location = new System.Drawing.Point(16, 22);
            this.txtCOD_CLIENTE.Mask = "00000";
            this.txtCOD_CLIENTE.Name = "txtCOD_CLIENTE";
            this.txtCOD_CLIENTE.PromptChar = ' ';
            this.txtCOD_CLIENTE.Size = new System.Drawing.Size(100, 20);
            this.txtCOD_CLIENTE.TabIndex = 3;
            this.txtCOD_CLIENTE.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Nasc.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(537, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Fone 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Fone 2";
            // 
            // txtNOME
            // 
            this.txtNOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNOME.Location = new System.Drawing.Point(20, 83);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(300, 20);
            this.txtNOME.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(370, 83);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtDATA_NASC
            // 
            this.txtDATA_NASC.Location = new System.Drawing.Point(540, 83);
            this.txtDATA_NASC.Mask = "00/00/00";
            this.txtDATA_NASC.Name = "txtDATA_NASC";
            this.txtDATA_NASC.Size = new System.Drawing.Size(100, 20);
            this.txtDATA_NASC.TabIndex = 5;
            // 
            // texENDERECO
            // 
            this.texENDERECO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.texENDERECO.Location = new System.Drawing.Point(20, 139);
            this.texENDERECO.Name = "texENDERECO";
            this.texENDERECO.Size = new System.Drawing.Size(300, 20);
            this.texENDERECO.TabIndex = 6;
            // 
            // txtBAIRRO
            // 
            this.txtBAIRRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBAIRRO.Location = new System.Drawing.Point(370, 139);
            this.txtBAIRRO.Name = "txtBAIRRO";
            this.txtBAIRRO.Size = new System.Drawing.Size(250, 20);
            this.txtBAIRRO.TabIndex = 7;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(20, 195);
            this.txtCEP.Mask = "00,000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 8;
            // 
            // txtCIDADE
            // 
            this.txtCIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCIDADE.Location = new System.Drawing.Point(171, 195);
            this.txtCIDADE.Name = "txtCIDADE";
            this.txtCIDADE.Size = new System.Drawing.Size(311, 20);
            this.txtCIDADE.TabIndex = 9;
            // 
            // txtFONE1
            // 
            this.txtFONE1.Location = new System.Drawing.Point(20, 254);
            this.txtFONE1.Mask = "(00)00000-0000";
            this.txtFONE1.Name = "txtFONE1";
            this.txtFONE1.Size = new System.Drawing.Size(100, 20);
            this.txtFONE1.TabIndex = 11;
            // 
            // txtFONE2
            // 
            this.txtFONE2.Location = new System.Drawing.Point(171, 254);
            this.txtFONE2.Mask = "(00)00000-0000";
            this.txtFONE2.Name = "txtFONE2";
            this.txtFONE2.Size = new System.Drawing.Size(100, 20);
            this.txtFONE2.TabIndex = 12;
            // 
            // cbESTADO
            // 
            this.cbESTADO.FormattingEnabled = true;
            this.cbESTADO.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PR",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbESTADO.Location = new System.Drawing.Point(540, 195);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(80, 21);
            this.cbESTADO.TabIndex = 10;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 362);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox txtFONE2;
        private System.Windows.Forms.MaskedTextBox txtFONE1;
        private System.Windows.Forms.TextBox txtCIDADE;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtBAIRRO;
        private System.Windows.Forms.TextBox texENDERECO;
        private System.Windows.Forms.MaskedTextBox txtDATA_NASC;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCOD_CLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbESTADO;
    }
}