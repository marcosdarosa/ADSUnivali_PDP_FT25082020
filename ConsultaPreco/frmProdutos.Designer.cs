﻿namespace ConsultaPreco
{
    partial class frmProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.txtAplicacao = new System.Windows.Forms.TextBox();
            this.lblAplicacao = new System.Windows.Forms.Label();
            this.lblUn = new System.Windows.Forms.Label();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.lblCodBar = new System.Windows.Forms.Label();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mtxtPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDecricao = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAplicacao
            // 
            this.txtAplicacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAplicacao.Location = new System.Drawing.Point(10, 120);
            this.txtAplicacao.Name = "txtAplicacao";
            this.txtAplicacao.Size = new System.Drawing.Size(675, 20);
            this.txtAplicacao.TabIndex = 4;
            // 
            // lblAplicacao
            // 
            this.lblAplicacao.AutoSize = true;
            this.lblAplicacao.Location = new System.Drawing.Point(7, 104);
            this.lblAplicacao.Name = "lblAplicacao";
            this.lblAplicacao.Size = new System.Drawing.Size(54, 13);
            this.lblAplicacao.TabIndex = 55;
            this.lblAplicacao.Text = "Aplicação";
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.Location = new System.Drawing.Point(765, 58);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(23, 13);
            this.lblUn.TabIndex = 54;
            this.lblUn.Text = "UN";
            // 
            // txtUn
            // 
            this.txtUn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUn.Location = new System.Drawing.Point(760, 73);
            this.txtUn.MaxLength = 2;
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(31, 20);
            this.txtUn.TabIndex = 3;
            // 
            // lblCodBar
            // 
            this.lblCodBar.AutoSize = true;
            this.lblCodBar.Location = new System.Drawing.Point(601, 58);
            this.lblCodBar.Name = "lblCodBar";
            this.lblCodBar.Size = new System.Drawing.Size(88, 13);
            this.lblCodBar.TabIndex = 52;
            this.lblCodBar.Text = "Código de Barras";
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(604, 73);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(150, 20);
            this.txtCodBar.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(9, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(73, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 46;
            this.lblCodigo.Text = "Código";
            // 
            // mtxtPreco
            // 
            this.mtxtPreco.Location = new System.Drawing.Point(691, 120);
            this.mtxtPreco.Name = "mtxtPreco";
            this.mtxtPreco.Size = new System.Drawing.Size(100, 20);
            this.mtxtPreco.TabIndex = 5;
            this.mtxtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(10, 73);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(588, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDecricao
            // 
            this.lblDecricao.AutoSize = true;
            this.lblDecricao.Location = new System.Drawing.Point(7, 57);
            this.lblDecricao.Name = "lblDecricao";
            this.lblDecricao.Size = new System.Drawing.Size(55, 13);
            this.lblDecricao.TabIndex = 47;
            this.lblDecricao.Text = "Descrição";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(756, 104);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 49;
            this.lblPreco.Text = "Preço";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(630, 171);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(74, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(717, 171);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 204);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtAplicacao);
            this.Controls.Add(this.lblAplicacao);
            this.Controls.Add(this.lblUn);
            this.Controls.Add(this.txtUn);
            this.Controls.Add(this.lblCodBar);
            this.Controls.Add(this.txtCodBar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.mtxtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDecricao);
            this.Controls.Add(this.lblPreco);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAplicacao;
        private System.Windows.Forms.Label lblAplicacao;
        private System.Windows.Forms.Label lblUn;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.Label lblCodBar;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mtxtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDecricao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
    }
}

