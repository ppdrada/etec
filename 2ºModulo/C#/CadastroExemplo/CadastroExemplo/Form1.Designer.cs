namespace CadastroExemplo
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
            this.cmdGenero = new System.Windows.Forms.Button();
            this.cmdDiretor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFilme = new System.Windows.Forms.Button();
            this.cmdAtores = new System.Windows.Forms.Button();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdGenero
            // 
            this.cmdGenero.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenero.Image = global::CadastroExemplo.Properties.Resources.generos_menor;
            this.cmdGenero.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdGenero.Location = new System.Drawing.Point(375, 132);
            this.cmdGenero.Name = "cmdGenero";
            this.cmdGenero.Padding = new System.Windows.Forms.Padding(10);
            this.cmdGenero.Size = new System.Drawing.Size(150, 150);
            this.cmdGenero.TabIndex = 1;
            this.cmdGenero.Text = "Generos";
            this.cmdGenero.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cmdGenero.UseVisualStyleBackColor = true;
            this.cmdGenero.Click += new System.EventHandler(this.cmdGenero_Click);
            // 
            // cmdDiretor
            // 
            this.cmdDiretor.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDiretor.Image = global::CadastroExemplo.Properties.Resources.diretores_menor;
            this.cmdDiretor.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdDiretor.Location = new System.Drawing.Point(219, 288);
            this.cmdDiretor.Name = "cmdDiretor";
            this.cmdDiretor.Padding = new System.Windows.Forms.Padding(10);
            this.cmdDiretor.Size = new System.Drawing.Size(150, 150);
            this.cmdDiretor.TabIndex = 2;
            this.cmdDiretor.Text = "Diretores";
            this.cmdDiretor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cmdDiretor.UseVisualStyleBackColor = true;
            this.cmdDiretor.Click += new System.EventHandler(this.cmdDiretor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerenciamento de midias";
            // 
            // cmdFilme
            // 
            this.cmdFilme.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFilme.Image = global::CadastroExemplo.Properties.Resources.filmes;
            this.cmdFilme.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdFilme.Location = new System.Drawing.Point(63, 132);
            this.cmdFilme.Name = "cmdFilme";
            this.cmdFilme.Padding = new System.Windows.Forms.Padding(10);
            this.cmdFilme.Size = new System.Drawing.Size(306, 150);
            this.cmdFilme.TabIndex = 3;
            this.cmdFilme.Text = "Filme";
            this.cmdFilme.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cmdFilme.UseVisualStyleBackColor = true;
            this.cmdFilme.Click += new System.EventHandler(this.cmdFilme_Click);
            // 
            // cmdAtores
            // 
            this.cmdAtores.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAtores.Image = global::CadastroExemplo.Properties.Resources.atores_menor;
            this.cmdAtores.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdAtores.Location = new System.Drawing.Point(63, 288);
            this.cmdAtores.Name = "cmdAtores";
            this.cmdAtores.Padding = new System.Windows.Forms.Padding(10);
            this.cmdAtores.Size = new System.Drawing.Size(150, 150);
            this.cmdAtores.TabIndex = 0;
            this.cmdAtores.Text = "Atores";
            this.cmdAtores.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cmdAtores.UseVisualStyleBackColor = true;
            this.cmdAtores.Click += new System.EventHandler(this.cmdAtores_Click);
            // 
            // cmdFechar
            // 
            this.cmdFechar.BackColor = System.Drawing.Color.Black;
            this.cmdFechar.FlatAppearance.BorderSize = 0;
            this.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFechar.ForeColor = System.Drawing.Color.White;
            this.cmdFechar.Location = new System.Drawing.Point(602, -1);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(49, 31);
            this.cmdFechar.TabIndex = 5;
            this.cmdFechar.Text = "x";
            this.cmdFechar.UseVisualStyleBackColor = false;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(650, 480);
            this.Controls.Add(this.cmdFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdFilme);
            this.Controls.Add(this.cmdDiretor);
            this.Controls.Add(this.cmdGenero);
            this.Controls.Add(this.cmdAtores);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAtores;
        private System.Windows.Forms.Button cmdGenero;
        private System.Windows.Forms.Button cmdDiretor;
        private System.Windows.Forms.Button cmdFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFechar;
    }
}

