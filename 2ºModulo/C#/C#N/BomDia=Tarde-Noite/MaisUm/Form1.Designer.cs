namespace MaisUm
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
            this.cmdTestar = new System.Windows.Forms.Button();
            this.textOpcao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdTestar
            // 
            this.cmdTestar.Location = new System.Drawing.Point(98, 110);
            this.cmdTestar.Name = "cmdTestar";
            this.cmdTestar.Size = new System.Drawing.Size(75, 23);
            this.cmdTestar.TabIndex = 0;
            this.cmdTestar.Text = "button1";
            this.cmdTestar.UseVisualStyleBackColor = true;
            this.cmdTestar.Click += new System.EventHandler(this.cmdTestar_Click);
            // 
            // textOpcao
            // 
            this.textOpcao.BackColor = System.Drawing.Color.White;
            this.textOpcao.Location = new System.Drawing.Point(63, 73);
            this.textOpcao.Name = "textOpcao";
            this.textOpcao.Size = new System.Drawing.Size(146, 20);
            this.textOpcao.TabIndex = 1;
            this.textOpcao.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textOpcao);
            this.Controls.Add(this.cmdTestar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdTestar;
        private System.Windows.Forms.TextBox textOpcao;
    }
}

