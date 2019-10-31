namespace CadastroExemplo
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.cmdAlterar = new System.Windows.Forms.Button();
            this.cmdApagar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.grdLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procurar registro...";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 26);
            this.txtNome.TabIndex = 2;
            this.txtNome.Tag = "0";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(17, 135);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(213, 26);
            this.txtPesquisa.TabIndex = 3;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(155, 65);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 34);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdGravar
            // 
            this.cmdGravar.Location = new System.Drawing.Point(236, 65);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(75, 34);
            this.cmdGravar.TabIndex = 5;
            this.cmdGravar.Text = "Gravar";
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(236, 135);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(75, 34);
            this.cmdPesquisar.TabIndex = 6;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Location = new System.Drawing.Point(74, 365);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(75, 34);
            this.cmdAlterar.TabIndex = 7;
            this.cmdAlterar.Text = "Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cmdApagar
            // 
            this.cmdApagar.Location = new System.Drawing.Point(155, 365);
            this.cmdApagar.Name = "cmdApagar";
            this.cmdApagar.Size = new System.Drawing.Size(75, 34);
            this.cmdApagar.TabIndex = 8;
            this.cmdApagar.Text = "Excluir";
            this.cmdApagar.UseVisualStyleBackColor = true;
            this.cmdApagar.Click += new System.EventHandler(this.cmdApagar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(236, 365);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 34);
            this.cmdSair.TabIndex = 9;
            this.cmdSair.Text = "Fechar";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // grdLista
            // 
            this.grdLista.AllowUserToAddRows = false;
            this.grdLista.AllowUserToDeleteRows = false;
            this.grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLista.Location = new System.Drawing.Point(16, 209);
            this.grdLista.Name = "grdLista";
            this.grdLista.ReadOnly = true;
            this.grdLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLista.Size = new System.Drawing.Size(295, 150);
            this.grdLista.TabIndex = 10;
            this.grdLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLista_CellDoubleClick);
            // 
            // frmCadastro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(328, 417);
            this.Controls.Add(this.grdLista);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdApagar);
            this.Controls.Add(this.cmdAlterar);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGravar;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdApagar;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.DataGridView grdLista;
    }
}