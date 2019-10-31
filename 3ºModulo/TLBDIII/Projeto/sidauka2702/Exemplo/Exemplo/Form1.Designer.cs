namespace Exemplo
{
    partial class Form1
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
            this.cmbDisco = new System.Windows.Forms.ComboBox();
            this.objLista = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cmbDisco
            // 
            this.cmbDisco.DisplayMember = "DSCNOME";
            this.cmbDisco.FormattingEnabled = true;
            this.cmbDisco.Location = new System.Drawing.Point(12, 12);
            this.cmbDisco.Name = "cmbDisco";
            this.cmbDisco.Size = new System.Drawing.Size(565, 21);
            this.cmbDisco.TabIndex = 0;
            this.cmbDisco.ValueMember = "DSCCODIGO";
            this.cmbDisco.SelectedIndexChanged += new System.EventHandler(this.cmbDisco_SelectedIndexChanged);
            // 
            // objLista
            // 
            this.objLista.Location = new System.Drawing.Point(12, 39);
            this.objLista.MinimumSize = new System.Drawing.Size(20, 20);
            this.objLista.Name = "objLista";
            this.objLista.Size = new System.Drawing.Size(565, 245);
            this.objLista.TabIndex = 1;
            this.objLista.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.objLista_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 296);
            this.Controls.Add(this.objLista);
            this.Controls.Add(this.cmbDisco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDisco;
        private System.Windows.Forms.WebBrowser objLista;
    }
}

