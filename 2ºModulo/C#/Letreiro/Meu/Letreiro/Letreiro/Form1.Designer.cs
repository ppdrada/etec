namespace Letreiro
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
            this.components = new System.ComponentModel.Container();
            this.objTela = new System.Windows.Forms.PictureBox();
            this.txtmostrar = new System.Windows.Forms.TextBox();
            this.objTempo = new System.Windows.Forms.Timer(this.components);
            this.enviar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.objTela)).BeginInit();
            this.SuspendLayout();
            // 
            // objTela
            // 
            this.objTela.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.objTela.Location = new System.Drawing.Point(0, 69);
            this.objTela.Name = "objTela";
            this.objTela.Size = new System.Drawing.Size(850, 138);
            this.objTela.TabIndex = 0;
            this.objTela.TabStop = false;
            this.objTela.Click += new System.EventHandler(this.objTela_Click);
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(61, 32);
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(412, 20);
            this.txtmostrar.TabIndex = 1;
            this.txtmostrar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // objTempo
            // 
            this.objTempo.Interval = 2000;
            this.objTempo.Tick += new System.EventHandler(this.objTempo_Tick);
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(516, 32);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 2;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 207);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.objTela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.PictureBox objTela;
        private System.Windows.Forms.TextBox txtmostrar;
        private System.Windows.Forms.Timer objTempo;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

