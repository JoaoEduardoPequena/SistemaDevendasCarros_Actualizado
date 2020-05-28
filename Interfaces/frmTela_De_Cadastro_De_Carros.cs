using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using DTO;
using DAL;
using BLL;

namespace Interfaces
{
    public partial class frmTela_De_Cadastro_De_Carros : Form
    {
        public string foto = "";
        byte img;
        CarrosDTO carroDTO = new CarrosDTO();
        CarrosBLL carroBLL = new CarrosBLL();
        CombustivelBLL combustivelCarroBLL = new CombustivelBLL();
        CategoriaCarroBLL catCarroBLL = new CategoriaCarroBLL();
        TransmissaoMotorBLL transmissaoCarroBLL = new TransmissaoMotorBLL();

        public frmTela_De_Cadastro_De_Carros()
        {
            InitializeComponent();
        }

        private void frmTela_De_Cadastro_De_Carros_Load(object sender, EventArgs e)
        {
            dataGridView_DadosCarros.AutoGenerateColumns = false;

            CarregarComBoxes();
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            dataGridView_DadosCarros.DataSource = carroBLL.SelecionarCarroBLL();
            dataGridView_DadosCarros.Update();
        }

        private void CarregarComBoxes()
        {
            ComboxBoxSeleccionar_Combustivel_Do_Motor.DataSource=combustivelCarroBLL.SelecionarCombustivelMotorBLL();
            ComboxBoxSeleccionar_Combustivel_Do_Motor.DisplayMember = "combustivel";
            ComboxBoxSeleccionar_Combustivel_Do_Motor.ValueMember = "cod_combustivel";

            comboBox_Seleccionar_Transmissao_Do_Carro.DataSource = transmissaoCarroBLL.SelecionarTransmissao();
            comboBox_Seleccionar_Transmissao_Do_Carro.DisplayMember = "nome";
            comboBox_Seleccionar_Transmissao_Do_Carro.ValueMember="cod_transmissao";

            comboBox_SeleccionarCategoriaCarro.DataSource = catCarroBLL.SelecionarCategoriaDeCarroBLL();
            comboBox_SeleccionarCategoriaCarro.DisplayMember ="nome_cat" ;
            comboBox_SeleccionarCategoriaCarro.ValueMember="cod_cat_carro";

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
           carroDTO.modelo_carro= txtModeloCarro.Text;
           carroDTO.marca_carro = txtMarcaCarro.Text;
           carroDTO.cod_transmissao = Convert.ToInt16(comboBox_Seleccionar_Transmissao_Do_Carro.SelectedValue);
           carroDTO.cod_cat_carro = Convert.ToInt16(comboBox_SeleccionarCategoriaCarro.SelectedValue);
           carroDTO.cod_combustivel = Convert.ToInt16(ComboxBoxSeleccionar_Combustivel_Do_Motor.SelectedValue);
           carroDTO.kilometragem = txtKilometragemCarro.Text;
           carroDTO.cor_carro = txtCor_Carro.Text;
           carroDTO.origem = txtOrigemCarro.Text;
           //carroDTO.imagem_carro = 
           
           carroBLL.InserirNovoCarroBLL(carroDTO);
           CarregarDataGrid();
           Limpar_Tela();
           MessageBox.Show("Novo Carro Inserido Com Sucesso","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

       /* private void btBuscarImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName!="")
            {
                this.foto = openFileDialog1.FileName;
                this.pictureBox_Cad_Imagem_Carro.Load(foto);
            }


        }*/

        private bool ValidarCampos( )
        {
            errorProvider1.Clear();
            if (txtMarcaCarro.Text.Length==0)
            {
                errorProvider1.SetError(txtMarcaCarro,"Este campo E Obrigatorio");
                return false ;
            }

           if (txtModeloCarro.Text.Length == 0)
            {
                errorProvider1.SetError(txtModeloCarro, "Este campo E Obrigatorio");
                return false;
            }

             if (txtOrigemCarro.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrigemCarro, "Este campo E Obrigatorio");
                return false;
            }

             if (txtKilometragemCarro.Text.Length == 0)
            {
                errorProvider1.SetError(txtKilometragemCarro, "Este campo E Obrigatorio");
                return false;
            }
               
             if (txtKilometragemCarro.Text.Length == 0)
            {
                errorProvider1.SetError(txtKilometragemCarro, "Este campo E Obrigatorio");
                return false;
            }
            return true;
        }

        private void Limpar_Tela()
        {
          txtCodigo_Carro.Clear();
          txtModeloCarro.Clear();
          txtMarcaCarro.Clear();
          //comboBox_Seleccionar_Transmissao_Do_Carro.Text = "";
          //comboBox_SeleccionarCategoriaCarro.Text="";
          //ComboxBoxSeleccionar_Combustivel_Do_Motor.Text="";
          txtKilometragemCarro.Clear();
          txtCor_Carro.Clear();
          txtOrigemCarro.Clear();

          txtPesquisarPorCodigoCarro.Clear();
          txtPesquisarPorNome.Clear();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Limpar_Tela();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string valor = txtPesquisarPorNome.Text;
            dataGridView_DadosCarros.DataSource = carroBLL.PesquisarCarrosPorNomeDaMarcaDOCarroBLL(valor);
        }

        private void btPesquisarPorCodigo_Click(object sender, EventArgs e)
        {
             int codigo = int.Parse(txtPesquisarPorCodigoCarro.Text);
             //dataGridView_DadosCarros.DataSource = carroBLL.PesquisarCarrosPorCodigoDaCategoriaDoCarroBLL(codigo);
             dataGridView_DadosCarros.DataSource = carroBLL.PesquisarCarrosPorCodigoBLL(codigo);
        }

        private void dataGridView_DadosCarros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo_Carro.Text = dataGridView_DadosCarros.CurrentRow.Cells[0].Value.ToString();
            comboBox_Seleccionar_Transmissao_Do_Carro.Text=dataGridView_DadosCarros.CurrentRow.Cells[1].Value.ToString();
            txtModeloCarro.Text = dataGridView_DadosCarros.CurrentRow.Cells[2].Value.ToString();
            txtMarcaCarro.Text = dataGridView_DadosCarros.CurrentRow.Cells[3].Value.ToString();
            txtKilometragemCarro.Text = dataGridView_DadosCarros.CurrentRow.Cells[4].Value.ToString();
            txtOrigemCarro.Text = dataGridView_DadosCarros.CurrentRow.Cells[5].Value.ToString();
            txtCor_Carro.Text = dataGridView_DadosCarros.CurrentRow.Cells[6].Value.ToString();
            ComboxBoxSeleccionar_Combustivel_Do_Motor.Text = dataGridView_DadosCarros.CurrentRow.Cells[7].Value.ToString();
            comboBox_SeleccionarCategoriaCarro.Text = dataGridView_DadosCarros.CurrentRow.Cells[8].Value.ToString();
            //dataGridView_DadosCarros.CurrentRow.Cells[9].Value = carroDTO.imagem_carro.ToString();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo_Carro.Text.Length==0)
            {
                MessageBox.Show("Um Dado de Carro deve ser seleccionado antes da alteracao","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            else  
            {
                DialogResult resultResposta = MessageBox.Show("Tens Certeza Que Desejas Actualizar Este Dado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultResposta == DialogResult.Yes)
	              {
		               
                      carroDTO.cod_carro = int.Parse(txtCodigo_Carro.Text);
                      carroDTO.cod_transmissao= Convert.ToInt32(comboBox_Seleccionar_Transmissao_Do_Carro.SelectedValue);
                      carroDTO.modelo_carro=txtModeloCarro.Text;
                      carroDTO.marca_carro= txtMarcaCarro.Text;
                      carroDTO.kilometragem=txtKilometragemCarro.Text;
                      carroDTO.origem=txtOrigemCarro.Text;
                      carroDTO.cor_carro=txtCor_Carro.Text;
                      carroDTO.cod_combustivel = Convert.ToInt32(ComboxBoxSeleccionar_Combustivel_Do_Motor.SelectedValue);
                      carroDTO.cod_cat_carro = Convert.ToInt32(comboBox_SeleccionarCategoriaCarro.SelectedValue);
                      carroBLL.AlterarCarroBLL(carroDTO);
                      CarregarDataGrid();
                      MessageBox.Show("Dados do Carro Actualizados Com sucesso", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
	              }


                else
                  {
                    MessageBox.Show("Operacao cancelada Pelo Usuario", "informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar_Tela();
                  }
            }

            
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            DialogResult resultResposta= MessageBox.Show("Tens Certeza Que Desejas Eliminar Este Dado?","Pergunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if( resultResposta== DialogResult.Yes)
            {
              carroDTO.cod_carro = int.Parse(txtCodigo_Carro.Text);
              carroBLL.ExcluirCarroBLL(carroDTO);
              CarregarDataGrid();
              Limpar_Tela();
              MessageBox.Show("Dados do Carro Eliminado Com sucesso", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Operacao cancelada Pelo Usuario", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar_Tela();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultResposta = MessageBox.Show("Tens Certeza Que Desejas Sair Desta Operacao?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultResposta == DialogResult.Yes)
            {
                this.Close();
            }

            else
            {
                MessageBox.Show("Operacao cancelada Pelo Usuario", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPesquisarPorCodigoCarro_MouseLeave(object sender, EventArgs e)
        {
            if (txtPesquisarPorCodigoCarro.Text.Length==0)
            {
                CarregarDataGrid();
            }
        }

        private void btAdicionarFoto_Click(object sender, EventArgs e)
        {
            AdicionarImagem();
        }

        private byte AdicionarImagem()
        {
          openFileDialog1.ShowDialog();
          pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
          pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
          return img;
        }
       
    }
}
