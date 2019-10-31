namespace Tela
{
    partial class frmJanela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJanela));
            this.imgLogotipo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogotipo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogotipo
            // 
            this.imgLogotipo.Image = global::Tela.Properties.Resources.novemberpink;
            this.imgLogotipo.Location = new System.Drawing.Point(16, 30);
            this.imgLogotipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgLogotipo.Name = "imgLogotipo";
            this.imgLogotipo.Size = new System.Drawing.Size(167, 154);
            this.imgLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogotipo.TabIndex = 0;
            this.imgLogotipo.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnIncluir);
            this.pnlMenu.Controls.Add(this.btnListar);
            this.pnlMenu.Location = new System.Drawing.Point(191, 94);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(725, 123);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListar.BackgroundImage")));
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnListar.Location = new System.Drawing.Point(14, 14);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(200, 75);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.alteraImagem);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIncluir.Location = new System.Drawing.Point(248, 14);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(200, 75);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.alteraImagem);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.Location = new System.Drawing.Point(476, 14);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 75);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.alteraImagem);
            // 
            // frmJanela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(921, 482);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.imgLogotipo);
            this.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmJanela";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmJanela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogotipo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogotipo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnListar;
    }
}

