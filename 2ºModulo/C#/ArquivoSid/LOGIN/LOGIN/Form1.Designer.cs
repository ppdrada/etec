namespace LOGIN
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janela1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janela2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janela3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.janela1ToolStripMenuItem,
            this.janela2ToolStripMenuItem,
            this.janela3ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // janela1ToolStripMenuItem
            // 
            this.janela1ToolStripMenuItem.Name = "janela1ToolStripMenuItem";
            this.janela1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.janela1ToolStripMenuItem.Text = "Janela 1";
            this.janela1ToolStripMenuItem.Click += new System.EventHandler(this.janela1ToolStripMenuItem_Click);
            // 
            // janela2ToolStripMenuItem
            // 
            this.janela2ToolStripMenuItem.Name = "janela2ToolStripMenuItem";
            this.janela2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.janela2ToolStripMenuItem.Text = "Janela 2";
            this.janela2ToolStripMenuItem.Click += new System.EventHandler(this.janela2ToolStripMenuItem_Click);
            // 
            // janela3ToolStripMenuItem
            // 
            this.janela3ToolStripMenuItem.Name = "janela3ToolStripMenuItem";
            this.janela3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.janela3ToolStripMenuItem.Text = "Janela 3";
            this.janela3ToolStripMenuItem.Click += new System.EventHandler(this.janela3ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janela1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janela2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janela3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

