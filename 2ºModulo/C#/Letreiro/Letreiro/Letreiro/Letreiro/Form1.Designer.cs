namespace Letreiro
{
    partial class frmLetreiro
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
            this.imgLetras = new System.Windows.Forms.PictureBox();
            this.mnuConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.definirTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirCorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diminuirVelocidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentarVelocidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objCor = new System.Windows.Forms.ColorDialog();
            this.objTempo = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.imgLetras)).BeginInit();
            this.mnuConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLetras
            // 
            this.imgLetras.ContextMenuStrip = this.mnuConfig;
            this.imgLetras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLetras.Location = new System.Drawing.Point(0, 0);
            this.imgLetras.Name = "imgLetras";
            this.imgLetras.Size = new System.Drawing.Size(524, 159);
            this.imgLetras.TabIndex = 0;
            this.imgLetras.TabStop = false;
            this.imgLetras.Click += new System.EventHandler(this.imgLetras_Click);
            this.imgLetras.DoubleClick += new System.EventHandler(this.definirTextoToolStripMenuItem_Click);
            // 
            // mnuConfig
            // 
            this.mnuConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definirTextoToolStripMenuItem,
            this.definirCorToolStripMenuItem,
            this.diminuirVelocidadeToolStripMenuItem,
            this.aumentarVelocidadeToolStripMenuItem});
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Size = new System.Drawing.Size(246, 92);
            // 
            // definirTextoToolStripMenuItem
            // 
            this.definirTextoToolStripMenuItem.Name = "definirTextoToolStripMenuItem";
            this.definirTextoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.definirTextoToolStripMenuItem.Text = "Definir texto...";
            this.definirTextoToolStripMenuItem.Click += new System.EventHandler(this.definirTextoToolStripMenuItem_Click);
            // 
            // definirCorToolStripMenuItem
            // 
            this.definirCorToolStripMenuItem.Name = "definirCorToolStripMenuItem";
            this.definirCorToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.definirCorToolStripMenuItem.Text = "Definir cor...";
            this.definirCorToolStripMenuItem.Click += new System.EventHandler(this.definirCorToolStripMenuItem_Click);
            // 
            // diminuirVelocidadeToolStripMenuItem
            // 
            this.diminuirVelocidadeToolStripMenuItem.Name = "diminuirVelocidadeToolStripMenuItem";
            this.diminuirVelocidadeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.diminuirVelocidadeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.diminuirVelocidadeToolStripMenuItem.Text = "Diminuir velocidade";
            this.diminuirVelocidadeToolStripMenuItem.Click += new System.EventHandler(this.diminuirVelocidadeToolStripMenuItem_Click);
            // 
            // aumentarVelocidadeToolStripMenuItem
            // 
            this.aumentarVelocidadeToolStripMenuItem.Name = "aumentarVelocidadeToolStripMenuItem";
            this.aumentarVelocidadeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.aumentarVelocidadeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.aumentarVelocidadeToolStripMenuItem.Text = "Aumentar velocidade";
            this.aumentarVelocidadeToolStripMenuItem.Click += new System.EventHandler(this.aumentarVelocidadeToolStripMenuItem_Click);
            // 
            // objCor
            // 
            this.objCor.Color = System.Drawing.Color.Lime;
            // 
            // objTempo
            // 
            this.objTempo.Enabled = true;
            this.objTempo.Tag = "0";
            this.objTempo.Tick += new System.EventHandler(this.objTempo_Tick);
            // 
            // frmLetreiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 159);
            this.ContextMenuStrip = this.mnuConfig;
            this.Controls.Add(this.imgLetras);
            this.Name = "frmLetreiro";
            this.Text = "Letreiro digital";
            this.Load += new System.EventHandler(this.frmLetreiro_Load);
            this.ResizeEnd += new System.EventHandler(this.frmLetreiro_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.imgLetras)).EndInit();
            this.mnuConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLetras;
        private System.Windows.Forms.ContextMenuStrip mnuConfig;
        private System.Windows.Forms.ToolStripMenuItem definirTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirCorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog objCor;
        private System.Windows.Forms.Timer objTempo;
        private System.Windows.Forms.ToolStripMenuItem diminuirVelocidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aumentarVelocidadeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

