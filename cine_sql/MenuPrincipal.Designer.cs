namespace cine_sql
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnSessoes = new System.Windows.Forms.Button();
            this.btnIngressos = new System.Windows.Forms.Button();
            this.lblTituloMenuPrincipal = new System.Windows.Forms.Label();
            this.lblDescricaoMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSessoes
            // 
            this.btnSessoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSessoes.FlatAppearance.BorderSize = 2;
            this.btnSessoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessoes.Location = new System.Drawing.Point(137, 220);
            this.btnSessoes.Name = "btnSessoes";
            this.btnSessoes.Size = new System.Drawing.Size(221, 93);
            this.btnSessoes.TabIndex = 6;
            this.btnSessoes.Text = "Sessões";
            this.btnSessoes.UseVisualStyleBackColor = false;
            // 
            // btnIngressos
            // 
            this.btnIngressos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnIngressos.FlatAppearance.BorderSize = 2;
            this.btnIngressos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngressos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngressos.Location = new System.Drawing.Point(137, 335);
            this.btnIngressos.Name = "btnIngressos";
            this.btnIngressos.Size = new System.Drawing.Size(222, 93);
            this.btnIngressos.TabIndex = 5;
            this.btnIngressos.Text = "Ingressos";
            this.btnIngressos.UseVisualStyleBackColor = false;
            // 
            // lblTituloMenuPrincipal
            // 
            this.lblTituloMenuPrincipal.AutoSize = true;
            this.lblTituloMenuPrincipal.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblTituloMenuPrincipal.Location = new System.Drawing.Point(70, 41);
            this.lblTituloMenuPrincipal.Name = "lblTituloMenuPrincipal";
            this.lblTituloMenuPrincipal.Size = new System.Drawing.Size(346, 36);
            this.lblTituloMenuPrincipal.TabIndex = 7;
            this.lblTituloMenuPrincipal.Text = "Seja Bem-Vindo ao Cine SQL!";
            // 
            // lblDescricaoMenu
            // 
            this.lblDescricaoMenu.AutoSize = true;
            this.lblDescricaoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoMenu.ForeColor = System.Drawing.Color.White;
            this.lblDescricaoMenu.Location = new System.Drawing.Point(94, 168);
            this.lblDescricaoMenu.Name = "lblDescricaoMenu";
            this.lblDescricaoMenu.Size = new System.Drawing.Size(322, 25);
            this.lblDescricaoMenu.TabIndex = 8;
            this.lblDescricaoMenu.Text = "Selecione uma opção abaixo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cine_sql.Properties.Resources.cinema;
            this.pictureBox1.Location = new System.Drawing.Point(182, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(495, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescricaoMenu);
            this.Controls.Add(this.lblTituloMenuPrincipal);
            this.Controls.Add(this.btnSessoes);
            this.Controls.Add(this.btnIngressos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSessoes;
        private System.Windows.Forms.Button btnIngressos;
        private System.Windows.Forms.Label lblTituloMenuPrincipal;
        private System.Windows.Forms.Label lblDescricaoMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}