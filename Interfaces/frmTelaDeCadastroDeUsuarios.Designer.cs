namespace Interfaces
{
    partial class frmTelaDeCadastroDeUsuarios
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
            this.groupBox1_Dados_De_Usuario = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.txtFuncao_Usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesquisarPorNome = new System.Windows.Forms.TextBox();
            this.btPesquisarPorCodigo = new System.Windows.Forms.Button();
            this.dataGridView_Usuarios = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisarPorCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1_Dados_De_Usuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1_Dados_De_Usuario
            // 
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.panel1);
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.txtFuncao_Usuario);
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.label4);
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.txtSenhaUsuario);
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.label3);
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.txtNomeUsuario);
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.label2);
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.txtCodUsuario);
            this.groupBox1_Dados_De_Usuario.Controls.Add(this.label1);
            this.groupBox1_Dados_De_Usuario.Location = new System.Drawing.Point(4, 2);
            this.groupBox1_Dados_De_Usuario.Name = "groupBox1_Dados_De_Usuario";
            this.groupBox1_Dados_De_Usuario.Size = new System.Drawing.Size(650, 185);
            this.groupBox1_Dados_De_Usuario.TabIndex = 1;
            this.groupBox1_Dados_De_Usuario.TabStop = false;
            this.groupBox1_Dados_De_Usuario.Text = "Dados de Usuarios";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btApagar);
            this.panel1.Controls.Add(this.btAlterar);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Location = new System.Drawing.Point(22, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 55);
            this.panel1.TabIndex = 8;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(458, 10);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 42);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(361, 10);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 42);
            this.btApagar.TabIndex = 3;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(262, 10);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 42);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(167, 10);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 42);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(72, 10);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 42);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // txtFuncao_Usuario
            // 
            this.txtFuncao_Usuario.Location = new System.Drawing.Point(112, 95);
            this.txtFuncao_Usuario.Name = "txtFuncao_Usuario";
            this.txtFuncao_Usuario.Size = new System.Drawing.Size(376, 20);
            this.txtFuncao_Usuario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Função";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(388, 32);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(112, 62);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(376, 20);
            this.txtNomeUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Location = new System.Drawing.Point(112, 32);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.ReadOnly = true;
            this.txtCodUsuario.Size = new System.Drawing.Size(66, 20);
            this.txtCodUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Usuário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPesquisarPorNome);
            this.groupBox1.Controls.Add(this.btPesquisarPorCodigo);
            this.groupBox1.Controls.Add(this.dataGridView_Usuarios);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPesquisarPorCodigo);
            this.groupBox1.Location = new System.Drawing.Point(4, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Pesquisa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pesquisar Por Nome";
            // 
            // txtPesquisarPorNome
            // 
            this.txtPesquisarPorNome.Location = new System.Drawing.Point(187, 47);
            this.txtPesquisarPorNome.Name = "txtPesquisarPorNome";
            this.txtPesquisarPorNome.Size = new System.Drawing.Size(276, 20);
            this.txtPesquisarPorNome.TabIndex = 18;
            this.txtPesquisarPorNome.TextChanged += new System.EventHandler(this.txtPesquisarPorNome_TextChanged);
            // 
            // btPesquisarPorCodigo
            // 
            this.btPesquisarPorCodigo.Location = new System.Drawing.Point(317, 16);
            this.btPesquisarPorCodigo.Name = "btPesquisarPorCodigo";
            this.btPesquisarPorCodigo.Size = new System.Drawing.Size(75, 28);
            this.btPesquisarPorCodigo.TabIndex = 17;
            this.btPesquisarPorCodigo.Text = "Pesquisar Codigo";
            this.btPesquisarPorCodigo.UseVisualStyleBackColor = true;
            this.btPesquisarPorCodigo.Click += new System.EventHandler(this.btPesquisarPorCodigo_Click_1);
            // 
            // dataGridView_Usuarios
            // 
            this.dataGridView_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Usuarios.Location = new System.Drawing.Point(69, 77);
            this.dataGridView_Usuarios.MultiSelect = false;
            this.dataGridView_Usuarios.Name = "dataGridView_Usuarios";
            this.dataGridView_Usuarios.ReadOnly = true;
            this.dataGridView_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Usuarios.Size = new System.Drawing.Size(494, 155);
            this.dataGridView_Usuarios.TabIndex = 16;
            this.dataGridView_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Usuarios_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pesquisar Por Código ";
            // 
            // txtPesquisarPorCodigo
            // 
            this.txtPesquisarPorCodigo.Location = new System.Drawing.Point(187, 23);
            this.txtPesquisarPorCodigo.Name = "txtPesquisarPorCodigo";
            this.txtPesquisarPorCodigo.Size = new System.Drawing.Size(117, 20);
            this.txtPesquisarPorCodigo.TabIndex = 14;
            this.txtPesquisarPorCodigo.MouseLeave += new System.EventHandler(this.txtPesquisarPorCodigo_MouseLeave);
            // 
            // frmTelaDeCadastroDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox1_Dados_De_Usuario);
            this.MaximizeBox = false;
            this.Name = "frmTelaDeCadastroDeUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmTelaDeCadastroDeUsuarios_Load);
            this.groupBox1_Dados_De_Usuario.ResumeLayout(false);
            this.groupBox1_Dados_De_Usuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_Dados_De_Usuario;
        private System.Windows.Forms.TextBox txtFuncao_Usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesquisarPorNome;
        private System.Windows.Forms.Button btPesquisarPorCodigo;
        private System.Windows.Forms.DataGridView dataGridView_Usuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisarPorCodigo;
        private System.Windows.Forms.Button btCancelar;
    }
}