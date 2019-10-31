namespace Acervo
{
    partial class FrmAlbuns
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
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAno = new System.Windows.Forms.NumericUpDown();
            this.ImgCapa = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbGravadora = new System.Windows.Forms.ComboBox();
            this.radioBanda = new System.Windows.Forms.RadioButton();
            this.radioArtista = new System.Windows.Forms.RadioButton();
            this.CMBInterprete = new System.Windows.Forms.ComboBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.ObjArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(28, 43);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(81, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome do album";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 36);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(115, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ano de lançamento";
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(137, 67);
            this.TxtAno.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.TxtAno.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(115, 20);
            this.TxtAno.TabIndex = 3;
            this.TxtAno.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // ImgCapa
            // 
            this.ImgCapa.Location = new System.Drawing.Point(288, 36);
            this.ImgCapa.Name = "ImgCapa";
            this.ImgCapa.Size = new System.Drawing.Size(134, 131);
            this.ImgCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCapa.TabIndex = 4;
            this.ImgCapa.TabStop = false;
            this.ImgCapa.Click += new System.EventHandler(this.ImgCapa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gravadora";
            // 
            // CmbGravadora
            // 
            this.CmbGravadora.DisplayMember = "grvnome";
            this.CmbGravadora.FormattingEnabled = true;
            this.CmbGravadora.Location = new System.Drawing.Point(137, 97);
            this.CmbGravadora.Name = "CmbGravadora";
            this.CmbGravadora.Size = new System.Drawing.Size(120, 21);
            this.CmbGravadora.TabIndex = 6;
            this.CmbGravadora.ValueMember = "grvcodigo";
            // 
            // radioBanda
            // 
            this.radioBanda.AutoSize = true;
            this.radioBanda.Location = new System.Drawing.Point(31, 150);
            this.radioBanda.Name = "radioBanda";
            this.radioBanda.Size = new System.Drawing.Size(56, 17);
            this.radioBanda.TabIndex = 7;
            this.radioBanda.TabStop = true;
            this.radioBanda.Text = "Banda";
            this.radioBanda.UseVisualStyleBackColor = true;
            this.radioBanda.CheckedChanged += new System.EventHandler(this.radioBanda_CheckedChanged);
            // 
            // radioArtista
            // 
            this.radioArtista.AutoSize = true;
            this.radioArtista.Location = new System.Drawing.Point(148, 150);
            this.radioArtista.Name = "radioArtista";
            this.radioArtista.Size = new System.Drawing.Size(54, 17);
            this.radioArtista.TabIndex = 8;
            this.radioArtista.TabStop = true;
            this.radioArtista.Text = "Artista";
            this.radioArtista.UseVisualStyleBackColor = true;
            this.radioArtista.CheckedChanged += new System.EventHandler(this.radioArtista_CheckedChanged);
            // 
            // CMBInterprete
            // 
            this.CMBInterprete.FormattingEnabled = true;
            this.CMBInterprete.Location = new System.Drawing.Point(31, 173);
            this.CMBInterprete.Name = "CMBInterprete";
            this.CMBInterprete.Size = new System.Drawing.Size(226, 21);
            this.CMBInterprete.TabIndex = 9;
            this.CMBInterprete.SelectedIndexChanged += new System.EventHandler(this.CMBInterprete_SelectedIndexChanged);
            // 
            // BtnGravar
            // 
            this.BtnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGravar.Location = new System.Drawing.Point(167, 222);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 10;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // ObjArquivo
            // 
            this.ObjArquivo.FileName = "openFileDialog1";
            // 
            // FrmAlbuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 257);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.CMBInterprete);
            this.Controls.Add(this.radioArtista);
            this.Controls.Add(this.radioBanda);
            this.Controls.Add(this.CmbGravadora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImgCapa);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Name = "FrmAlbuns";
            this.Text = "FrmAlbuns";
            this.Load += new System.EventHandler(this.FrmAlbuns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TxtAno;
        private System.Windows.Forms.PictureBox ImgCapa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbGravadora;
        private System.Windows.Forms.RadioButton radioBanda;
        private System.Windows.Forms.RadioButton radioArtista;
        private System.Windows.Forms.ComboBox CMBInterprete;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.OpenFileDialog ObjArquivo;
    }
}