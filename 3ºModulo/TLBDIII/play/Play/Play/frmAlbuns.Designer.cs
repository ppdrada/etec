namespace Play
{
    partial class frmAlbuns
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.NumericUpDown();
            this.imgCapa = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGravadora = new System.Windows.Forms.ComboBox();
            this.radioBanda = new System.Windows.Forms.RadioButton();
            this.radioArtistas = new System.Windows.Forms.RadioButton();
            this.cmbInterprete = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.objArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do álbum:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(153, 56);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano de lançamento:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(153, 97);
            this.txtAno.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.txtAno.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(159, 20);
            this.txtAno.TabIndex = 3;
            this.txtAno.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // imgCapa
            // 
            this.imgCapa.Location = new System.Drawing.Point(356, 39);
            this.imgCapa.Name = "imgCapa";
            this.imgCapa.Size = new System.Drawing.Size(199, 198);
            this.imgCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCapa.TabIndex = 4;
            this.imgCapa.TabStop = false;
            this.imgCapa.Click += new System.EventHandler(this.imgCapa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gravadoras:";
            // 
            // cmbGravadora
            // 
            this.cmbGravadora.DisplayMember = "GRVNOME";
            this.cmbGravadora.FormattingEnabled = true;
            this.cmbGravadora.Location = new System.Drawing.Point(151, 134);
            this.cmbGravadora.Name = "cmbGravadora";
            this.cmbGravadora.Size = new System.Drawing.Size(161, 21);
            this.cmbGravadora.TabIndex = 6;
            this.cmbGravadora.ValueMember = "GRVCODIGO";
            // 
            // radioBanda
            // 
            this.radioBanda.AutoSize = true;
            this.radioBanda.Location = new System.Drawing.Point(46, 174);
            this.radioBanda.Name = "radioBanda";
            this.radioBanda.Size = new System.Drawing.Size(105, 17);
            this.radioBanda.TabIndex = 7;
            this.radioBanda.TabStop = true;
            this.radioBanda.Text = "   Banda / Grupo";
            this.radioBanda.UseVisualStyleBackColor = true;
            this.radioBanda.CheckedChanged += new System.EventHandler(this.radioBanda_CheckedChanged);
            // 
            // radioArtistas
            // 
            this.radioArtistas.AutoSize = true;
            this.radioArtistas.Location = new System.Drawing.Point(228, 174);
            this.radioArtistas.Name = "radioArtistas";
            this.radioArtistas.Size = new System.Drawing.Size(66, 17);
            this.radioArtistas.TabIndex = 8;
            this.radioArtistas.TabStop = true;
            this.radioArtistas.Text = "    Artista";
            this.radioArtistas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioArtistas.UseVisualStyleBackColor = true;
            // 
            // cmbInterprete
            // 
            this.cmbInterprete.FormattingEnabled = true;
            this.cmbInterprete.Location = new System.Drawing.Point(46, 216);
            this.cmbInterprete.Name = "cmbInterprete";
            this.cmbInterprete.Size = new System.Drawing.Size(266, 21);
            this.cmbInterprete.TabIndex = 9;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(228, 265);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(116, 37);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // objArquivo
            // 
            this.objArquivo.FileName = "openFileDialog1";
            // 
            // frmAlbuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 314);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cmbInterprete);
            this.Controls.Add(this.radioArtistas);
            this.Controls.Add(this.radioBanda);
            this.Controls.Add(this.cmbGravadora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imgCapa);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmAlbuns";
            this.Text = "Álbum";
            this.Load += new System.EventHandler(this.frmAlbuns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtAno;
        private System.Windows.Forms.PictureBox imgCapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGravadora;
        private System.Windows.Forms.RadioButton radioBanda;
        private System.Windows.Forms.RadioButton radioArtistas;
        private System.Windows.Forms.ComboBox cmbInterprete;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.OpenFileDialog objArquivo;
    }
}