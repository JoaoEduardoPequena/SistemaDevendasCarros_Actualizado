namespace Interfaces
{
    partial class frmTela_De_Cadastro_De_Carros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTela_De_Cadastro_De_Carros));
            this.grupoBox_TelaCad_Carro = new System.Windows.Forms.GroupBox();
            this.txtCor_Carro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrigemCarro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Seleccionar_Transmissao_Do_Carro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboxBoxSeleccionar_Combustivel_Do_Motor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_SeleccionarCategoriaCarro = new System.Windows.Forms.ComboBox();
            this.txtKilometragemCarro = new System.Windows.Forms.TextBox();
            this.txtMarcaCarro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModeloCarro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo_Carro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Botoes = new System.Windows.Forms.GroupBox();
            this.btApagar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox_PesquisarCarros = new System.Windows.Forms.GroupBox();
            this.btPesquisarPorCodigo = new System.Windows.Forms.Button();
            this.txtPesquisarPorNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPesquisarPorCodigoCarro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_DadosCarros = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAdicionarFoto = new System.Windows.Forms.Button();
            this.CodCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem_carro = new System.Windows.Forms.DataGridViewImageColumn();
            this.grupoBox_TelaCad_Carro.SuspendLayout();
            this.groupBox_Botoes.SuspendLayout();
            this.groupBox_PesquisarCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DadosCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoBox_TelaCad_Carro
            // 
            this.grupoBox_TelaCad_Carro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoBox_TelaCad_Carro.Controls.Add(this.btAdicionarFoto);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.pictureBox1);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.txtCor_Carro);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label9);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.txtOrigemCarro);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label5);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.comboBox_Seleccionar_Transmissao_Do_Carro);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label8);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label7);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.ComboxBoxSeleccionar_Combustivel_Do_Motor);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label6);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.comboBox_SeleccionarCategoriaCarro);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.txtKilometragemCarro);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.txtMarcaCarro);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label4);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label3);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.txtModeloCarro);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label2);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.txtCodigo_Carro);
            this.grupoBox_TelaCad_Carro.Controls.Add(this.label1);
            this.grupoBox_TelaCad_Carro.Location = new System.Drawing.Point(11, 1);
            this.grupoBox_TelaCad_Carro.Name = "grupoBox_TelaCad_Carro";
            this.grupoBox_TelaCad_Carro.Size = new System.Drawing.Size(1013, 301);
            this.grupoBox_TelaCad_Carro.TabIndex = 0;
            this.grupoBox_TelaCad_Carro.TabStop = false;
            this.grupoBox_TelaCad_Carro.Text = "Dados do Carro";
            // 
            // txtCor_Carro
            // 
            this.txtCor_Carro.Location = new System.Drawing.Point(90, 227);
            this.txtCor_Carro.Name = "txtCor_Carro";
            this.txtCor_Carro.Size = new System.Drawing.Size(117, 20);
            this.txtCor_Carro.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(19, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cor";
            // 
            // txtOrigemCarro
            // 
            this.txtOrigemCarro.Location = new System.Drawing.Point(90, 188);
            this.txtOrigemCarro.Name = "txtOrigemCarro";
            this.txtOrigemCarro.Size = new System.Drawing.Size(142, 20);
            this.txtOrigemCarro.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(18, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Origem";
            // 
            // comboBox_Seleccionar_Transmissao_Do_Carro
            // 
            this.comboBox_Seleccionar_Transmissao_Do_Carro.FormattingEnabled = true;
            this.comboBox_Seleccionar_Transmissao_Do_Carro.Location = new System.Drawing.Point(446, 115);
            this.comboBox_Seleccionar_Transmissao_Do_Carro.Name = "comboBox_Seleccionar_Transmissao_Do_Carro";
            this.comboBox_Seleccionar_Transmissao_Do_Carro.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Seleccionar_Transmissao_Do_Carro.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(443, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Transmissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(443, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Combustivel";
            // 
            // ComboxBoxSeleccionar_Combustivel_Do_Motor
            // 
            this.ComboxBoxSeleccionar_Combustivel_Do_Motor.FormattingEnabled = true;
            this.ComboxBoxSeleccionar_Combustivel_Do_Motor.Location = new System.Drawing.Point(444, 170);
            this.ComboxBoxSeleccionar_Combustivel_Do_Motor.Name = "ComboxBoxSeleccionar_Combustivel_Do_Motor";
            this.ComboxBoxSeleccionar_Combustivel_Do_Motor.Size = new System.Drawing.Size(125, 21);
            this.ComboxBoxSeleccionar_Combustivel_Do_Motor.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(445, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Categoria de Carro";
            // 
            // comboBox_SeleccionarCategoriaCarro
            // 
            this.comboBox_SeleccionarCategoriaCarro.FormattingEnabled = true;
            this.comboBox_SeleccionarCategoriaCarro.Location = new System.Drawing.Point(446, 65);
            this.comboBox_SeleccionarCategoriaCarro.Name = "comboBox_SeleccionarCategoriaCarro";
            this.comboBox_SeleccionarCategoriaCarro.Size = new System.Drawing.Size(120, 21);
            this.comboBox_SeleccionarCategoriaCarro.TabIndex = 6;
            // 
            // txtKilometragemCarro
            // 
            this.txtKilometragemCarro.Location = new System.Drawing.Point(90, 148);
            this.txtKilometragemCarro.Name = "txtKilometragemCarro";
            this.txtKilometragemCarro.Size = new System.Drawing.Size(205, 20);
            this.txtKilometragemCarro.TabIndex = 3;
            // 
            // txtMarcaCarro
            // 
            this.txtMarcaCarro.Location = new System.Drawing.Point(90, 63);
            this.txtMarcaCarro.Name = "txtMarcaCarro";
            this.txtMarcaCarro.Size = new System.Drawing.Size(280, 20);
            this.txtMarcaCarro.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtMarcaCarro, "O Preenchimento Deste Campo e Obrigatorio");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kilometragem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // txtModeloCarro
            // 
            this.txtModeloCarro.Location = new System.Drawing.Point(90, 99);
            this.txtModeloCarro.Name = "txtModeloCarro";
            this.txtModeloCarro.Size = new System.Drawing.Size(216, 20);
            this.txtModeloCarro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // txtCodigo_Carro
            // 
            this.txtCodigo_Carro.Location = new System.Drawing.Point(90, 23);
            this.txtCodigo_Carro.Name = "txtCodigo_Carro";
            this.txtCodigo_Carro.ReadOnly = true;
            this.txtCodigo_Carro.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo_Carro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Carro";
            // 
            // groupBox_Botoes
            // 
            this.groupBox_Botoes.Controls.Add(this.btApagar);
            this.groupBox_Botoes.Controls.Add(this.btAlterar);
            this.groupBox_Botoes.Controls.Add(this.btCancelar);
            this.groupBox_Botoes.Controls.Add(this.btNovo);
            this.groupBox_Botoes.Controls.Add(this.btSalvar);
            this.groupBox_Botoes.Location = new System.Drawing.Point(12, 304);
            this.groupBox_Botoes.Name = "groupBox_Botoes";
            this.groupBox_Botoes.Size = new System.Drawing.Size(1012, 80);
            this.groupBox_Botoes.TabIndex = 1;
            this.groupBox_Botoes.TabStop = false;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(578, 19);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(120, 53);
            this.btApagar.TabIndex = 4;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(430, 19);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(110, 53);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(738, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(112, 53);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(118, 19);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(121, 53);
            this.btNovo.TabIndex = 1;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(280, 19);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(120, 53);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox_PesquisarCarros
            // 
            this.groupBox_PesquisarCarros.Controls.Add(this.btPesquisarPorCodigo);
            this.groupBox_PesquisarCarros.Controls.Add(this.txtPesquisarPorNome);
            this.groupBox_PesquisarCarros.Controls.Add(this.label11);
            this.groupBox_PesquisarCarros.Controls.Add(this.txtPesquisarPorCodigoCarro);
            this.groupBox_PesquisarCarros.Controls.Add(this.label10);
            this.groupBox_PesquisarCarros.Controls.Add(this.dataGridView_DadosCarros);
            this.groupBox_PesquisarCarros.Location = new System.Drawing.Point(11, 388);
            this.groupBox_PesquisarCarros.Name = "groupBox_PesquisarCarros";
            this.groupBox_PesquisarCarros.Size = new System.Drawing.Size(1013, 198);
            this.groupBox_PesquisarCarros.TabIndex = 2;
            this.groupBox_PesquisarCarros.TabStop = false;
            this.groupBox_PesquisarCarros.Text = "Dados da Pesquisa";
            // 
            // btPesquisarPorCodigo
            // 
            this.btPesquisarPorCodigo.Location = new System.Drawing.Point(916, 16);
            this.btPesquisarPorCodigo.Name = "btPesquisarPorCodigo";
            this.btPesquisarPorCodigo.Size = new System.Drawing.Size(70, 31);
            this.btPesquisarPorCodigo.TabIndex = 5;
            this.btPesquisarPorCodigo.Text = "Pesquisar";
            this.btPesquisarPorCodigo.UseVisualStyleBackColor = true;
            this.btPesquisarPorCodigo.Click += new System.EventHandler(this.btPesquisarPorCodigo_Click);
            this.btPesquisarPorCodigo.Leave += new System.EventHandler(this.frmTela_De_Cadastro_De_Carros_Load);
            // 
            // txtPesquisarPorNome
            // 
            this.txtPesquisarPorNome.Location = new System.Drawing.Point(227, 22);
            this.txtPesquisarPorNome.Name = "txtPesquisarPorNome";
            this.txtPesquisarPorNome.Size = new System.Drawing.Size(324, 20);
            this.txtPesquisarPorNome.TabIndex = 4;
            this.txtPesquisarPorNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Pesquisar Por Nome Da Marca De Carro";
            // 
            // txtPesquisarPorCodigoCarro
            // 
            this.txtPesquisarPorCodigoCarro.Location = new System.Drawing.Point(817, 22);
            this.txtPesquisarPorCodigoCarro.Name = "txtPesquisarPorCodigoCarro";
            this.txtPesquisarPorCodigoCarro.Size = new System.Drawing.Size(83, 20);
            this.txtPesquisarPorCodigoCarro.TabIndex = 2;
            this.txtPesquisarPorCodigoCarro.MouseLeave += new System.EventHandler(this.txtPesquisarPorCodigoCarro_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Pesquisar Por Código";
            // 
            // dataGridView_DadosCarros
            // 
            this.dataGridView_DadosCarros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DadosCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DadosCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCarro,
            this.Transmissao,
            this.Modelo,
            this.Marca,
            this.Velocidade,
            this.Origem,
            this.Cor,
            this.Combustivel,
            this.Categoria,
            this.Imagem_carro});
            this.dataGridView_DadosCarros.Location = new System.Drawing.Point(0, 48);
            this.dataGridView_DadosCarros.Name = "dataGridView_DadosCarros";
            this.dataGridView_DadosCarros.ReadOnly = true;
            this.dataGridView_DadosCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DadosCarros.Size = new System.Drawing.Size(1013, 132);
            this.dataGridView_DadosCarros.TabIndex = 0;
            this.dataGridView_DadosCarros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DadosCarros_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Aviso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(728, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 183);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btAdicionarFoto
            // 
            this.btAdicionarFoto.Location = new System.Drawing.Point(728, 227);
            this.btAdicionarFoto.Name = "btAdicionarFoto";
            this.btAdicionarFoto.Size = new System.Drawing.Size(123, 31);
            this.btAdicionarFoto.TabIndex = 20;
            this.btAdicionarFoto.Text = "Adicionar Foto";
            this.btAdicionarFoto.UseVisualStyleBackColor = true;
            this.btAdicionarFoto.Click += new System.EventHandler(this.btAdicionarFoto_Click);
            // 
            // CodCarro
            // 
            this.CodCarro.DataPropertyName = "cod_carro";
            this.CodCarro.HeaderText = "Código";
            this.CodCarro.Name = "CodCarro";
            this.CodCarro.ReadOnly = true;
            // 
            // Transmissao
            // 
            this.Transmissao.DataPropertyName = "nome";
            this.Transmissao.HeaderText = "Transmissão";
            this.Transmissao.Name = "Transmissao";
            this.Transmissao.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "modelo_carro";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "marca_carro";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Velocidade
            // 
            this.Velocidade.DataPropertyName = "kilometragem";
            this.Velocidade.HeaderText = "Velocidade";
            this.Velocidade.Name = "Velocidade";
            this.Velocidade.ReadOnly = true;
            // 
            // Origem
            // 
            this.Origem.DataPropertyName = "origem";
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            this.Origem.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "cor_carro";
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // Combustivel
            // 
            this.Combustivel.DataPropertyName = "combustivel";
            this.Combustivel.HeaderText = "Combustível";
            this.Combustivel.Name = "Combustivel";
            this.Combustivel.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "nome_cat";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Imagem_carro
            // 
            this.Imagem_carro.DataPropertyName = "imagem_carro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.Imagem_carro.DefaultCellStyle = dataGridViewCellStyle2;
            this.Imagem_carro.HeaderText = "Imagem";
            this.Imagem_carro.Image = global::Interfaces.Properties.Resources._0005012;
            this.Imagem_carro.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagem_carro.Name = "Imagem_carro";
            this.Imagem_carro.ReadOnly = true;
            this.Imagem_carro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagem_carro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagem_carro.Width = 200;
            // 
            // frmTela_De_Cadastro_De_Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 581);
            this.Controls.Add(this.groupBox_PesquisarCarros);
            this.Controls.Add(this.groupBox_Botoes);
            this.Controls.Add(this.grupoBox_TelaCad_Carro);
            this.MaximizeBox = false;
            this.Name = "frmTela_De_Cadastro_De_Carros";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Cadastro De Carros";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.frmTela_De_Cadastro_De_Carros_Load);
            this.grupoBox_TelaCad_Carro.ResumeLayout(false);
            this.grupoBox_TelaCad_Carro.PerformLayout();
            this.groupBox_Botoes.ResumeLayout(false);
            this.groupBox_PesquisarCarros.ResumeLayout(false);
            this.groupBox_PesquisarCarros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DadosCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKilometragemCarro;
        private System.Windows.Forms.TextBox txtMarcaCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModeloCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo_Carro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboxBoxSeleccionar_Combustivel_Do_Motor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_SeleccionarCategoriaCarro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrigemCarro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Seleccionar_Transmissao_Do_Carro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtCor_Carro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btApagar;
        public System.Windows.Forms.GroupBox grupoBox_TelaCad_Carro;
        public System.Windows.Forms.GroupBox groupBox_Botoes;
        public System.Windows.Forms.GroupBox groupBox_PesquisarCarros;
        private System.Windows.Forms.Button btPesquisarPorCodigo;
        private System.Windows.Forms.TextBox txtPesquisarPorNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPesquisarPorCodigoCarro;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dataGridView_DadosCarros;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btAdicionarFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCarro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewImageColumn Imagem_carro;
    }
}

