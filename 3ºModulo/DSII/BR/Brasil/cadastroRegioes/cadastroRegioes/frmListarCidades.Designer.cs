namespace cadastroRegioes
{
    partial class frmListarCidades
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
            this.dtCidade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCidade
            // 
            this.dtCidade.AllowUserToAddRows = false;
            this.dtCidade.AllowUserToDeleteRows = false;
            this.dtCidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCidade.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCidade.Location = new System.Drawing.Point(0, 0);
            this.dtCidade.Name = "dtCidade";
            this.dtCidade.ReadOnly = true;
            this.dtCidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCidade.Size = new System.Drawing.Size(606, 550);
            this.dtCidade.TabIndex = 6;
            // 
            // frmListarCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 550);
            this.Controls.Add(this.dtCidade);
            this.Name = "frmListarCidades";
            this.Text = "ListarCidades";
            this.Load += new System.EventHandler(this.ListarCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCidade;

    }
}