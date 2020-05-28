namespace Interfaces
{
    partial class CadEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox_Tipos_De_Pesquisas = new System.Windows.Forms.GroupBox();
            this.radioButton_Pesado = new System.Windows.Forms.RadioButton();
            this.radioButton_Ligeiro = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Marcas_De_Carros = new System.Windows.Forms.ListBox();
            this.txtCodigoEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btApagar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesquisarPorMarcaDoCarro = new System.Windows.Forms.TextBox();
            this.dataGridView_ConsultaEstoque = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_Tipos_De_Pesquisas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConsultaEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtCodigoEstoque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuantidadeEstoque);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Estoque";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox_Tipos_De_Pesquisas);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.listBox_Marcas_De_Carros);
            this.groupBox4.Location = new System.Drawing.Point(443, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 222);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadastrar Dados Por";
            // 
            // groupBox_Tipos_De_Pesquisas
            // 
            this.groupBox_Tipos_De_Pesquisas.Controls.Add(this.radioButton_Pesado);
            this.groupBox_Tipos_De_Pesquisas.Controls.Add(this.radioButton_Ligeiro);
            this.groupBox_Tipos_De_Pesquisas.Location = new System.Drawing.Point(26, 27);
            this.groupBox_Tipos_De_Pesquisas.Name = "groupBox_Tipos_De_Pesquisas";
            this.groupBox_Tipos_De_Pesquisas.Size = new System.Drawing.Size(143, 73);
            this.groupBox_Tipos_De_Pesquisas.TabIndex = 5;
            this.groupBox_Tipos_De_Pesquisas.TabStop = false;
            this.groupBox_Tipos_De_Pesquisas.Text = " Categoria De Carro";
            // 
            // radioButton_Pesado
            // 
            this.radioButton_Pesado.AutoSize = true;
            this.radioButton_Pesado.Location = new System.Drawing.Point(16, 46);
            this.radioButton_Pesado.Name = "radioButton_Pesado";
            this.radioButton_Pesado.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Pesado.TabIndex = 1;
            this.radioButton_Pesado.Text = "Pesado";
            this.radioButton_Pesado.UseVisualStyleBackColor = true;
            this.radioButton_Pesado.CheckedChanged += new System.EventHandler(this.radioButton_Pesado_CheckedChanged);
            // 
            // radioButton_Ligeiro
            // 
            this.radioButton_Ligeiro.AutoSize = true;
            this.radioButton_Ligeiro.Location = new System.Drawing.Point(16, 23);
            this.radioButton_Ligeiro.Name = "radioButton_Ligeiro";
            this.radioButton_Ligeiro.Size = new System.Drawing.Size(56, 17);
            this.radioButton_Ligeiro.TabIndex = 0;
            this.radioButton_Ligeiro.Text = "Ligeiro";
            this.radioButton_Ligeiro.UseVisualStyleBackColor = true;
            this.radioButton_Ligeiro.CheckedChanged += new System.EventHandler(this.radioButton_Ligeiro_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selecciona Um Modelo de Carro";
            // 
            // listBox_Marcas_De_Carros
            // 
            this.listBox_Marcas_De_Carros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Marcas_De_Carros.FormattingEnabled = true;
            this.listBox_Marcas_De_Carros.HorizontalScrollbar = true;
            this.listBox_Marcas_De_Carros.Location = new System.Drawing.Point(263, 36);
            this.listBox_Marcas_De_Carros.Name = "listBox_Marcas_De_Carros";
            this.listBox_Marcas_De_Carros.Size = new System.Drawing.Size(146, 145);
            this.listBox_Marcas_De_Carros.TabIndex = 9;
            // 
            // txtCodigoEstoque
            // 
            this.txtCodigoEstoque.Location = new System.Drawing.Point(142, 37);
            this.txtCodigoEstoque.Name = "txtCodigoEstoque";
            this.txtCodigoEstoque.ReadOnly = true;
            this.txtCodigoEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEstoque.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código do Estoque";
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(142, 97);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeEstoque.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btApagar);
            this.groupBox2.Controls.Add(this.btAlterar);
            this.groupBox2.Controls.Add(this.btCancelar);
            this.groupBox2.Controls.Add(this.btNovo);
            this.groupBox2.Controls.Add(this.btSalvar);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(566, 19);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(120, 53);
            this.btApagar.TabIndex = 9;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(418, 19);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(110, 53);
            this.btAlterar.TabIndex = 8;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(726, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(112, 53);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(106, 19);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(121, 53);
            this.btNovo.TabIndex = 6;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(268, 19);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(120, 53);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPesquisarPorMarcaDoCarro);
            this.groupBox3.Controls.Add(this.dataGridView_ConsultaEstoque);
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(944, 209);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Da Pesquisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digita A Marca Do Carro Para Pesquisar";
            // 
            // txtPesquisarPorMarcaDoCarro
            // 
            this.txtPesquisarPorMarcaDoCarro.Location = new System.Drawing.Point(337, 26);
            this.txtPesquisarPorMarcaDoCarro.Name = "txtPesquisarPorMarcaDoCarro";
            this.txtPesquisarPorMarcaDoCarro.Size = new System.Drawing.Size(307, 20);
            this.txtPesquisarPorMarcaDoCarro.TabIndex = 2;
            this.txtPesquisarPorMarcaDoCarro.TextChanged += new System.EventHandler(this.txtPesquisarPorMarcaDoCarro_TextChanged);
            // 
            // dataGridView_ConsultaEstoque
            // 
            this.dataGridView_ConsultaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ConsultaEstoque.Location = new System.Drawing.Point(170, 58);
            this.dataGridView_ConsultaEstoque.MultiSelect = false;
            this.dataGridView_ConsultaEstoque.Name = "dataGridView_ConsultaEstoque";
            this.dataGridView_ConsultaEstoque.ReadOnly = true;
            this.dataGridView_ConsultaEstoque.RowHeadersWidth = 42;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView_ConsultaEstoque.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ConsultaEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ConsultaEstoque.Size = new System.Drawing.Size(474, 118);
            this.dataGridView_ConsultaEstoque.TabIndex = 1;
            this.dataGridView_ConsultaEstoque.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ConsultaEstoque_CellMouseClick);
            // 
            // CadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CadEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadEstoque";
            this.Load += new System.EventHandler(this.CadEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_Tipos_De_Pesquisas.ResumeLayout(false);
            this.groupBox_Tipos_De_Pesquisas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConsultaEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_Tipos_De_Pesquisas;
        private System.Windows.Forms.RadioButton radioButton_Pesado;
        private System.Windows.Forms.RadioButton radioButton_Ligeiro;
        private System.Windows.Forms.DataGridView dataGridView_ConsultaEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesquisarPorMarcaDoCarro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_Marcas_De_Carros;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}