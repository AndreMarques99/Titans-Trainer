﻿using System;
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

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistarJogador_Click(object sender, EventArgs e)
        {
            tabAplicacao.SelectTab(1);
        }
    }
}