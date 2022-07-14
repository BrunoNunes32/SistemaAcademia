namespace Academia.Window
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.BtnAdicionarAluno = new System.Windows.Forms.Button();
            this.BtnCalcauladoraTMB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdicionarAluno
            // 
            this.BtnAdicionarAluno.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdicionarAluno.BackgroundImage = global::Academia.Properties.Resources.adicionarAluno;
            this.BtnAdicionarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdicionarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdicionarAluno.Location = new System.Drawing.Point(157, 61);
            this.BtnAdicionarAluno.Name = "BtnAdicionarAluno";
            this.BtnAdicionarAluno.Size = new System.Drawing.Size(70, 73);
            this.BtnAdicionarAluno.TabIndex = 1;
            this.BtnAdicionarAluno.UseVisualStyleBackColor = false;
            this.BtnAdicionarAluno.Click += new System.EventHandler(this.BtnAdicionarAluno_Click);
            // 
            // BtnCalcauladoraTMB
            // 
            this.BtnCalcauladoraTMB.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalcauladoraTMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalcauladoraTMB.Image = global::Academia.Properties.Resources.calculadora;
            this.BtnCalcauladoraTMB.Location = new System.Drawing.Point(67, 61);
            this.BtnCalcauladoraTMB.Name = "BtnCalcauladoraTMB";
            this.BtnCalcauladoraTMB.Size = new System.Drawing.Size(71, 73);
            this.BtnCalcauladoraTMB.TabIndex = 0;
            this.BtnCalcauladoraTMB.UseVisualStyleBackColor = false;
            this.BtnCalcauladoraTMB.Click += new System.EventHandler(this.BtnCalcauladoraTMB_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdicionarAluno);
            this.Controls.Add(this.BtnCalcauladoraTMB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcauladoraTMB;
        private System.Windows.Forms.Button BtnAdicionarAluno;
    }
}