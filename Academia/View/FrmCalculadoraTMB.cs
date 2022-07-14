using System;
using System.Threading;
using System.Windows.Forms;

namespace Academia.Window
{
    public partial class FrmCalculadoraTMB : Form
    {
        Thread thread;
        public FrmCalculadoraTMB()
        {
            InitializeComponent();
        }

        public int peso, altura, idade;
        public float TMB;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(VoltarMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void VoltarMenu()
        {
            Application.Run(new FrmMenu());
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //LIMPANDO AS TXT's
            txtAltura.Text = "";
            txtIdade.Text = "";
            txtPeso.Text = "";

            txtAFI.Text = "";
            txtAFM.Text = "";
            txtNAF.Text = "";
            txtTMB.Text = "";

            txtBetaAlanina.Text = "";
            txtCafeina.Text =  "";
            txtCitrulinaMalato.Text = "";
            txtGlicerol.Text = "";
            txtTaurina.Text = "";
            txtNitratos.Text = "";

            //DEIXA BOTÃO INVISÍVEL NOVAMENTE
            BtnLimpar.Visible = false;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Convertendo o dado no txt para inteiro - válido para conversão para inteiros
            peso = Convert.ToInt32(txtPeso.Text);
            altura = Convert.ToInt32(txtAltura.Text);
            idade = Convert.ToInt32(txtIdade.Text);

            //MASCULINO
            if (rdbMasculino.Checked)
            {
                rdbFeminino.Checked = false;

                //Determinando o dado como float
                TMB = (float)/*<-CAST*/(66 + (13.7 * peso) + (5 * altura) - (6.8 * idade));//CALCULO DA TMB
                txtTMB.Text = TMB.ToString();

                txtNAF.Text = Convert.ToString((float)(TMB + (TMB * 0.25)));//NENHUMA
                txtAFM.Text = Convert.ToString((float)(TMB + (TMB * 0.35)));//MODERADA
                txtAFI.Text = Convert.ToString((float)(TMB + (TMB * 0.45)));//INTENSO
            }
            //FEMININO
            if (rdbFeminino.Checked)
            {
                rdbMasculino.Checked = false;

                TMB = (float)(655 + (9.6 * peso) + (1.7 * altura) - (4.7 * idade));//CALCULO DA TMB
                txtTMB.Text = TMB.ToString();

                //CONVERTENDO O CÁLCULO EM UMA STRING PARA QUE POSSA SER COLOCADO NA TXT
                txtNAF.Text = Convert.ToString((float)(TMB + (TMB * 0.20)));//NENHUMA
                txtAFM.Text = Convert.ToString((float)(TMB + (TMB * 0.30)));//MODERADA
                txtAFI.Text = Convert.ToString((float)(TMB + (TMB * 0.40)));//INTENSO
            }

            //CÁLCULO DA CREATINA: MÍNIMO(0.03) E MÁXIMO(0.07) por peso
            txtCreatina.Text = Convert.ToString((float)(0.03 * peso)) + " g | " + Convert.ToString((float)(0.07 * peso)) + " g";

            //*********************************CÁLCULO DO PRÉ-TREINO*****************************************//
            txtBetaAlanina.Text = Convert.ToString((float)(0.032 * peso)) + " g | " + Convert.ToString((float)(0.064 * peso)) + " g";// CÁLCULO DA BETA-ALANINA: 3,2g/d A 6,4g/d
            txtCafeina.Text = Convert.ToString((float)(0.003 * peso)) + " mg | " + Convert.ToString((float)(0.006 * peso)) + " mg";//CÁCULO DA CAFEÍNA: 3mg/kg A 6mg/kg            
            txtCitrulinaMalato.Text = "6 g | 8 g";//CITRULINA MALATO: 6g A 8g            
            txtGlicerol.Text = Convert.ToString((float)(0.02 * peso)) + " g | " + Convert.ToString((float)(0.04 * peso)) + " g";//GLICEROL: 2g / kg A 4g / kg            
            txtTaurina.Text = Convert.ToString((float)(0.05 * peso)) + " g";//TAURINA: 0,5G/kg
            txtNitratos.Text = Convert.ToString((float)(0.004 * peso)) + " mg | " + Convert.ToString((float)(0.010 * peso)) + " mg"; //NITRATOS: 4mg/kg A 10mg/kg

            BtnLimpar.Visible = true;
        }
    }
}
