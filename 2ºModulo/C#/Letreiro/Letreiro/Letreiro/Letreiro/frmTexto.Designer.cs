namespace Letreiro
{
    partial class frmTexto
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.cmdDefinir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(18, 17);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(387, 26);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // cmdDefinir
            // 
            this.cmdDefinir.Location = new System.Drawing.Point(413, 13);
            this.cmdDefinir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDefinir.Name = "cmdDefinir";
            this.cmdDefinir.Size = new System.Drawing.Size(112, 32);
            this.cmdDefinir.TabIndex = 1;
            this.cmdDefinir.Text = "Definir";
            this.cmdDefinir.UseVisualStyleBackColor = true;
            this.cmdDefinir.Click += new System.EventHandler(this.cmdDefinir_Click);
            // 
            // frmTexto
            // 
            this.AcceptButton = this.cmdDefinir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 62);
            this.Controls.Add(this.cmdDefinir);
            this.Controls.Add(this.txtTexto);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTexto";
            this.Text = "Definir texto do letreiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button cmdDefinir;
    }
}