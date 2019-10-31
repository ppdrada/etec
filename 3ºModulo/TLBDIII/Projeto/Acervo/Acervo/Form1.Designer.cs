namespace Acervo
{
    partial class FrmPrincipal
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
            this.acervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.álbunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpretesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.álbunsListadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acervoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acervoToolStripMenuItem
            // 
            this.acervoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.álbunsToolStripMenuItem,
            this.álbunsListadosToolStripMenuItem,
            this.artistasToolStripMenuItem,
            this.gravadoraToolStripMenuItem,
            this.interpretesToolStripMenuItem,
            this.musicasToolStripMenuItem});
            this.acervoToolStripMenuItem.Name = "acervoToolStripMenuItem";
            this.acervoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.acervoToolStripMenuItem.Text = "Acervo";
            // 
            // álbunsToolStripMenuItem
            // 
            this.álbunsToolStripMenuItem.Name = "álbunsToolStripMenuItem";
            this.álbunsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.álbunsToolStripMenuItem.Text = "Álbuns";
            this.álbunsToolStripMenuItem.Click += new System.EventHandler(this.álbunsToolStripMenuItem_Click);
            // 
            // artistasToolStripMenuItem
            // 
            this.artistasToolStripMenuItem.Name = "artistasToolStripMenuItem";
            this.artistasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.artistasToolStripMenuItem.Text = "Artistas";
            this.artistasToolStripMenuItem.Click += new System.EventHandler(this.artistasToolStripMenuItem_Click);
            // 
            // gravadoraToolStripMenuItem
            // 
            this.gravadoraToolStripMenuItem.Name = "gravadoraToolStripMenuItem";
            this.gravadoraToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gravadoraToolStripMenuItem.Text = "Gravadora";
            this.gravadoraToolStripMenuItem.Click += new System.EventHandler(this.gravadoraToolStripMenuItem_Click);
            // 
            // interpretesToolStripMenuItem
            // 
            this.interpretesToolStripMenuItem.Name = "interpretesToolStripMenuItem";
            this.interpretesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.interpretesToolStripMenuItem.Text = "Interpretes";
            this.interpretesToolStripMenuItem.Click += new System.EventHandler(this.interpretesToolStripMenuItem_Click);
            // 
            // musicasToolStripMenuItem
            // 
            this.musicasToolStripMenuItem.Name = "musicasToolStripMenuItem";
            this.musicasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.musicasToolStripMenuItem.Text = "Musicas";
            this.musicasToolStripMenuItem.Click += new System.EventHandler(this.musicasToolStripMenuItem_Click);
            // 
            // álbunsListadosToolStripMenuItem
            // 
            this.álbunsListadosToolStripMenuItem.Name = "álbunsListadosToolStripMenuItem";
            this.álbunsListadosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.álbunsListadosToolStripMenuItem.Text = "Álbuns listados";
            this.álbunsListadosToolStripMenuItem.Click += new System.EventHandler(this.álbunsListadosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acervoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem álbunsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpretesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem álbunsListadosToolStripMenuItem;
    }
}

