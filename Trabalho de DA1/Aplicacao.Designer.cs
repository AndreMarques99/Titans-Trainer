namespace Trabalho_de_DA1
{
    partial class frmAplicacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAplicacao));
            this.tabAplicacao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultarJogador = new System.Windows.Forms.Button();
            this.btnRegistarJogador = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabAplicacao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAplicacao
            // 
            this.tabAplicacao.Controls.Add(this.tabPage1);
            this.tabAplicacao.Controls.Add(this.tabPage2);
            this.tabAplicacao.Controls.Add(this.tabPage3);
            this.tabAplicacao.Controls.Add(this.tabPage4);
            this.tabAplicacao.Controls.Add(this.tabPage5);
            this.tabAplicacao.Location = new System.Drawing.Point(-3, -1);
            this.tabAplicacao.Name = "tabAplicacao";
            this.tabAplicacao.SelectedIndex = 0;
            this.tabAplicacao.Size = new System.Drawing.Size(1315, 586);
            this.tabAplicacao.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Maroon;
            this.tabPage1.Controls.Add(this.btnCreditos);
            this.tabPage1.Controls.Add(this.btnSair);
            this.tabPage1.Controls.Add(this.btnConsultarJogador);
            this.tabPage1.Controls.Add(this.btnRegistarJogador);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1307, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PaginaInicial";
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.White;
            this.btnCreditos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreditos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreditos.Location = new System.Drawing.Point(240, 414);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(124, 70);
            this.btnCreditos.TabIndex = 8;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.UseVisualStyleBackColor = false;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.Location = new System.Drawing.Point(71, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultarJogador
            // 
            this.btnConsultarJogador.BackColor = System.Drawing.Color.White;
            this.btnConsultarJogador.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnConsultarJogador.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultarJogador.Location = new System.Drawing.Point(240, 295);
            this.btnConsultarJogador.Name = "btnConsultarJogador";
            this.btnConsultarJogador.Size = new System.Drawing.Size(124, 76);
            this.btnConsultarJogador.TabIndex = 5;
            this.btnConsultarJogador.Text = "Consultar \r\nJogador";
            this.btnConsultarJogador.UseVisualStyleBackColor = false;
            // 
            // btnRegistarJogador
            // 
            this.btnRegistarJogador.BackColor = System.Drawing.Color.White;
            this.btnRegistarJogador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistarJogador.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistarJogador.Location = new System.Drawing.Point(71, 295);
            this.btnRegistarJogador.Name = "btnRegistarJogador";
            this.btnRegistarJogador.Size = new System.Drawing.Size(124, 76);
            this.btnRegistarJogador.TabIndex = 4;
            this.btnRegistarJogador.Text = "Registar \r\nJogador";
            this.btnRegistarJogador.UseVisualStyleBackColor = false;
            this.btnRegistarJogador.Click += new System.EventHandler(this.btnRegistarJogador_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(34, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escolha uma das seguintes opções:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aqui poderá gerir e simular\r\no comportamento do seu jogador.\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(200, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem vindo ao TitansTrainer!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RegistarJogador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1043, 556);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arena";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1043, 556);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ConsultarJogador";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1043, 556);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Loja";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // frmAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 583);
            this.Controls.Add(this.tabAplicacao);
            this.Name = "frmAplicacao";
            this.Text = "TitansTrainer";
            this.Load += new System.EventHandler(this.frmAplicacao_Load);
            this.tabAplicacao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAplicacao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultarJogador;
        private System.Windows.Forms.Button btnRegistarJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

