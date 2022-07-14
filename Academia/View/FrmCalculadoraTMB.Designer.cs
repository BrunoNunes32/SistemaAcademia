
namespace Academia.Window
{
    partial class FrmCalculadoraTMB
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GrpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.txtTMB = new System.Windows.Forms.TextBox();
            this.lblTMB = new System.Windows.Forms.Label();
            this.grpNDC = new System.Windows.Forms.GroupBox();
            this.txtAFI = new System.Windows.Forms.TextBox();
            this.txtAFM = new System.Windows.Forms.TextBox();
            this.txtNAF = new System.Windows.Forms.TextBox();
            this.lblAFI = new System.Windows.Forms.Label();
            this.lblAFM = new System.Windows.Forms.Label();
            this.lblNAF = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.grpSuplemento = new System.Windows.Forms.GroupBox();
            this.txtGordura = new System.Windows.Forms.TextBox();
            this.lblGordura = new System.Windows.Forms.Label();
            this.txtCarboidrato = new System.Windows.Forms.TextBox();
            this.llblCarbo = new System.Windows.Forms.Label();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.txtCreatina = new System.Windows.Forms.TextBox();
            this.txtProteina = new System.Windows.Forms.TextBox();
            this.lblAgua = new System.Windows.Forms.Label();
            this.lblCreatina = new System.Windows.Forms.Label();
            this.lblProteina = new System.Windows.Forms.Label();
            this.grpPreTreino = new System.Windows.Forms.GroupBox();
            this.txtGlicerol = new System.Windows.Forms.TextBox();
            this.txtBetaAlanina = new System.Windows.Forms.TextBox();
            this.lblGlicerol = new System.Windows.Forms.Label();
            this.lblBetaAlanina = new System.Windows.Forms.Label();
            this.txtTaurina = new System.Windows.Forms.TextBox();
            this.txtNitratos = new System.Windows.Forms.TextBox();
            this.lblTaurina = new System.Windows.Forms.Label();
            this.txtCafeina = new System.Windows.Forms.TextBox();
            this.lblCafeina = new System.Windows.Forms.Label();
            this.lblNitratos = new System.Windows.Forms.Label();
            this.txtCitrulinaMalato = new System.Windows.Forms.TextBox();
            this.lblCitrulinaMalato = new System.Windows.Forms.Label();
            this.grpGenero.SuspendLayout();
            this.GrpDadosBasicos.SuspendLayout();
            this.grpNDC.SuspendLayout();
            this.grpSuplemento.SuspendLayout();
            this.grpPreTreino.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbFeminino);
            this.grpGenero.Controls.Add(this.rdbMasculino);
            this.grpGenero.Location = new System.Drawing.Point(171, 28);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(59, 70);
            this.grpGenero.TabIndex = 0;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Gênero";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(6, 39);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(31, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.Text = "F";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(34, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "M";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(50, 28);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(50, 55);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 2;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(50, 82);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 31);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 58);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(12, 85);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Idade:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(294, 76);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(372, 76);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // GrpDadosBasicos
            // 
            this.GrpDadosBasicos.Controls.Add(this.txtPeso);
            this.GrpDadosBasicos.Controls.Add(this.txtAltura);
            this.GrpDadosBasicos.Controls.Add(this.txtIdade);
            this.GrpDadosBasicos.Controls.Add(this.grpGenero);
            this.GrpDadosBasicos.Controls.Add(this.lblIdade);
            this.GrpDadosBasicos.Controls.Add(this.lblPeso);
            this.GrpDadosBasicos.Controls.Add(this.lblAltura);
            this.GrpDadosBasicos.Location = new System.Drawing.Point(23, 26);
            this.GrpDadosBasicos.Name = "GrpDadosBasicos";
            this.GrpDadosBasicos.Size = new System.Drawing.Size(246, 116);
            this.GrpDadosBasicos.TabIndex = 9;
            this.GrpDadosBasicos.TabStop = false;
            this.GrpDadosBasicos.Text = "Dados Básicos";
            // 
            // txtTMB
            // 
            this.txtTMB.Enabled = false;
            this.txtTMB.Location = new System.Drawing.Point(151, 20);
            this.txtTMB.Name = "txtTMB";
            this.txtTMB.Size = new System.Drawing.Size(79, 20);
            this.txtTMB.TabIndex = 12;
            // 
            // lblTMB
            // 
            this.lblTMB.AutoSize = true;
            this.lblTMB.Location = new System.Drawing.Point(27, 28);
            this.lblTMB.Name = "lblTMB";
            this.lblTMB.Size = new System.Drawing.Size(118, 13);
            this.lblTMB.TabIndex = 11;
            this.lblTMB.Text = "Taxa Metabolica Basal:";
            // 
            // grpNDC
            // 
            this.grpNDC.Controls.Add(this.txtTMB);
            this.grpNDC.Controls.Add(this.lblTMB);
            this.grpNDC.Controls.Add(this.txtAFI);
            this.grpNDC.Controls.Add(this.txtAFM);
            this.grpNDC.Controls.Add(this.txtNAF);
            this.grpNDC.Controls.Add(this.lblAFI);
            this.grpNDC.Controls.Add(this.lblAFM);
            this.grpNDC.Controls.Add(this.lblNAF);
            this.grpNDC.Location = new System.Drawing.Point(23, 148);
            this.grpNDC.Name = "grpNDC";
            this.grpNDC.Size = new System.Drawing.Size(246, 139);
            this.grpNDC.TabIndex = 10;
            this.grpNDC.TabStop = false;
            this.grpNDC.Text = "Necessidades Diárias de Caloria";
            // 
            // txtAFI
            // 
            this.txtAFI.Enabled = false;
            this.txtAFI.Location = new System.Drawing.Point(151, 100);
            this.txtAFI.Name = "txtAFI";
            this.txtAFI.Size = new System.Drawing.Size(79, 20);
            this.txtAFI.TabIndex = 5;
            // 
            // txtAFM
            // 
            this.txtAFM.Enabled = false;
            this.txtAFM.Location = new System.Drawing.Point(151, 73);
            this.txtAFM.Name = "txtAFM";
            this.txtAFM.Size = new System.Drawing.Size(79, 20);
            this.txtAFM.TabIndex = 4;
            // 
            // txtNAF
            // 
            this.txtNAF.Enabled = false;
            this.txtNAF.Location = new System.Drawing.Point(151, 46);
            this.txtNAF.Name = "txtNAF";
            this.txtNAF.Size = new System.Drawing.Size(79, 20);
            this.txtNAF.TabIndex = 3;
            // 
            // lblAFI
            // 
            this.lblAFI.AutoSize = true;
            this.lblAFI.Location = new System.Drawing.Point(21, 103);
            this.lblAFI.Name = "lblAFI";
            this.lblAFI.Size = new System.Drawing.Size(124, 13);
            this.lblAFI.TabIndex = 2;
            this.lblAFI.Text = "Atividade Física Intensa:";
            // 
            // lblAFM
            // 
            this.lblAFM.AutoSize = true;
            this.lblAFM.Location = new System.Drawing.Point(8, 76);
            this.lblAFM.Name = "lblAFM";
            this.lblAFM.Size = new System.Drawing.Size(137, 13);
            this.lblAFM.TabIndex = 1;
            this.lblAFM.Text = "Atividade Física Moderada:";
            // 
            // lblNAF
            // 
            this.lblNAF.AutoSize = true;
            this.lblNAF.Location = new System.Drawing.Point(10, 49);
            this.lblNAF.Name = "lblNAF";
            this.lblNAF.Size = new System.Drawing.Size(135, 13);
            this.lblNAF.TabIndex = 0;
            this.lblNAF.Text = "Nenhuma Atividade Física:";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(453, 76);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Visible = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // grpSuplemento
            // 
            this.grpSuplemento.Controls.Add(this.txtGordura);
            this.grpSuplemento.Controls.Add(this.lblGordura);
            this.grpSuplemento.Controls.Add(this.txtCarboidrato);
            this.grpSuplemento.Controls.Add(this.llblCarbo);
            this.grpSuplemento.Controls.Add(this.txtAgua);
            this.grpSuplemento.Controls.Add(this.txtCreatina);
            this.grpSuplemento.Controls.Add(this.txtProteina);
            this.grpSuplemento.Controls.Add(this.lblAgua);
            this.grpSuplemento.Controls.Add(this.lblCreatina);
            this.grpSuplemento.Controls.Add(this.lblProteina);
            this.grpSuplemento.Location = new System.Drawing.Point(298, 132);
            this.grpSuplemento.Name = "grpSuplemento";
            this.grpSuplemento.Size = new System.Drawing.Size(200, 155);
            this.grpSuplemento.TabIndex = 12;
            this.grpSuplemento.TabStop = false;
            this.grpSuplemento.Text = "Suplementação";
            // 
            // txtGordura
            // 
            this.txtGordura.Location = new System.Drawing.Point(80, 124);
            this.txtGordura.Name = "txtGordura";
            this.txtGordura.Size = new System.Drawing.Size(100, 20);
            this.txtGordura.TabIndex = 9;
            // 
            // lblGordura
            // 
            this.lblGordura.AutoSize = true;
            this.lblGordura.Location = new System.Drawing.Point(26, 127);
            this.lblGordura.Name = "lblGordura";
            this.lblGordura.Size = new System.Drawing.Size(48, 13);
            this.lblGordura.TabIndex = 8;
            this.lblGordura.Text = "Gordura:";
            // 
            // txtCarboidrato
            // 
            this.txtCarboidrato.Location = new System.Drawing.Point(80, 98);
            this.txtCarboidrato.Name = "txtCarboidrato";
            this.txtCarboidrato.Size = new System.Drawing.Size(100, 20);
            this.txtCarboidrato.TabIndex = 7;
            // 
            // llblCarbo
            // 
            this.llblCarbo.AutoSize = true;
            this.llblCarbo.Location = new System.Drawing.Point(10, 101);
            this.llblCarbo.Name = "llblCarbo";
            this.llblCarbo.Size = new System.Drawing.Size(64, 13);
            this.llblCarbo.TabIndex = 6;
            this.llblCarbo.Text = "Carboidrato:";
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(80, 72);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(100, 20);
            this.txtAgua.TabIndex = 5;
            // 
            // txtCreatina
            // 
            this.txtCreatina.Location = new System.Drawing.Point(80, 46);
            this.txtCreatina.Name = "txtCreatina";
            this.txtCreatina.Size = new System.Drawing.Size(100, 20);
            this.txtCreatina.TabIndex = 4;
            // 
            // txtProteina
            // 
            this.txtProteina.Location = new System.Drawing.Point(80, 23);
            this.txtProteina.Name = "txtProteina";
            this.txtProteina.Size = new System.Drawing.Size(100, 20);
            this.txtProteina.TabIndex = 3;
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Location = new System.Drawing.Point(39, 75);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(35, 13);
            this.lblAgua.TabIndex = 2;
            this.lblAgua.Text = "Água:";
            // 
            // lblCreatina
            // 
            this.lblCreatina.AutoSize = true;
            this.lblCreatina.Location = new System.Drawing.Point(25, 49);
            this.lblCreatina.Name = "lblCreatina";
            this.lblCreatina.Size = new System.Drawing.Size(49, 13);
            this.lblCreatina.TabIndex = 1;
            this.lblCreatina.Text = "Creatina:";
            // 
            // lblProteina
            // 
            this.lblProteina.AutoSize = true;
            this.lblProteina.Location = new System.Drawing.Point(23, 26);
            this.lblProteina.Name = "lblProteina";
            this.lblProteina.Size = new System.Drawing.Size(51, 13);
            this.lblProteina.TabIndex = 0;
            this.lblProteina.Text = "Proteína:";
            // 
            // grpPreTreino
            // 
            this.grpPreTreino.Controls.Add(this.txtGlicerol);
            this.grpPreTreino.Controls.Add(this.txtBetaAlanina);
            this.grpPreTreino.Controls.Add(this.lblGlicerol);
            this.grpPreTreino.Controls.Add(this.lblBetaAlanina);
            this.grpPreTreino.Controls.Add(this.txtTaurina);
            this.grpPreTreino.Controls.Add(this.txtNitratos);
            this.grpPreTreino.Controls.Add(this.lblTaurina);
            this.grpPreTreino.Controls.Add(this.txtCafeina);
            this.grpPreTreino.Controls.Add(this.lblCafeina);
            this.grpPreTreino.Controls.Add(this.lblNitratos);
            this.grpPreTreino.Controls.Add(this.txtCitrulinaMalato);
            this.grpPreTreino.Controls.Add(this.lblCitrulinaMalato);
            this.grpPreTreino.Location = new System.Drawing.Point(23, 293);
            this.grpPreTreino.Name = "grpPreTreino";
            this.grpPreTreino.Size = new System.Drawing.Size(491, 76);
            this.grpPreTreino.TabIndex = 13;
            this.grpPreTreino.TabStop = false;
            this.grpPreTreino.Text = "Pré-Treino";
            // 
            // txtGlicerol
            // 
            this.txtGlicerol.Enabled = false;
            this.txtGlicerol.Location = new System.Drawing.Point(388, 24);
            this.txtGlicerol.Name = "txtGlicerol";
            this.txtGlicerol.Size = new System.Drawing.Size(87, 20);
            this.txtGlicerol.TabIndex = 24;
            // 
            // txtBetaAlanina
            // 
            this.txtBetaAlanina.Enabled = false;
            this.txtBetaAlanina.Location = new System.Drawing.Point(96, 50);
            this.txtBetaAlanina.Name = "txtBetaAlanina";
            this.txtBetaAlanina.Size = new System.Drawing.Size(87, 20);
            this.txtBetaAlanina.TabIndex = 22;
            // 
            // lblGlicerol
            // 
            this.lblGlicerol.AutoSize = true;
            this.lblGlicerol.Location = new System.Drawing.Point(336, 31);
            this.lblGlicerol.Name = "lblGlicerol";
            this.lblGlicerol.Size = new System.Drawing.Size(45, 13);
            this.lblGlicerol.TabIndex = 23;
            this.lblGlicerol.Text = "Glicerol:";
            // 
            // lblBetaAlanina
            // 
            this.lblBetaAlanina.AutoSize = true;
            this.lblBetaAlanina.Location = new System.Drawing.Point(20, 53);
            this.lblBetaAlanina.Name = "lblBetaAlanina";
            this.lblBetaAlanina.Size = new System.Drawing.Size(70, 13);
            this.lblBetaAlanina.TabIndex = 21;
            this.lblBetaAlanina.Text = "Beta-Alanina:";
            // 
            // txtTaurina
            // 
            this.txtTaurina.Enabled = false;
            this.txtTaurina.Location = new System.Drawing.Point(241, 24);
            this.txtTaurina.Name = "txtTaurina";
            this.txtTaurina.Size = new System.Drawing.Size(87, 20);
            this.txtTaurina.TabIndex = 20;
            // 
            // txtNitratos
            // 
            this.txtNitratos.Enabled = false;
            this.txtNitratos.Location = new System.Drawing.Point(241, 50);
            this.txtNitratos.Name = "txtNitratos";
            this.txtNitratos.Size = new System.Drawing.Size(87, 20);
            this.txtNitratos.TabIndex = 18;
            // 
            // lblTaurina
            // 
            this.lblTaurina.AutoSize = true;
            this.lblTaurina.Location = new System.Drawing.Point(189, 31);
            this.lblTaurina.Name = "lblTaurina";
            this.lblTaurina.Size = new System.Drawing.Size(46, 13);
            this.lblTaurina.TabIndex = 19;
            this.lblTaurina.Text = "Taurina:";
            // 
            // txtCafeina
            // 
            this.txtCafeina.Enabled = false;
            this.txtCafeina.Location = new System.Drawing.Point(388, 50);
            this.txtCafeina.Name = "txtCafeina";
            this.txtCafeina.Size = new System.Drawing.Size(87, 20);
            this.txtCafeina.TabIndex = 14;
            // 
            // lblCafeina
            // 
            this.lblCafeina.AutoSize = true;
            this.lblCafeina.Location = new System.Drawing.Point(334, 53);
            this.lblCafeina.Name = "lblCafeina";
            this.lblCafeina.Size = new System.Drawing.Size(48, 13);
            this.lblCafeina.TabIndex = 13;
            this.lblCafeina.Text = "Cafeína:";
            // 
            // lblNitratos
            // 
            this.lblNitratos.AutoSize = true;
            this.lblNitratos.Location = new System.Drawing.Point(189, 53);
            this.lblNitratos.Name = "lblNitratos";
            this.lblNitratos.Size = new System.Drawing.Size(46, 13);
            this.lblNitratos.TabIndex = 17;
            this.lblNitratos.Text = "Nitratos:";
            // 
            // txtCitrulinaMalato
            // 
            this.txtCitrulinaMalato.Enabled = false;
            this.txtCitrulinaMalato.Location = new System.Drawing.Point(96, 24);
            this.txtCitrulinaMalato.Name = "txtCitrulinaMalato";
            this.txtCitrulinaMalato.Size = new System.Drawing.Size(87, 20);
            this.txtCitrulinaMalato.TabIndex = 16;
            // 
            // lblCitrulinaMalato
            // 
            this.lblCitrulinaMalato.AutoSize = true;
            this.lblCitrulinaMalato.Location = new System.Drawing.Point(8, 31);
            this.lblCitrulinaMalato.Name = "lblCitrulinaMalato";
            this.lblCitrulinaMalato.Size = new System.Drawing.Size(82, 13);
            this.lblCitrulinaMalato.TabIndex = 15;
            this.lblCitrulinaMalato.Text = "Citrulina Malato:";
            // 
            // FrmCalculadoraTMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 392);
            this.Controls.Add(this.grpPreTreino);
            this.Controls.Add(this.grpSuplemento);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.grpNDC);
            this.Controls.Add(this.GrpDadosBasicos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCalcular);
            this.Name = "FrmCalculadoraTMB";
            this.Text = "Calculadora TMB";
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.GrpDadosBasicos.ResumeLayout(false);
            this.GrpDadosBasicos.PerformLayout();
            this.grpNDC.ResumeLayout(false);
            this.grpNDC.PerformLayout();
            this.grpSuplemento.ResumeLayout(false);
            this.grpSuplemento.PerformLayout();
            this.grpPreTreino.ResumeLayout(false);
            this.grpPreTreino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox GrpDadosBasicos;
        private System.Windows.Forms.GroupBox grpNDC;
        private System.Windows.Forms.TextBox txtAFI;
        private System.Windows.Forms.TextBox txtAFM;
        private System.Windows.Forms.TextBox txtNAF;
        private System.Windows.Forms.Label lblAFI;
        private System.Windows.Forms.Label lblAFM;
        private System.Windows.Forms.Label lblNAF;
        private System.Windows.Forms.Label lblTMB;
        private System.Windows.Forms.TextBox txtTMB;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.GroupBox grpSuplemento;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.Label lblCreatina;
        private System.Windows.Forms.Label lblProteina;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.TextBox txtCreatina;
        private System.Windows.Forms.TextBox txtProteina;
        private System.Windows.Forms.TextBox txtGordura;
        private System.Windows.Forms.Label lblGordura;
        private System.Windows.Forms.TextBox txtCarboidrato;
        private System.Windows.Forms.Label llblCarbo;
        private System.Windows.Forms.GroupBox grpPreTreino;
        private System.Windows.Forms.TextBox txtGlicerol;
        private System.Windows.Forms.TextBox txtBetaAlanina;
        private System.Windows.Forms.Label lblGlicerol;
        private System.Windows.Forms.Label lblBetaAlanina;
        private System.Windows.Forms.TextBox txtTaurina;
        private System.Windows.Forms.TextBox txtNitratos;
        private System.Windows.Forms.Label lblTaurina;
        private System.Windows.Forms.TextBox txtCafeina;
        private System.Windows.Forms.Label lblCafeina;
        private System.Windows.Forms.Label lblNitratos;
        private System.Windows.Forms.TextBox txtCitrulinaMalato;
        private System.Windows.Forms.Label lblCitrulinaMalato;
    }
}

