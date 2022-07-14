namespace Academia.Window
{
    partial class FrmAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.tbcDadosAlunos = new System.Windows.Forms.TabControl();
            this.tbpDadosPessoais = new System.Windows.Forms.TabPage();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAntebracoE = new System.Windows.Forms.Label();
            this.lblBracoE = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbcSaude = new System.Windows.Forms.TabControl();
            this.tbcMedicao = new System.Windows.Forms.TabPage();
            this.txtTornozeloE = new System.Windows.Forms.TextBox();
            this.txtPanturrilhaE = new System.Windows.Forms.TextBox();
            this.txtCoxaE = new System.Windows.Forms.TextBox();
            this.txtAntebracoE = new System.Windows.Forms.TextBox();
            this.txtBracoE = new System.Windows.Forms.TextBox();
            this.txtTornozeloD = new System.Windows.Forms.TextBox();
            this.txtPanturrilhaD = new System.Windows.Forms.TextBox();
            this.txtCoxaD = new System.Windows.Forms.TextBox();
            this.txtAntebracoD = new System.Windows.Forms.TextBox();
            this.txtBracoD = new System.Windows.Forms.TextBox();
            this.txtQuadril = new System.Windows.Forms.TextBox();
            this.txtCintura = new System.Windows.Forms.TextBox();
            this.txtPeitoral = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.grpSexo.SuspendLayout();
            this.tbcDadosAlunos.SuspendLayout();
            this.tbpDadosPessoais.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.tbcSaude.SuspendLayout();
            this.tbcMedicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(81, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeAluno.Location = new System.Drawing.Point(125, 20);
            this.txtNomeAluno.MaxLength = 60;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(178, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 75);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(89, 49);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(67, 101);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 16);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(34, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "M";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(46, 16);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(31, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.Text = "F";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbFeminino);
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Location = new System.Drawing.Point(125, 175);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(85, 42);
            this.grpSexo.TabIndex = 8;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // tbcDadosAlunos
            // 
            this.tbcDadosAlunos.Controls.Add(this.tbpDadosPessoais);
            this.tbcDadosAlunos.Location = new System.Drawing.Point(12, 12);
            this.tbcDadosAlunos.Name = "tbcDadosAlunos";
            this.tbcDadosAlunos.SelectedIndex = 0;
            this.tbcDadosAlunos.Size = new System.Drawing.Size(351, 310);
            this.tbcDadosAlunos.TabIndex = 9;
            // 
            // tbpDadosPessoais
            // 
            this.tbpDadosPessoais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpDadosPessoais.Controls.Add(this.mskEmail);
            this.tbpDadosPessoais.Controls.Add(this.lblEmail);
            this.tbpDadosPessoais.Controls.Add(this.grpStatus);
            this.tbpDadosPessoais.Controls.Add(this.mskDataNascimento);
            this.tbpDadosPessoais.Controls.Add(this.mskTelefone);
            this.tbpDadosPessoais.Controls.Add(this.mskCelular);
            this.tbpDadosPessoais.Controls.Add(this.mskCPF);
            this.tbpDadosPessoais.Controls.Add(this.lblCelular);
            this.tbpDadosPessoais.Controls.Add(this.grpSexo);
            this.tbpDadosPessoais.Controls.Add(this.lblNome);
            this.tbpDadosPessoais.Controls.Add(this.txtNomeAluno);
            this.tbpDadosPessoais.Controls.Add(this.lblTelefone);
            this.tbpDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.tbpDadosPessoais.Controls.Add(this.lblCPF);
            this.tbpDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tbpDadosPessoais.Name = "tbpDadosPessoais";
            this.tbpDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDadosPessoais.Size = new System.Drawing.Size(343, 284);
            this.tbpDadosPessoais.TabIndex = 0;
            this.tbpDadosPessoais.Text = "Dados Pessoais";
            // 
            // mskEmail
            // 
            this.mskEmail.Location = new System.Drawing.Point(125, 150);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.Size = new System.Drawing.Size(178, 20);
            this.mskEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(81, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-mail:";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdbInativo);
            this.grpStatus.Controls.Add(this.rdbAtivo);
            this.grpStatus.Location = new System.Drawing.Point(231, 49);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(73, 67);
            this.grpStatus.TabIndex = 15;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(6, 41);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbInativo.TabIndex = 1;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(6, 18);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAtivo.TabIndex = 0;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(125, 72);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mskDataNascimento.TabIndex = 3;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(125, 98);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 4;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(125, 124);
            this.mskCelular.Mask = "(99) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(100, 20);
            this.mskCelular.TabIndex = 5;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(125, 46);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 2;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(77, 127);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 9;
            this.lblCelular.Text = "Celular:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAltura.Location = new System.Drawing.Point(40, 23);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(579, 415);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(675, 415);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeso.Location = new System.Drawing.Point(43, 53);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(217, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Braço D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(196, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Antebraço D:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(221, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Coxa D:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(195, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Panturrilha D:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(198, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tornozelo D:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(10, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tornozelo E:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(7, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Panturrilha E:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(33, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Coxa E:";
            // 
            // lblAntebracoE
            // 
            this.lblAntebracoE.AutoSize = true;
            this.lblAntebracoE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAntebracoE.Location = new System.Drawing.Point(8, 123);
            this.lblAntebracoE.Name = "lblAntebracoE";
            this.lblAntebracoE.Size = new System.Drawing.Size(69, 13);
            this.lblAntebracoE.TabIndex = 8;
            this.lblAntebracoE.Text = "Antebraço E:";
            // 
            // lblBracoE
            // 
            this.lblBracoE.AutoSize = true;
            this.lblBracoE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBracoE.Location = new System.Drawing.Point(29, 97);
            this.lblBracoE.Name = "lblBracoE";
            this.lblBracoE.Size = new System.Drawing.Size(48, 13);
            this.lblBracoE.TabIndex = 7;
            this.lblBracoE.Text = "Braço E:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(223, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Cintura:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(221, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Peitoral:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(223, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Quadril:";
            // 
            // tbcSaude
            // 
            this.tbcSaude.Controls.Add(this.tbcMedicao);
            this.tbcSaude.Location = new System.Drawing.Point(406, 12);
            this.tbcSaude.Name = "tbcSaude";
            this.tbcSaude.SelectedIndex = 0;
            this.tbcSaude.Size = new System.Drawing.Size(386, 310);
            this.tbcSaude.TabIndex = 18;
            // 
            // tbcMedicao
            // 
            this.tbcMedicao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcMedicao.Controls.Add(this.txtTornozeloE);
            this.tbcMedicao.Controls.Add(this.txtPanturrilhaE);
            this.tbcMedicao.Controls.Add(this.txtCoxaE);
            this.tbcMedicao.Controls.Add(this.txtAntebracoE);
            this.tbcMedicao.Controls.Add(this.txtBracoE);
            this.tbcMedicao.Controls.Add(this.txtTornozeloD);
            this.tbcMedicao.Controls.Add(this.txtPanturrilhaD);
            this.tbcMedicao.Controls.Add(this.txtCoxaD);
            this.tbcMedicao.Controls.Add(this.txtAntebracoD);
            this.tbcMedicao.Controls.Add(this.txtBracoD);
            this.tbcMedicao.Controls.Add(this.txtQuadril);
            this.tbcMedicao.Controls.Add(this.txtCintura);
            this.tbcMedicao.Controls.Add(this.txtPeitoral);
            this.tbcMedicao.Controls.Add(this.txtPeso);
            this.tbcMedicao.Controls.Add(this.txtAltura);
            this.tbcMedicao.Controls.Add(this.label16);
            this.tbcMedicao.Controls.Add(this.label6);
            this.tbcMedicao.Controls.Add(this.label19);
            this.tbcMedicao.Controls.Add(this.lblAltura);
            this.tbcMedicao.Controls.Add(this.label20);
            this.tbcMedicao.Controls.Add(this.lblPeso);
            this.tbcMedicao.Controls.Add(this.label11);
            this.tbcMedicao.Controls.Add(this.label7);
            this.tbcMedicao.Controls.Add(this.label12);
            this.tbcMedicao.Controls.Add(this.label8);
            this.tbcMedicao.Controls.Add(this.label13);
            this.tbcMedicao.Controls.Add(this.label9);
            this.tbcMedicao.Controls.Add(this.lblAntebracoE);
            this.tbcMedicao.Controls.Add(this.label10);
            this.tbcMedicao.Controls.Add(this.lblBracoE);
            this.tbcMedicao.Location = new System.Drawing.Point(4, 22);
            this.tbcMedicao.Name = "tbcMedicao";
            this.tbcMedicao.Padding = new System.Windows.Forms.Padding(3);
            this.tbcMedicao.Size = new System.Drawing.Size(378, 284);
            this.tbcMedicao.TabIndex = 0;
            this.tbcMedicao.Text = "Medições";
            // 
            // txtTornozeloE
            // 
            this.txtTornozeloE.Location = new System.Drawing.Point(83, 198);
            this.txtTornozeloE.Name = "txtTornozeloE";
            this.txtTornozeloE.Size = new System.Drawing.Size(100, 20);
            this.txtTornozeloE.TabIndex = 19;
            // 
            // txtPanturrilhaE
            // 
            this.txtPanturrilhaE.Location = new System.Drawing.Point(83, 172);
            this.txtPanturrilhaE.Name = "txtPanturrilhaE";
            this.txtPanturrilhaE.Size = new System.Drawing.Size(100, 20);
            this.txtPanturrilhaE.TabIndex = 17;
            // 
            // txtCoxaE
            // 
            this.txtCoxaE.Location = new System.Drawing.Point(83, 146);
            this.txtCoxaE.Name = "txtCoxaE";
            this.txtCoxaE.Size = new System.Drawing.Size(100, 20);
            this.txtCoxaE.TabIndex = 15;
            // 
            // txtAntebracoE
            // 
            this.txtAntebracoE.Location = new System.Drawing.Point(83, 120);
            this.txtAntebracoE.Name = "txtAntebracoE";
            this.txtAntebracoE.Size = new System.Drawing.Size(100, 20);
            this.txtAntebracoE.TabIndex = 13;
            // 
            // txtBracoE
            // 
            this.txtBracoE.Location = new System.Drawing.Point(83, 94);
            this.txtBracoE.Name = "txtBracoE";
            this.txtBracoE.Size = new System.Drawing.Size(100, 20);
            this.txtBracoE.TabIndex = 11;
            // 
            // txtTornozeloD
            // 
            this.txtTornozeloD.Location = new System.Drawing.Point(272, 202);
            this.txtTornozeloD.Name = "txtTornozeloD";
            this.txtTornozeloD.Size = new System.Drawing.Size(100, 20);
            this.txtTornozeloD.TabIndex = 20;
            // 
            // txtPanturrilhaD
            // 
            this.txtPanturrilhaD.Location = new System.Drawing.Point(272, 176);
            this.txtPanturrilhaD.Name = "txtPanturrilhaD";
            this.txtPanturrilhaD.Size = new System.Drawing.Size(100, 20);
            this.txtPanturrilhaD.TabIndex = 18;
            // 
            // txtCoxaD
            // 
            this.txtCoxaD.Location = new System.Drawing.Point(272, 150);
            this.txtCoxaD.Name = "txtCoxaD";
            this.txtCoxaD.Size = new System.Drawing.Size(100, 20);
            this.txtCoxaD.TabIndex = 16;
            // 
            // txtAntebracoD
            // 
            this.txtAntebracoD.Location = new System.Drawing.Point(272, 124);
            this.txtAntebracoD.Name = "txtAntebracoD";
            this.txtAntebracoD.Size = new System.Drawing.Size(100, 20);
            this.txtAntebracoD.TabIndex = 14;
            // 
            // txtBracoD
            // 
            this.txtBracoD.Location = new System.Drawing.Point(272, 98);
            this.txtBracoD.Name = "txtBracoD";
            this.txtBracoD.Size = new System.Drawing.Size(100, 20);
            this.txtBracoD.TabIndex = 12;
            // 
            // txtQuadril
            // 
            this.txtQuadril.Location = new System.Drawing.Point(272, 72);
            this.txtQuadril.Name = "txtQuadril";
            this.txtQuadril.Size = new System.Drawing.Size(100, 20);
            this.txtQuadril.TabIndex = 10;
            // 
            // txtCintura
            // 
            this.txtCintura.Location = new System.Drawing.Point(272, 46);
            this.txtCintura.Name = "txtCintura";
            this.txtCintura.Size = new System.Drawing.Size(100, 20);
            this.txtCintura.TabIndex = 9;
            // 
            // txtPeitoral
            // 
            this.txtPeitoral.Location = new System.Drawing.Point(272, 20);
            this.txtPeitoral.Name = "txtPeitoral";
            this.txtPeitoral.Size = new System.Drawing.Size(100, 20);
            this.txtPeitoral.TabIndex = 8;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(83, 46);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 7;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(83, 17);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.tbcSaude);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.tbcDadosAlunos);
            this.Name = "FrmCadastroAluno";
            this.Text = "Cadastro de Aluno";
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.tbcDadosAlunos.ResumeLayout(false);
            this.tbpDadosPessoais.ResumeLayout(false);
            this.tbpDadosPessoais.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.tbcSaude.ResumeLayout(false);
            this.tbcMedicao.ResumeLayout(false);
            this.tbcMedicao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.TabPage tbpDadosPessoais;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.TabControl tbcDadosAlunos;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAntebracoE;
        private System.Windows.Forms.Label lblBracoE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TabControl tbcSaude;
        private System.Windows.Forms.TabPage tbcMedicao;
        private System.Windows.Forms.TextBox txtTornozeloE;
        private System.Windows.Forms.TextBox txtPanturrilhaE;
        private System.Windows.Forms.TextBox txtCoxaE;
        private System.Windows.Forms.TextBox txtAntebracoE;
        private System.Windows.Forms.TextBox txtBracoE;
        private System.Windows.Forms.TextBox txtTornozeloD;
        private System.Windows.Forms.TextBox txtPanturrilhaD;
        private System.Windows.Forms.TextBox txtCoxaD;
        private System.Windows.Forms.TextBox txtAntebracoD;
        private System.Windows.Forms.TextBox txtBracoD;
        private System.Windows.Forms.TextBox txtQuadril;
        private System.Windows.Forms.TextBox txtCintura;
        private System.Windows.Forms.TextBox txtPeitoral;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}