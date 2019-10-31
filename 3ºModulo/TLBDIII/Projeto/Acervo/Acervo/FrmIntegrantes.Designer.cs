namespace Acervo
{
    partial class FrmIntegrantes
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
            this.lstArtitas = new System.Windows.Forms.ListBox();
            this.cmbBandas = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstArtitas
            // 
            this.lstArtitas.FormattingEnabled = true;
            this.lstArtitas.Location = new System.Drawing.Point(38, 103);
            this.lstArtitas.Name = "lstArtitas";
            this.lstArtitas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstArtitas.Size = new System.Drawing.Size(271, 95);
            this.lstArtitas.TabIndex = 0;
            this.lstArtitas.SelectedIndexChanged += new System.EventHandler(this.lstArtitas_SelectedIndexChanged);
            // 
            // cmbBandas
            // 
            this.cmbBandas.FormattingEnabled = true;
            this.cmbBandas.Location = new System.Drawing.Point(38, 52);
            this.cmbBandas.Name = "cmbBandas";
            this.cmbBandas.Size = new System.Drawing.Size(271, 21);
            this.cmbBandas.TabIndex = 1;
            this.cmbBandas.SelectedIndexChanged += new System.EventHandler(this.cmbBandas_SelectedIndexChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(50, 206);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(204, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmIntegrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 241);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cmbBandas);
            this.Controls.Add(this.lstArtitas);
            this.Name = "FrmIntegrantes";
            this.Text = "FrmIntegrantes";
            this.Load += new System.EventHandler(this.FrmIntegrantes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstArtitas;
        private System.Windows.Forms.ComboBox cmbBandas;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}