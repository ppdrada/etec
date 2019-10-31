namespace Play
{
    partial class frmPrincipal
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
            this.btnAlbuns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlbuns
            // 
            this.btnAlbuns.Location = new System.Drawing.Point(97, 156);
            this.btnAlbuns.Name = "btnAlbuns";
            this.btnAlbuns.Size = new System.Drawing.Size(102, 47);
            this.btnAlbuns.TabIndex = 0;
            this.btnAlbuns.Text = "Álbuns";
            this.btnAlbuns.UseVisualStyleBackColor = true;
            this.btnAlbuns.Click += new System.EventHandler(this.btnAlbuns_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAlbuns);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlbuns;
    }
}

