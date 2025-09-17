namespace cine_sql
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.pibLogin = new System.Windows.Forms.PictureBox();
            this.pibFundoLogin = new System.Windows.Forms.PictureBox();
            this.grbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFundoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbLogin
            // 
            this.grbLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbLogin.Controls.Add(this.pibLogin);
            this.grbLogin.Controls.Add(this.txbSenha);
            this.grbLogin.Controls.Add(this.lblSenha);
            this.grbLogin.Controls.Add(this.lblEmail);
            this.grbLogin.Controls.Add(this.txbEmail);
            this.grbLogin.Location = new System.Drawing.Point(191, 247);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(286, 120);
            this.grbLogin.TabIndex = 8;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Login";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(61, 85);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(186, 20);
            this.txbSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(13, 88);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(61, 59);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(186, 20);
            this.txbEmail.TabIndex = 2;
            // 
            // pibLogin
            // 
            this.pibLogin.Image = global::cine_sql.Properties.Resources.login_avatar;
            this.pibLogin.Location = new System.Drawing.Point(110, 20);
            this.pibLogin.Name = "pibLogin";
            this.pibLogin.Size = new System.Drawing.Size(72, 33);
            this.pibLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogin.TabIndex = 4;
            this.pibLogin.TabStop = false;
            // 
            // pibFundoLogin
            // 
            this.pibFundoLogin.Image = global::cine_sql.Properties.Resources.Mídia;
            this.pibFundoLogin.Location = new System.Drawing.Point(-5, -79);
            this.pibFundoLogin.Name = "pibFundoLogin";
            this.pibFundoLogin.Size = new System.Drawing.Size(698, 608);
            this.pibFundoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibFundoLogin.TabIndex = 0;
            this.pibFundoLogin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbLogin);
            this.Controls.Add(this.pibFundoLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineSQL";
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFundoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.PictureBox pibLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.PictureBox pibFundoLogin;
    }
}

