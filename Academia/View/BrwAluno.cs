using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.View
{
    public partial class BrwAluno : Form
    {
        public BrwAluno()
        {
            InitializeComponent();
        }

        private void BrwAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaAcademiaDataSet.tblAluno'. Você pode movê-la ou removê-la conforme necessário.
            this.tblAlunoTableAdapter.Fill(this.sistemaAcademiaDataSet.tblAluno);

        }


    }
}
