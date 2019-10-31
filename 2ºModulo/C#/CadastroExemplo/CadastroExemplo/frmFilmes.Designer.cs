namespace CadastroExemplo
{
    partial class frmFilmes
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.cmbDiretor = new System.Windows.Forms.ComboBox();
            this.lstGenero = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdIncluir = new System.Windows.Forms.Button();
            this.lstAtor = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 26);
            this.txtNome.TabIndex = 0;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(16, 108);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(372, 26);
            this.txtOriginal.TabIndex = 1;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(206, 176);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(182, 244);
            this.txtSinopse.TabIndex = 2;
            // 
            // cmbDiretor
            // 
            this.cmbDiretor.DisplayMember = "DRTNOME";
            this.cmbDiretor.FormattingEnabled = true;
            this.cmbDiretor.Location = new System.Drawing.Point(16, 392);
            this.cmbDiretor.Name = "cmbDiretor";
            this.cmbDiretor.Size = new System.Drawing.Size(182, 28);
            this.cmbDiretor.TabIndex = 3;
            this.cmbDiretor.ValueMember = "DRTCODIGO";
            // 
            // lstGenero
            // 
            this.lstGenero.DisplayMember = "GNRNOME";
            this.lstGenero.FormattingEnabled = true;
            this.lstGenero.ItemHeight = 20;
            this.lstGenero.Location = new System.Drawing.Point(16, 176);
            this.lstGenero.Name = "lstGenero";
            this.lstGenero.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGenero.Size = new System.Drawing.Size(182, 184);
            this.lstGenero.TabIndex = 4;
            this.lstGenero.ValueMember = "GNRCODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sinopse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diretor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Generos";
            // 
            // cmdIncluir
            // 
            this.cmdIncluir.Location = new System.Drawing.Point(493, 444);
            this.cmdIncluir.Name = "cmdIncluir";
            this.cmdIncluir.Size = new System.Drawing.Size(110, 35);
            this.cmdIncluir.TabIndex = 10;
            this.cmdIncluir.Text = "Gravar";
            this.cmdIncluir.UseVisualStyleBackColor = true;
            this.cmdIncluir.Click += new System.EventHandler(this.cmdIncluir_Click);
            // 
            // lstAtor
            // 
            this.lstAtor.DisplayMember = "ATRNOME";
            this.lstAtor.FormattingEnabled = true;
            this.lstAtor.ItemHeight = 20;
            this.lstAtor.Location = new System.Drawing.Point(407, 40);
            this.lstAtor.Name = "lstAtor";
            this.lstAtor.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAtor.Size = new System.Drawing.Size(196, 384);
            this.lstAtor.TabIndex = 11;
            this.lstAtor.ValueMember = "ATRCODIGO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Atores";
            // 
            // frmFilmes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(624, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstAtor);
            this.Controls.Add(this.cmdIncluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGenero);
            this.Controls.Add(this.cmbDiretor);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmFilmes";
            this.Text = "frmFilmes";
            this.Load += new System.EventHandler(this.frmFilmes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.ComboBox cmbDiretor;
        private System.Windows.Forms.ListBox lstGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdIncluir;
        private System.Windows.Forms.ListBox lstAtor;
        private System.Windows.Forms.Label label6;
    }
}