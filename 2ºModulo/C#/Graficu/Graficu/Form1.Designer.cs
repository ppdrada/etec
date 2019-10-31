namespace Graficu
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.objMenu = new System.Windows.Forms.TabControl();
            this.mnuArquivo = new System.Windows.Forms.TabPage();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.mnuDesenho = new System.Windows.Forms.TabPage();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlCor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmEspessura = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radLinha = new System.Windows.Forms.RadioButton();
            this.radCirculo = new System.Windows.Forms.RadioButton();
            this.radRetangulo = new System.Windows.Forms.RadioButton();
            this.radCompleto = new System.Windows.Forms.RadioButton();
            this.radFundo = new System.Windows.Forms.RadioButton();
            this.radContorno = new System.Windows.Forms.RadioButton();
            this.objTela = new System.Windows.Forms.PictureBox();
            this.objCor = new System.Windows.Forms.ColorDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.objAbrir = new System.Windows.Forms.OpenFileDialog();
            this.objSalvar = new System.Windows.Forms.SaveFileDialog();
            this.objMenu.SuspendLayout();
            this.mnuArquivo.SuspendLayout();
            this.mnuDesenho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmEspessura)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objTela)).BeginInit();
            this.SuspendLayout();
            // 
            // objMenu
            // 
            this.objMenu.Controls.Add(this.mnuArquivo);
            this.objMenu.Controls.Add(this.mnuDesenho);
            this.objMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.objMenu.Location = new System.Drawing.Point(0, 0);
            this.objMenu.Name = "objMenu";
            this.objMenu.SelectedIndex = 0;
            this.objMenu.Size = new System.Drawing.Size(984, 171);
            this.objMenu.TabIndex = 0;
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.Controls.Add(this.btnSalvar);
            this.mnuArquivo.Controls.Add(this.btnAbrir);
            this.mnuArquivo.Controls.Add(this.btnNovo);
            this.mnuArquivo.Location = new System.Drawing.Point(4, 22);
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Padding = new System.Windows.Forms.Padding(3);
            this.mnuArquivo.Size = new System.Drawing.Size(976, 145);
            this.mnuArquivo.TabIndex = 0;
            this.mnuArquivo.Text = "Arquivo";
            this.mnuArquivo.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(168, 22);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(100, 100);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.click_abrir);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(40, 22);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 100);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.click_novo);
            // 
            // mnuDesenho
            // 
            this.mnuDesenho.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuDesenho.Controls.Add(this.pnlFundo);
            this.mnuDesenho.Controls.Add(this.pnlCor);
            this.mnuDesenho.Controls.Add(this.label1);
            this.mnuDesenho.Controls.Add(this.nmEspessura);
            this.mnuDesenho.Controls.Add(this.panel1);
            this.mnuDesenho.Controls.Add(this.radCompleto);
            this.mnuDesenho.Controls.Add(this.radFundo);
            this.mnuDesenho.Controls.Add(this.radContorno);
            this.mnuDesenho.Location = new System.Drawing.Point(4, 22);
            this.mnuDesenho.Name = "mnuDesenho";
            this.mnuDesenho.Padding = new System.Windows.Forms.Padding(3);
            this.mnuDesenho.Size = new System.Drawing.Size(976, 145);
            this.mnuDesenho.TabIndex = 1;
            this.mnuDesenho.Text = "Ferramentas de desenho";
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.White;
            this.pnlFundo.Location = new System.Drawing.Point(111, 26);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(110, 110);
            this.pnlFundo.TabIndex = 1;
            this.pnlFundo.DoubleClick += new System.EventHandler(this.selecionarCor);
            // 
            // pnlCor
            // 
            this.pnlCor.BackColor = System.Drawing.Color.Black;
            this.pnlCor.Location = new System.Drawing.Point(77, 10);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(110, 110);
            this.pnlCor.TabIndex = 0;
            this.pnlCor.DoubleClick += new System.EventHandler(this.selecionarCor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Espessura:";
            // 
            // nmEspessura
            // 
            this.nmEspessura.Location = new System.Drawing.Point(849, 65);
            this.nmEspessura.Name = "nmEspessura";
            this.nmEspessura.Size = new System.Drawing.Size(95, 20);
            this.nmEspessura.TabIndex = 6;
            this.nmEspessura.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radLinha);
            this.panel1.Controls.Add(this.radCirculo);
            this.panel1.Controls.Add(this.radRetangulo);
            this.panel1.Location = new System.Drawing.Point(408, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 142);
            this.panel1.TabIndex = 5;
            // 
            // radLinha
            // 
            this.radLinha.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLinha.AutoSize = true;
            this.radLinha.Image = ((System.Drawing.Image)(resources.GetObject("radLinha.Image")));
            this.radLinha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radLinha.Location = new System.Drawing.Point(278, 31);
            this.radLinha.Name = "radLinha";
            this.radLinha.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.radLinha.Size = new System.Drawing.Size(75, 75);
            this.radLinha.TabIndex = 8;
            this.radLinha.TabStop = true;
            this.radLinha.Text = "Linha";
            this.radLinha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radLinha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radLinha.UseVisualStyleBackColor = true;
            // 
            // radCirculo
            // 
            this.radCirculo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCirculo.AutoSize = true;
            this.radCirculo.Image = ((System.Drawing.Image)(resources.GetObject("radCirculo.Image")));
            this.radCirculo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radCirculo.Location = new System.Drawing.Point(161, 31);
            this.radCirculo.Name = "radCirculo";
            this.radCirculo.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.radCirculo.Size = new System.Drawing.Size(75, 75);
            this.radCirculo.TabIndex = 7;
            this.radCirculo.TabStop = true;
            this.radCirculo.Text = "Circulo";
            this.radCirculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radCirculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radCirculo.UseVisualStyleBackColor = true;
            // 
            // radRetangulo
            // 
            this.radRetangulo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radRetangulo.AutoSize = true;
            this.radRetangulo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRetangulo.Image = ((System.Drawing.Image)(resources.GetObject("radRetangulo.Image")));
            this.radRetangulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radRetangulo.Location = new System.Drawing.Point(42, 31);
            this.radRetangulo.Name = "radRetangulo";
            this.radRetangulo.Padding = new System.Windows.Forms.Padding(4, 10, 5, 10);
            this.radRetangulo.Size = new System.Drawing.Size(75, 75);
            this.radRetangulo.TabIndex = 6;
            this.radRetangulo.TabStop = true;
            this.radRetangulo.Text = "Retângulo";
            this.radRetangulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radRetangulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radRetangulo.UseVisualStyleBackColor = true;
            // 
            // radCompleto
            // 
            this.radCompleto.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCompleto.AutoSize = true;
            this.radCompleto.Image = ((System.Drawing.Image)(resources.GetObject("radCompleto.Image")));
            this.radCompleto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCompleto.Location = new System.Drawing.Point(309, 98);
            this.radCompleto.Name = "radCompleto";
            this.radCompleto.Size = new System.Drawing.Size(93, 38);
            this.radCompleto.TabIndex = 4;
            this.radCompleto.TabStop = true;
            this.radCompleto.Text = "Completo";
            this.radCompleto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radCompleto.UseVisualStyleBackColor = true;
            // 
            // radFundo
            // 
            this.radFundo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radFundo.AutoSize = true;
            this.radFundo.Image = ((System.Drawing.Image)(resources.GetObject("radFundo.Image")));
            this.radFundo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radFundo.Location = new System.Drawing.Point(309, 54);
            this.radFundo.Name = "radFundo";
            this.radFundo.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.radFundo.Size = new System.Drawing.Size(93, 38);
            this.radFundo.TabIndex = 3;
            this.radFundo.TabStop = true;
            this.radFundo.Text = "Fundo";
            this.radFundo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radFundo.UseVisualStyleBackColor = true;
            // 
            // radContorno
            // 
            this.radContorno.Appearance = System.Windows.Forms.Appearance.Button;
            this.radContorno.AutoSize = true;
            this.radContorno.Image = ((System.Drawing.Image)(resources.GetObject("radContorno.Image")));
            this.radContorno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radContorno.Location = new System.Drawing.Point(309, 10);
            this.radContorno.Name = "radContorno";
            this.radContorno.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.radContorno.Size = new System.Drawing.Size(93, 38);
            this.radContorno.TabIndex = 2;
            this.radContorno.TabStop = true;
            this.radContorno.Text = "Contorno";
            this.radContorno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radContorno.UseVisualStyleBackColor = true;
            // 
            // objTela
            // 
            this.objTela.BackColor = System.Drawing.Color.White;
            this.objTela.Dock = System.Windows.Forms.DockStyle.Left;
            this.objTela.Location = new System.Drawing.Point(0, 171);
            this.objTela.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.objTela.Name = "objTela";
            this.objTela.Size = new System.Drawing.Size(981, 490);
            this.objTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.objTela.TabIndex = 1;
            this.objTela.TabStop = false;
            this.objTela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fnIniciar);
            this.objTela.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fnConcluir);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(294, 22);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 100);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.click_salvar);
            // 
            // objAbrir
            // 
            this.objAbrir.Filter = "png|*.png|gif|*.gif|Todos os arquivos|*.*";
            // 
            // objSalvar
            // 
            this.objSalvar.Filter = "png|*.png|gif|*.gif";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.objTela);
            this.Controls.Add(this.objMenu);
            this.Name = "FrmPrincipal";
            this.Text = "Meu programa graficu";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.objMenu.ResumeLayout(false);
            this.mnuArquivo.ResumeLayout(false);
            this.mnuDesenho.ResumeLayout(false);
            this.mnuDesenho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmEspessura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl objMenu;
        private System.Windows.Forms.TabPage mnuArquivo;
        private System.Windows.Forms.TabPage mnuDesenho;
        private System.Windows.Forms.PictureBox objTela;
        private System.Windows.Forms.ColorDialog objCor;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlCor;
        private System.Windows.Forms.RadioButton radCompleto;
        private System.Windows.Forms.RadioButton radFundo;
        private System.Windows.Forms.RadioButton radContorno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radLinha;
        private System.Windows.Forms.RadioButton radCirculo;
        private System.Windows.Forms.RadioButton radRetangulo;
        private System.Windows.Forms.NumericUpDown nmEspessura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.OpenFileDialog objAbrir;
        private System.Windows.Forms.SaveFileDialog objSalvar;
    }
}

