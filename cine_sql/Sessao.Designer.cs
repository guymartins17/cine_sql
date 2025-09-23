namespace cine_sql
{
    partial class Sessao
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
            this.lblTituloSessoes = new System.Windows.Forms.Label();
            this.dgvSessoes = new System.Windows.Forms.DataGridView();
            this.grbSessoesCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrarSessoes = new System.Windows.Forms.Button();
            this.lblPrecoSessao = new System.Windows.Forms.Label();
            this.txbPrecoSessao = new System.Windows.Forms.TextBox();
            this.txbFilmeSessao = new System.Windows.Forms.TextBox();
            this.lblFilmeSessao = new System.Windows.Forms.Label();
            this.txbHorarioSessao = new System.Windows.Forms.TextBox();
            this.lblHorarioSessao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoes)).BeginInit();
            this.grbSessoesCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloSessoes
            // 
            this.lblTituloSessoes.AutoSize = true;
            this.lblTituloSessoes.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSessoes.ForeColor = System.Drawing.Color.White;
            this.lblTituloSessoes.Location = new System.Drawing.Point(199, 21);
            this.lblTituloSessoes.Name = "lblTituloSessoes";
            this.lblTituloSessoes.Size = new System.Drawing.Size(121, 45);
            this.lblTituloSessoes.TabIndex = 0;
            this.lblTituloSessoes.Text = "Sessões";
            // 
            // dgvSessoes
            // 
            this.dgvSessoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessoes.Location = new System.Drawing.Point(258, 85);
            this.dgvSessoes.Name = "dgvSessoes";
            this.dgvSessoes.Size = new System.Drawing.Size(284, 319);
            this.dgvSessoes.TabIndex = 1;
            // 
            // grbSessoesCadastrar
            // 
            this.grbSessoesCadastrar.BackColor = System.Drawing.Color.White;
            this.grbSessoesCadastrar.Controls.Add(this.txbHorarioSessao);
            this.grbSessoesCadastrar.Controls.Add(this.lblHorarioSessao);
            this.grbSessoesCadastrar.Controls.Add(this.txbFilmeSessao);
            this.grbSessoesCadastrar.Controls.Add(this.lblFilmeSessao);
            this.grbSessoesCadastrar.Controls.Add(this.txbPrecoSessao);
            this.grbSessoesCadastrar.Controls.Add(this.lblPrecoSessao);
            this.grbSessoesCadastrar.Controls.Add(this.btnCadastrarSessoes);
            this.grbSessoesCadastrar.Location = new System.Drawing.Point(4, 85);
            this.grbSessoesCadastrar.Name = "grbSessoesCadastrar";
            this.grbSessoesCadastrar.Size = new System.Drawing.Size(248, 319);
            this.grbSessoesCadastrar.TabIndex = 2;
            this.grbSessoesCadastrar.TabStop = false;
            this.grbSessoesCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrarSessoes
            // 
            this.btnCadastrarSessoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSessoes.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarSessoes.Location = new System.Drawing.Point(27, 221);
            this.btnCadastrarSessoes.Name = "btnCadastrarSessoes";
            this.btnCadastrarSessoes.Size = new System.Drawing.Size(186, 58);
            this.btnCadastrarSessoes.TabIndex = 0;
            this.btnCadastrarSessoes.Text = "Cadastrar";
            this.btnCadastrarSessoes.UseVisualStyleBackColor = true;
            this.btnCadastrarSessoes.Click += new System.EventHandler(this.btnCadastrarSessoes_Click);
            // 
            // lblPrecoSessao
            // 
            this.lblPrecoSessao.AutoSize = true;
            this.lblPrecoSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoSessao.Location = new System.Drawing.Point(19, 111);
            this.lblPrecoSessao.Name = "lblPrecoSessao";
            this.lblPrecoSessao.Size = new System.Drawing.Size(54, 20);
            this.lblPrecoSessao.TabIndex = 1;
            this.lblPrecoSessao.Text = "Preço:";
            // 
            // txbPrecoSessao
            // 
            this.txbPrecoSessao.Location = new System.Drawing.Point(82, 113);
            this.txbPrecoSessao.Name = "txbPrecoSessao";
            this.txbPrecoSessao.Size = new System.Drawing.Size(148, 20);
            this.txbPrecoSessao.TabIndex = 2;
            // 
            // txbFilmeSessao
            // 
            this.txbFilmeSessao.Location = new System.Drawing.Point(82, 64);
            this.txbFilmeSessao.Name = "txbFilmeSessao";
            this.txbFilmeSessao.Size = new System.Drawing.Size(148, 20);
            this.txbFilmeSessao.TabIndex = 4;
            // 
            // lblFilmeSessao
            // 
            this.lblFilmeSessao.AutoSize = true;
            this.lblFilmeSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmeSessao.Location = new System.Drawing.Point(22, 62);
            this.lblFilmeSessao.Name = "lblFilmeSessao";
            this.lblFilmeSessao.Size = new System.Drawing.Size(51, 20);
            this.lblFilmeSessao.TabIndex = 3;
            this.lblFilmeSessao.Text = "Filme:";
            // 
            // txbHorarioSessao
            // 
            this.txbHorarioSessao.Location = new System.Drawing.Point(82, 161);
            this.txbHorarioSessao.Name = "txbHorarioSessao";
            this.txbHorarioSessao.Size = new System.Drawing.Size(148, 20);
            this.txbHorarioSessao.TabIndex = 6;
            // 
            // lblHorarioSessao
            // 
            this.lblHorarioSessao.AutoSize = true;
            this.lblHorarioSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioSessao.Location = new System.Drawing.Point(19, 159);
            this.lblHorarioSessao.Name = "lblHorarioSessao";
            this.lblHorarioSessao.Size = new System.Drawing.Size(65, 20);
            this.lblHorarioSessao.TabIndex = 5;
            this.lblHorarioSessao.Text = "Horário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cine_sql.Properties.Resources.pipoca;
            this.pictureBox1.Location = new System.Drawing.Point(297, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Sessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(545, 429);
            this.Controls.Add(this.grbSessoesCadastrar);
            this.Controls.Add(this.dgvSessoes);
            this.Controls.Add(this.lblTituloSessoes);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimizeBox = false;
            this.Name = "Sessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessões";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoes)).EndInit();
            this.grbSessoesCadastrar.ResumeLayout(false);
            this.grbSessoesCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloSessoes;
        private System.Windows.Forms.DataGridView dgvSessoes;
        private System.Windows.Forms.GroupBox grbSessoesCadastrar;
        private System.Windows.Forms.TextBox txbPrecoSessao;
        private System.Windows.Forms.Label lblPrecoSessao;
        private System.Windows.Forms.Button btnCadastrarSessoes;
        private System.Windows.Forms.TextBox txbFilmeSessao;
        private System.Windows.Forms.Label lblFilmeSessao;
        private System.Windows.Forms.TextBox txbHorarioSessao;
        private System.Windows.Forms.Label lblHorarioSessao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}