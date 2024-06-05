namespace SoftwareMercado
{
    partial class frmPrincipal
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
            this.inpProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.inpQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.inpValor = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lsvInfoProduto = new System.Windows.Forms.ListView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // inpProduto
            // 
            this.inpProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpProduto.Location = new System.Drawing.Point(23, 89);
            this.inpProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inpProduto.Name = "inpProduto";
            this.inpProduto.Size = new System.Drawing.Size(451, 41);
            this.inpProduto.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(17, 55);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(79, 29);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Nome";
            // 
            // inpQuantidade
            // 
            this.inpQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpQuantidade.Location = new System.Drawing.Point(23, 177);
            this.inpQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inpQuantidade.Name = "inpQuantidade";
            this.inpQuantidade.Size = new System.Drawing.Size(451, 41);
            this.inpQuantidade.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(17, 144);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(138, 29);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.inpValor);
            this.groupBox1.Controls.Add(this.inpQuantidade);
            this.groupBox1.Controls.Add(this.lblQuantidade);
            this.groupBox1.Controls.Add(this.inpProduto);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(509, 350);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUTO";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(17, 244);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(69, 29);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor";
            // 
            // inpValor
            // 
            this.inpValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpValor.Location = new System.Drawing.Point(23, 277);
            this.inpValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inpValor.Name = "inpValor";
            this.inpValor.Size = new System.Drawing.Size(451, 41);
            this.inpValor.TabIndex = 4;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(8, 370);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(508, 57);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // grbTotal
            // 
            this.grbTotal.Controls.Add(this.lblTotal);
            this.grbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTotal.Location = new System.Drawing.Point(8, 448);
            this.grbTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbTotal.Size = new System.Drawing.Size(507, 92);
            this.grbTotal.TabIndex = 6;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "TOTAL DA VENDA";
            this.grbTotal.Enter += new System.EventHandler(this.grbTotal_Enter);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 38);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(170, 42);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "R$ 00,00";
            // 
            // lsvInfoProduto
            // 
            this.lsvInfoProduto.HideSelection = false;
            this.lsvInfoProduto.Location = new System.Drawing.Point(531, 27);
            this.lsvInfoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsvInfoProduto.Name = "lsvInfoProduto";
            this.lsvInfoProduto.Size = new System.Drawing.Size(524, 398);
            this.lsvInfoProduto.TabIndex = 7;
            this.lsvInfoProduto.UseCompatibleStateImageBehavior = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(531, 465);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(257, 74);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Nova Venda";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(799, 466);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(257, 74);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lsvInfoProduto);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Caixa ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbTotal.ResumeLayout(false);
            this.grbTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inpProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox inpQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox inpValor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox grbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListView lsvInfoProduto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

