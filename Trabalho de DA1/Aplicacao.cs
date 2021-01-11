using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_DA1
{
    public partial class frmAplicacao : Form
    {
        public frmAplicacao()
        {
            InitializeComponent();
        }

        private void frmAplicacao_Load(object sender, EventArgs e)
        {

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coiso & Tal!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistarJogador_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(1);
            btnAcederArena.Enabled = false;
        }

        private void btnConsultarJogador_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(3);
        }

        private void btnAcederArena_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(2);
            
        }

        private void btnAcederLoja_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(4);
        }

        private void btnRegressarRegisto_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(0);
        }

        private void btnRegressarArena_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(0);
        }

        private void btnRegressarConsultar_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(0);
        }

        private void btnRegressarLoja_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(0);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnAcederArena.Enabled = true;
        }
    }
}
