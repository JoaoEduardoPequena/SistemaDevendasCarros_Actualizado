namespace Interfaces
{
    partial class TelaDeVendaActualizada
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
            this.lblNumeroVenda = new System.Windows.Forms.Label();
            this.lblCodigoVenda = new System.Windows.Forms.Label();
            this.txtCodCarro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarcaCarro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantProduto = new System.Windows.Forms.TextBox();
            this.txtValorTotalProduto = new System.Windows.Forms.TextBox();
            this.btAdicionarProdutos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotalCompra = new System.Windows.Forms.TextBox();
            this.btFinalizarCompra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModeloCarro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDataVenda = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroVenda
            // 
            this.lblNumeroVenda.AutoSize = true;
            this.lblNumeroVenda.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenda.ForeColor = System.Drawing.Color.Red;
            this.lblNumeroVenda.Location = new System.Drawing.Point(9, 35);
            this.lblNumeroVenda.Name = "lblNumeroVenda";
            this.lblNumeroVenda.Size = new System.Drawing.Size(134, 17);
            this.lblNumeroVenda.TabIndex = 0;
            this.lblNumeroVenda.Text = "VENDA NÚMERO";
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVenda.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoVenda.Location = new System.Drawing.Point(12, 52);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(125, 31);
            this.lblCodigoVenda.TabIndex = 1;
            this.lblCodigoVenda.Text = "CODIGO";
            // 
            // txtCodCarro
            // 
            this.txtCodCarro.Location = new System.Drawing.Point(156, 35);
            this.txtCodCarro.Name = "txtCodCarro";
            this.txtCodCarro.Size = new System.Drawing.Size(121, 20);
            this.txtCodCarro.TabIndex = 2;
            this.txtCodCarro.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodCarro_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do Carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da Marca do Carro";
            // 
            // txtMarcaCarro
            // 
            this.txtMarcaCarro.Location = new System.Drawing.Point(294, 35);
            this.txtMarcaCarro.Name = "txtMarcaCarro";
            this.txtMarcaCarro.Size = new System.Drawing.Size(196, 20);
            this.txtMarcaCarro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preço do Produto";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(149, 102);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(122, 20);
            this.txtPrecoProduto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade";
            // 
            // txtQuantProduto
            // 
            this.txtQuantProduto.Location = new System.Drawing.Point(294, 102);
            this.txtQuantProduto.Name = "txtQuantProduto";
            this.txtQuantProduto.Size = new System.Drawing.Size(121, 20);
            this.txtQuantProduto.TabIndex = 8;
            this.txtQuantProduto.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantProduto_Validating);
            // 
            // txtValorTotalProduto
            // 
            this.txtValorTotalProduto.Location = new System.Drawing.Point(436, 102);
            this.txtValorTotalProduto.Name = "txtValorTotalProduto";
            this.txtValorTotalProduto.Size = new System.Drawing.Size(121, 20);
            this.txtValorTotalProduto.TabIndex = 10;
            // 
            // btAdicionarProdutos
            // 
            this.btAdicionarProdutos.Location = new System.Drawing.Point(693, 90);
            this.btAdicionarProdutos.Name = "btAdicionarProdutos";
            this.btAdicionarProdutos.Size = new System.Drawing.Size(129, 42);
            this.btAdicionarProdutos.TabIndex = 12;
            this.btAdicionarProdutos.Text = "ADICIONAR PRODUTOS";
            this.btAdicionarProdutos.UseVisualStyleBackColor = true;
            this.btAdicionarProdutos.Click += new System.EventHandler(this.btAdicionarProdutos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valot Total da Compra";
            // 
            // txtValorTotalCompra
            // 
            this.txtValorTotalCompra.Location = new System.Drawing.Point(32, 372);
            this.txtValorTotalCompra.Name = "txtValorTotalCompra";
            this.txtValorTotalCompra.Size = new System.Drawing.Size(193, 20);
            this.txtValorTotalCompra.TabIndex = 14;
            // 
            // btFinalizarCompra
            // 
            this.btFinalizarCompra.Location = new System.Drawing.Point(566, 358);
            this.btFinalizarCompra.Name = "btFinalizarCompra";
            this.btFinalizarCompra.Size = new System.Drawing.Size(256, 42);
            this.btFinalizarCompra.TabIndex = 16;
            this.btFinalizarCompra.Text = "FINALIZAR COMPRA";
            this.btFinalizarCompra.UseVisualStyleBackColor = true;
            this.btFinalizarCompra.Click += new System.EventHandler(this.btFinalizarCompra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Valor Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nome do Modelo do Carro";
            // 
            // txtModeloCarro
            // 
            this.txtModeloCarro.Location = new System.Drawing.Point(512, 35);
            this.txtModeloCarro.Name = "txtModeloCarro";
            this.txtModeloCarro.Size = new System.Drawing.Size(196, 20);
            this.txtModeloCarro.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data da Venda";
            // 
            // dateTimePickerDataVenda
            // 
            this.dateTimePickerDataVenda.CustomFormat = "";
            this.dateTimePickerDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataVenda.Location = new System.Drawing.Point(573, 102);
            this.dateTimePickerDataVenda.Name = "dateTimePickerDataVenda";
            this.dateTimePickerDataVenda.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerDataVenda.TabIndex = 22;
            this.dateTimePickerDataVenda.Value = new System.DateTime(2017, 3, 24, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 184);
            this.dataGridView1.TabIndex = 23;
            // 
            // TelaDeVendaActualizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(868, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerDataVenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtModeloCarro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btFinalizarCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorTotalCompra);
            this.Controls.Add(this.btAdicionarProdutos);
            this.Controls.Add(this.txtValorTotalProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarcaCarro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodCarro);
            this.Controls.Add(this.lblCodigoVenda);
            this.Controls.Add(this.lblNumeroVenda);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPreview = true;
            this.Name = "TelaDeVendaActualizada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela DeVenda Actualizada";
            this.Load += new System.EventHandler(this.TelaDeVendaActualizada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroVenda;
        private System.Windows.Forms.Label lblCodigoVenda;
        private System.Windows.Forms.TextBox txtCodCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarcaCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantProduto;
        private System.Windows.Forms.TextBox txtValorTotalProduto;
        private System.Windows.Forms.Button btAdicionarProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotalCompra;
        private System.Windows.Forms.Button btFinalizarCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModeloCarro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVenda;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}