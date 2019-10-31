namespace CadastroExemplo
{
    partial class frmLista
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
            this.objLista = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // objLista
            // 
            this.objLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objLista.Location = new System.Drawing.Point(0, 0);
            this.objLista.MinimumSize = new System.Drawing.Size(20, 20);
            this.objLista.Name = "objLista";
            this.objLista.Size = new System.Drawing.Size(733, 367);
            this.objLista.TabIndex = 0;
            this.objLista.Url = new System.Uri("http://localhost/LISTA.PHP", System.UriKind.Absolute);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 367);
            this.Controls.Add(this.objLista);
            this.Name = "frmLista";
            this.Text = "Relatorio de filmes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser objLista;
    }
}