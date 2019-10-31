namespace Menu
{
    partial class Perfil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iniciu = new System.Windows.Forms.Button();
            this.configuracao = new System.Windows.Forms.Button();
            this.conta = new System.Windows.Forms.Button();
            this.ajuda = new System.Windows.Forms.Button();
            this.seuPerfil = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telefone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.nascimento = new System.Windows.Forms.Label();
            this.sobrenome = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.telaPerfil = new System.Windows.Forms.PictureBox();
            this.sair = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telaPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iniciu);
            this.panel1.Controls.Add(this.configuracao);
            this.panel1.Controls.Add(this.conta);
            this.panel1.Controls.Add(this.ajuda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 475);
            this.panel1.TabIndex = 0;
            // 
            // iniciu
            // 
            this.iniciu.BackColor = System.Drawing.Color.Transparent;
            this.iniciu.FlatAppearance.BorderSize = 0;
            this.iniciu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciu.ForeColor = System.Drawing.Color.White;
            this.iniciu.Image = global::Menu.Properties.Resources.casa;
            this.iniciu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iniciu.Location = new System.Drawing.Point(20, 180);
            this.iniciu.Name = "iniciu";
            this.iniciu.Size = new System.Drawing.Size(173, 50);
            this.iniciu.TabIndex = 6;
            this.iniciu.Text = " Iníciu";
            this.iniciu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iniciu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iniciu.UseVisualStyleBackColor = false;
            this.iniciu.Click += new System.EventHandler(this.iniciu_Click);
            // 
            // configuracao
            // 
            this.configuracao.BackColor = System.Drawing.Color.Transparent;
            this.configuracao.FlatAppearance.BorderSize = 0;
            this.configuracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracao.ForeColor = System.Drawing.Color.White;
            this.configuracao.Image = global::Menu.Properties.Resources.conf1;
            this.configuracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configuracao.Location = new System.Drawing.Point(20, 297);
            this.configuracao.Name = "configuracao";
            this.configuracao.Size = new System.Drawing.Size(173, 50);
            this.configuracao.TabIndex = 5;
            this.configuracao.Text = "Configurações";
            this.configuracao.UseVisualStyleBackColor = false;
            // 
            // conta
            // 
            this.conta.BackColor = System.Drawing.Color.Transparent;
            this.conta.FlatAppearance.BorderSize = 0;
            this.conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conta.ForeColor = System.Drawing.Color.White;
            this.conta.Image = global::Menu.Properties.Resources.env2;
            this.conta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conta.Location = new System.Drawing.Point(17, 241);
            this.conta.Name = "conta";
            this.conta.Size = new System.Drawing.Size(173, 50);
            this.conta.TabIndex = 4;
            this.conta.Text = "Conta";
            this.conta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.conta.UseVisualStyleBackColor = false;
            // 
            // ajuda
            // 
            this.ajuda.BackColor = System.Drawing.Color.Transparent;
            this.ajuda.FlatAppearance.BorderSize = 0;
            this.ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajuda.ForeColor = System.Drawing.Color.White;
            this.ajuda.Image = global::Menu.Properties.Resources.ajuda;
            this.ajuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajuda.Location = new System.Drawing.Point(25, 353);
            this.ajuda.Name = "ajuda";
            this.ajuda.Size = new System.Drawing.Size(173, 50);
            this.ajuda.TabIndex = 3;
            this.ajuda.Text = " Ajuda";
            this.ajuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ajuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ajuda.UseVisualStyleBackColor = false;
            // 
            // seuPerfil
            // 
            this.seuPerfil.AutoSize = true;
            this.seuPerfil.BackColor = System.Drawing.Color.Transparent;
            this.seuPerfil.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seuPerfil.ForeColor = System.Drawing.Color.White;
            this.seuPerfil.Location = new System.Drawing.Point(150, 25);
            this.seuPerfil.Name = "seuPerfil";
            this.seuPerfil.Size = new System.Drawing.Size(119, 42);
            this.seuPerfil.TabIndex = 2;
            this.seuPerfil.Text = "Perfil  ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.usuario);
            this.panel2.Controls.Add(this.telaPerfil);
            this.panel2.Location = new System.Drawing.Point(228, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 328);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.telefone);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.nascimento);
            this.groupBox1.Controls.Add(this.sobrenome);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Location = new System.Drawing.Point(38, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(6, 130);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(70, 14);
            this.telefone.TabIndex = 7;
            this.telefone.Text = "Telefone:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(6, 101);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(49, 14);
            this.email.TabIndex = 6;
            this.email.Text = "Email:";
            // 
            // nascimento
            // 
            this.nascimento.AutoSize = true;
            this.nascimento.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nascimento.Location = new System.Drawing.Point(6, 72);
            this.nascimento.Name = "nascimento";
            this.nascimento.Size = new System.Drawing.Size(84, 14);
            this.nascimento.TabIndex = 5;
            this.nascimento.Text = "Nascimento:";
            // 
            // sobrenome
            // 
            this.sobrenome.AutoSize = true;
            this.sobrenome.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobrenome.Location = new System.Drawing.Point(6, 43);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(77, 14);
            this.sobrenome.TabIndex = 4;
            this.sobrenome.Text = "Sobrenome:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(6, 16);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(42, 14);
            this.nome.TabIndex = 3;
            this.nome.Text = "Nome:";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(166, 30);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(110, 28);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Usuário";
            // 
            // telaPerfil
            // 
            this.telaPerfil.Image = global::Menu.Properties.Resources.perf1;
            this.telaPerfil.Location = new System.Drawing.Point(38, 30);
            this.telaPerfil.Name = "telaPerfil";
            this.telaPerfil.Size = new System.Drawing.Size(94, 98);
            this.telaPerfil.TabIndex = 0;
            this.telaPerfil.TabStop = false;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Transparent;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Image = global::Menu.Properties.Resources.sair;
            this.sair.Location = new System.Drawing.Point(577, 25);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(52, 49);
            this.sair.TabIndex = 8;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(651, 475);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.seuPerfil);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Perfil";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telaPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label seuPerfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox telaPerfil;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label nascimento;
        private System.Windows.Forms.Label sobrenome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Button configuracao;
        private System.Windows.Forms.Button conta;
        private System.Windows.Forms.Button ajuda;
        private System.Windows.Forms.Label sair;
        private System.Windows.Forms.Button iniciu;
    }
}