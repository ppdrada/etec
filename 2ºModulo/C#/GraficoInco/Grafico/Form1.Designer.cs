namespace Grafico
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.objMenu = new System.Windows.Forms.TabControl();
            this.mnuArquivo = new System.Windows.Forms.TabPage();
            this.abrir = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.mnuControle = new System.Windows.Forms.TabPage();
            this.espessura = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radContorno = new System.Windows.Forms.RadioButton();
            this.radCompleto = new System.Windows.Forms.RadioButton();
            this.radFundo = new System.Windows.Forms.RadioButton();
            this.radLinha = new System.Windows.Forms.RadioButton();
            this.radCirculo = new System.Windows.Forms.RadioButton();
            this.radQuadrado = new System.Windows.Forms.RadioButton();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlCor = new System.Windows.Forms.Panel();
            this.objTela = new System.Windows.Forms.PictureBox();
            this.objCor = new System.Windows.Forms.ColorDialog();
            this.objSalvar = new System.Windows.Forms.SaveFileDialog();
            this.objAbrir = new System.Windows.Forms.OpenFileDialog();
            this.objMenu.SuspendLayout();
            this.mnuArquivo.SuspendLayout();
            this.mnuControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.espessura)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objTela)).BeginInit();
            this.SuspendLayout();
            // 
            // objMenu
            // 
            this.objMenu.Controls.Add(this.mnuArquivo);
            this.objMenu.Controls.Add(this.mnuControle);
            this.objMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.objMenu.Location = new System.Drawing.Point(0, 0);
            this.objMenu.Name = "objMenu";
            this.objMenu.SelectedIndex = 0;
            this.objMenu.Size = new System.Drawing.Size(912, 150);
            this.objMenu.TabIndex = 0;
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.Controls.Add(this.abrir);
            this.mnuArquivo.Controls.Add(this.salvar);
            this.mnuArquivo.Controls.Add(this.novo);
            this.mnuArquivo.Location = new System.Drawing.Point(4, 22);
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Padding = new System.Windows.Forms.Padding(3);
            this.mnuArquivo.Size = new System.Drawing.Size(904, 124);
            this.mnuArquivo.TabIndex = 0;
            this.mnuArquivo.Text = "Arquivo";
            this.mnuArquivo.UseVisualStyleBackColor = true;
            // 
            // abrir
            // 
            this.abrir.Location = new System.Drawing.Point(19, 45);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(75, 23);
            this.abrir.TabIndex = 2;
            this.abrir.Text = "Abrir";
            this.abrir.UseCompatibleTextRendering = true;
            this.abrir.UseVisualStyleBackColor = true;
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(19, 74);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 1;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(19, 16);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(75, 23);
            this.novo.TabIndex = 0;
            this.novo.Text = "Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // mnuControle
            // 
            this.mnuControle.Controls.Add(this.espessura);
            this.mnuControle.Controls.Add(this.panel1);
            this.mnuControle.Controls.Add(this.radLinha);
            this.mnuControle.Controls.Add(this.radCirculo);
            this.mnuControle.Controls.Add(this.radQuadrado);
            this.mnuControle.Controls.Add(this.pnlFundo);
            this.mnuControle.Controls.Add(this.pnlCor);
            this.mnuControle.Location = new System.Drawing.Point(4, 22);
            this.mnuControle.Name = "mnuControle";
            this.mnuControle.Padding = new System.Windows.Forms.Padding(3);
            this.mnuControle.Size = new System.Drawing.Size(904, 124);
            this.mnuControle.TabIndex = 1;
            this.mnuControle.Text = "Ferramentas_de_Desenho";
            this.mnuControle.UseVisualStyleBackColor = true;
            this.mnuControle.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // espessura
            // 
            this.espessura.Location = new System.Drawing.Point(207, 74);
            this.espessura.Name = "espessura";
            this.espessura.Size = new System.Drawing.Size(120, 20);
            this.espessura.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radContorno);
            this.panel1.Controls.Add(this.radCompleto);
            this.panel1.Controls.Add(this.radFundo);
            this.panel1.Location = new System.Drawing.Point(287, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 46);
            this.panel1.TabIndex = 7;
            // 
            // radContorno
            // 
            this.radContorno.Appearance = System.Windows.Forms.Appearance.Button;
            this.radContorno.AutoSize = true;
            this.radContorno.Image = ((System.Drawing.Image)(resources.GetObject("radContorno.Image")));
            this.radContorno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radContorno.Location = new System.Drawing.Point(4, 3);
            this.radContorno.Name = "radContorno";
            this.radContorno.Size = new System.Drawing.Size(92, 38);
            this.radContorno.TabIndex = 4;
            this.radContorno.TabStop = true;
            this.radContorno.Text = "Contorno";
            this.radContorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radContorno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radContorno.UseVisualStyleBackColor = true;
            this.radContorno.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radCompleto
            // 
            this.radCompleto.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCompleto.AutoSize = true;
            this.radCompleto.Image = ((System.Drawing.Image)(resources.GetObject("radCompleto.Image")));
            this.radCompleto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radCompleto.Location = new System.Drawing.Point(187, 3);
            this.radCompleto.Name = "radCompleto";
            this.radCompleto.Size = new System.Drawing.Size(93, 38);
            this.radCompleto.TabIndex = 6;
            this.radCompleto.TabStop = true;
            this.radCompleto.Text = "Completo";
            this.radCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCompleto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radCompleto.UseVisualStyleBackColor = true;
            // 
            // radFundo
            // 
            this.radFundo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radFundo.AutoSize = true;
            this.radFundo.Image = ((System.Drawing.Image)(resources.GetObject("radFundo.Image")));
            this.radFundo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radFundo.Location = new System.Drawing.Point(102, 3);
            this.radFundo.Name = "radFundo";
            this.radFundo.Size = new System.Drawing.Size(79, 38);
            this.radFundo.TabIndex = 5;
            this.radFundo.TabStop = true;
            this.radFundo.Text = "Fundo";
            this.radFundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radFundo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radFundo.UseVisualStyleBackColor = true;
            this.radFundo.CheckedChanged += new System.EventHandler(this.radFundo_CheckedChanged);
            // 
            // radLinha
            // 
            this.radLinha.AutoSize = true;
            this.radLinha.Location = new System.Drawing.Point(207, 51);
            this.radLinha.Name = "radLinha";
            this.radLinha.Size = new System.Drawing.Size(51, 17);
            this.radLinha.TabIndex = 3;
            this.radLinha.Text = "Linha";
            this.radLinha.UseVisualStyleBackColor = true;
            this.radLinha.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radCirculo
            // 
            this.radCirculo.AutoSize = true;
            this.radCirculo.Location = new System.Drawing.Point(207, 29);
            this.radCirculo.Name = "radCirculo";
            this.radCirculo.Size = new System.Drawing.Size(57, 17);
            this.radCirculo.TabIndex = 2;
            this.radCirculo.Text = "Circulo";
            this.radCirculo.UseVisualStyleBackColor = true;
            // 
            // radQuadrado
            // 
            this.radQuadrado.AutoSize = true;
            this.radQuadrado.Checked = true;
            this.radQuadrado.Location = new System.Drawing.Point(207, 6);
            this.radQuadrado.Name = "radQuadrado";
            this.radQuadrado.Size = new System.Drawing.Size(74, 17);
            this.radQuadrado.TabIndex = 1;
            this.radQuadrado.TabStop = true;
            this.radQuadrado.Text = "Retângulo";
            this.radQuadrado.UseVisualStyleBackColor = true;
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.White;
            this.pnlFundo.Location = new System.Drawing.Point(107, 6);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(94, 62);
            this.pnlFundo.TabIndex = 1;
            this.pnlFundo.DoubleClick += new System.EventHandler(this.fnSeleciona_Cor);
            // 
            // pnlCor
            // 
            this.pnlCor.BackColor = System.Drawing.Color.Black;
            this.pnlCor.Location = new System.Drawing.Point(8, 6);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(93, 62);
            this.pnlCor.TabIndex = 0;
            this.pnlCor.DoubleClick += new System.EventHandler(this.fnSeleciona_Cor);
            // 
            // objTela
            // 
            this.objTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objTela.Location = new System.Drawing.Point(0, 150);
            this.objTela.Name = "objTela";
            this.objTela.Size = new System.Drawing.Size(912, 492);
            this.objTela.TabIndex = 0;
            this.objTela.TabStop = false;
            this.objTela.Click += new System.EventHandler(this.objTela_Click);
            this.objTela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fnIniciar);
            this.objTela.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fnTerminar);
            // 
            // objAbrir
            // 
            this.objAbrir.FileName = "openFileDialog1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 642);
            this.Controls.Add(this.objTela);
            this.Controls.Add(this.objMenu);
            this.Name = "Principal";
            this.Text = "Editor_Grafico";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.objMenu.ResumeLayout(false);
            this.mnuArquivo.ResumeLayout(false);
            this.mnuControle.ResumeLayout(false);
            this.mnuControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.espessura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objTela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl objMenu;
        private System.Windows.Forms.TabPage mnuArquivo;
        private System.Windows.Forms.TabPage mnuControle;
        private System.Windows.Forms.PictureBox objTela;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlCor;
        private System.Windows.Forms.ColorDialog objCor;
        private System.Windows.Forms.RadioButton radLinha;
        private System.Windows.Forms.RadioButton radCirculo;
        private System.Windows.Forms.RadioButton radQuadrado;
        private System.Windows.Forms.RadioButton radCompleto;
        private System.Windows.Forms.RadioButton radFundo;
        private System.Windows.Forms.RadioButton radContorno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown espessura;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.SaveFileDialog objSalvar;
        private System.Windows.Forms.OpenFileDialog objAbrir;
    }
}

