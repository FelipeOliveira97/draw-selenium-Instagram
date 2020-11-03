namespace InstagramBot
{
    partial class InstagramBOT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstagramBOT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbAmigos = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.btEnviar = new System.Windows.Forms.Button();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.lbSorteio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbAmigos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbLink);
            this.panel1.Controls.Add(this.lbSorteio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 300);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.gbAmigos);
            this.panel2.Location = new System.Drawing.Point(15, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 189);
            this.panel2.TabIndex = 2;
            // 
            // gbAmigos
            // 
            this.gbAmigos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAmigos.Controls.Add(this.panel3);
            this.gbAmigos.Controls.Add(this.btEnviar);
            this.gbAmigos.Controls.Add(this.rb3);
            this.gbAmigos.Controls.Add(this.rb2);
            this.gbAmigos.Controls.Add(this.rb1);
            this.gbAmigos.Location = new System.Drawing.Point(3, 3);
            this.gbAmigos.Name = "gbAmigos";
            this.gbAmigos.Size = new System.Drawing.Size(281, 179);
            this.gbAmigos.TabIndex = 0;
            this.gbAmigos.TabStop = false;
            this.gbAmigos.Text = "Quantidade de amigos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbSenha);
            this.panel3.Controls.Add(this.tbLogin);
            this.panel3.Controls.Add(this.lbSenha);
            this.panel3.Controls.Add(this.lbUsuario);
            this.panel3.Location = new System.Drawing.Point(7, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 52);
            this.panel3.TabIndex = 4;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(180, 13);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(74, 20);
            this.tbSenha.TabIndex = 3;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(50, 13);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(74, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(130, 16);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(44, 13);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha :";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(4, 16);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(49, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario :";
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(103, 150);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.Text = "Iniciar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(7, 68);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(72, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "3° Amigos";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(7, 44);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(72, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "2° Amigos";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(7, 20);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(67, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1° Amigo";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // tbLink
            // 
            this.tbLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLink.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLink.Location = new System.Drawing.Point(15, 25);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(288, 20);
            this.tbLink.TabIndex = 1;
            // 
            // lbSorteio
            // 
            this.lbSorteio.AutoSize = true;
            this.lbSorteio.Location = new System.Drawing.Point(12, 9);
            this.lbSorteio.Name = "lbSorteio";
            this.lbSorteio.Size = new System.Drawing.Size(84, 13);
            this.lbSorteio.TabIndex = 0;
            this.lbSorteio.Text = "Link do Sorteio :";
            // 
            // InstagramBOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InstagramBOT";
            this.Text = "Instabot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbAmigos.ResumeLayout(false);
            this.gbAmigos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSorteio;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbAmigos;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
    }
}

