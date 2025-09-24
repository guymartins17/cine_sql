namespace cine_sql
{
    partial class Ingresso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresso));
            this.dgvSessoes = new System.Windows.Forms.DataGridView();
            this.dgvIngressos = new System.Windows.Forms.DataGridView();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnCadastrarIngressos = new System.Windows.Forms.Button();
            this.txbQtdIngressos = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTituloIngressos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngressos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSessoes
            // 
            this.dgvSessoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessoes.Location = new System.Drawing.Point(331, 88);
            this.dgvSessoes.Name = "dgvSessoes";
            this.dgvSessoes.Size = new System.Drawing.Size(320, 182);
            this.dgvSessoes.TabIndex = 0;
            this.dgvSessoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessoes_CellClick);
            // 
            // dgvIngressos
            // 
            this.dgvIngressos.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngressos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngressos.Location = new System.Drawing.Point(12, 375);
            this.dgvIngressos.Name = "dgvIngressos";
            this.dgvIngressos.Size = new System.Drawing.Size(639, 182);
            this.dgvIngressos.TabIndex = 2;
            this.dgvIngressos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngressos_CellClick);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(5, 88);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(320, 182);
            this.dgvUsuarios.TabIndex = 3;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.BackColor = System.Drawing.Color.White;
            this.grbInformacoes.Controls.Add(this.btnCadastrarIngressos);
            this.grbInformacoes.Controls.Add(this.txbQtdIngressos);
            this.grbInformacoes.Controls.Add(this.lblQuantidade);
            this.grbInformacoes.Location = new System.Drawing.Point(108, 276);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(409, 93);
            this.grbInformacoes.TabIndex = 4;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnCadastrarIngressos
            // 
            this.btnCadastrarIngressos.FlatAppearance.BorderSize = 2;
            this.btnCadastrarIngressos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarIngressos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarIngressos.ForeColor = System.Drawing.Color.Green;
            this.btnCadastrarIngressos.Location = new System.Drawing.Point(267, 28);
            this.btnCadastrarIngressos.Name = "btnCadastrarIngressos";
            this.btnCadastrarIngressos.Size = new System.Drawing.Size(117, 43);
            this.btnCadastrarIngressos.TabIndex = 2;
            this.btnCadastrarIngressos.Text = "Cadastrar";
            this.btnCadastrarIngressos.UseVisualStyleBackColor = true;
            this.btnCadastrarIngressos.Click += new System.EventHandler(this.btnCadastrarIngressos_Click);
            // 
            // txbQtdIngressos
            // 
            this.txbQtdIngressos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQtdIngressos.Location = new System.Drawing.Point(161, 31);
            this.txbQtdIngressos.Name = "txbQtdIngressos";
            this.txbQtdIngressos.Size = new System.Drawing.Size(56, 31);
            this.txbQtdIngressos.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(7, 39);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(148, 18);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade Ingresso:";
            // 
            // lblTituloIngressos
            // 
            this.lblTituloIngressos.AutoSize = true;
            this.lblTituloIngressos.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIngressos.ForeColor = System.Drawing.Color.White;
            this.lblTituloIngressos.Location = new System.Drawing.Point(218, 24);
            this.lblTituloIngressos.Name = "lblTituloIngressos";
            this.lblTituloIngressos.Size = new System.Drawing.Size(150, 45);
            this.lblTituloIngressos.TabIndex = 5;
            this.lblTituloIngressos.Text = "Ingressos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cine_sql.Properties.Resources.ingressos__1_;
            this.pictureBox1.Location = new System.Drawing.Point(347, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Ingresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(656, 569);
            this.Controls.Add(this.lblTituloIngressos);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.dgvIngressos);
            this.Controls.Add(this.dgvSessoes);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Ingresso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngressos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSessoes;
        private System.Windows.Forms.DataGridView dgvIngressos;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnCadastrarIngressos;
        private System.Windows.Forms.TextBox txbQtdIngressos;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTituloIngressos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}