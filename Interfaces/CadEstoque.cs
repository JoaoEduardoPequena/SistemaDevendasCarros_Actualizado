using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BLL;

namespace Interfaces
{
    public partial class CadEstoque : Form
    {
        CategoriaCarroBLL categoriaCarroBLL = new CategoriaCarroBLL();

        CategoriaCarroDTO categoriaCarroDTO = new CategoriaCarroDTO();

        CarrosBLL carroBLL = new CarrosBLL();

        EstoqueDTO estoqueDTO = new EstoqueDTO();
        EstoqueBLL estoqueBLL = new EstoqueBLL();

        public CadEstoque()
        {
            InitializeComponent();
        }

        private void CadEstoque_Load(object sender, EventArgs e)
        {
            CarregarListaDeMarcasDeCarros();
            CarregarDataGrid();
            //CarregarComBox();
        }

        /*private void CarregarListBox()
        {
            int cod_catCarro = Convert.ToInt16(comboBox_CategoriaCarro_CadEstoque.SelectedValue);
            ListaDeMarcasDeCarros.DataSource = carroBLL.PesquisarCarrosPorCodigoDaCategoriaDoCarroBLL(cod_catCarro);
            ListaDeMarcasDeCarros.ValueMember = "cod_carro";
            ListaDeMarcasDeCarros.DisplayMember = "marca_carro";
        }*/
        //private void CarregarComBox()
        //{
        //    comboBox_CategoriaCarro_CadEstoque.DataSource = categoriaCarroBLL.SelecionarCategoriaDeCarroBLL();
        //    comboBox_CategoriaCarro_CadEstoque.DisplayMember = "nome_cat";
        //    comboBox_CategoriaCarro_CadEstoque.ValueMember = "cod_cat_carro";

        //    ////selecionar Todas As marcas do Carro na ListBox ao Inicializar O Formulario Cad de Carros
        //    //ListaDeMarcasDeCarros.DataSource = carroBLL.SelecionarCarroBLL();
        //    //ListaDeMarcasDeCarros.ValueMember = "cod_carro";
        //    //ListaDeMarcasDeCarros.DisplayMember = "marca_carro";
        // }

        private void CarregarDataGrid()
        {
            dataGridView_ConsultaEstoque.DataSource = estoqueBLL.SelecionaProdutos_Em_EstoqueBLL();
        }

        /*private void CarregarComBox()
        {
            comboBox1.DataSource = carroBLL.SeleccionarTodosDadosNaListBox_BLL();
            comboBox1.ValueMember = "cod_carro";
            comboBox1.DisplayMember = "modelo_carro";
        }
        */

        private void CarregarListaDeMarcasDeCarros()
        {
            listBox_Marcas_De_Carros.DataSource = carroBLL.SeleccionarTodosDadosNaListBox_BLL();
            listBox_Marcas_De_Carros.ValueMember = "cod_carro";
            listBox_Marcas_De_Carros.DisplayMember = "modelo_carro";
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                estoqueDTO.cod_carro = Convert.ToInt32(listBox_Marcas_De_Carros.SelectedValue);
                //estoqueDTO.cod_carro = Convert.ToInt32(comboBox1.SelectedValue);
                estoqueDTO.qtd_estoque = Convert.ToInt32(txtQuantidadeEstoque.Text);
                estoqueBLL.InserirNovoProduto_Em_Estoque_BLL(estoqueDTO);
                MessageBox.Show("Produto Cadastrado No Estoque Com Sucesso");
                LimparCampos();
                CarregarDataGrid();
            }
            catch (Exception ex)
            {

                //MessageBox.Show(" Erro Ao Inserir Novo Carro No Estoque. Detalhes:" + ex.Message);
            }
            
       }

        private void ValidarCampos()
        {
               estoqueDTO.cod_carro = Convert.ToInt32(listBox_Marcas_De_Carros.SelectedValue);
                if (estoqueDTO.cod_carro ==0)
                {
                    MessageBox.Show("Nenhum  Modelo de Carro Foi Seleccionado.Seleccionar Um Modelo de Carro");
                }

                if (txtQuantidadeEstoque.TextLength == 0)
                {
                    MessageBox.Show("O Campo Quantidade Esta Vazio Preencher Este Campo");
                }
           }

        private void radioButton_Ligeiro_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Ligeiro.Checked== true)
            { 
                int codigo=1;
                listBox_Marcas_De_Carros.DataSource = estoqueBLL.PesquisarPorNomeDaCategoriaDoCarro_EstoqueBLL(codigo);
                listBox_Marcas_De_Carros.ValueMember = "cod_carro";
                listBox_Marcas_De_Carros.DisplayMember = "modelo_carro";
            }
        }

        private void radioButton_Pesado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Pesado.Checked == true)
            {
                int codigo = 2;
                listBox_Marcas_De_Carros.DataSource = estoqueBLL.PesquisarPorNomeDaCategoriaDoCarro_EstoqueBLL(codigo);
                listBox_Marcas_De_Carros.ValueMember = "cod_carro";
                listBox_Marcas_De_Carros.DisplayMember = "modelo_carro";
            }

        }

        private void txtPesquisarPorMarcaDoCarro_TextChanged(object sender, EventArgs e)
        {
            string marcaCarro = txtPesquisarPorMarcaDoCarro.Text;
           dataGridView_ConsultaEstoque.DataSource= estoqueBLL.SelecionaProdutos_Em_EstoquePorNomeDaMarcaDoCarroBLL(marcaCarro);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigoEstoque.Clear();
            txtQuantidadeEstoque.Clear();
            radioButton_Ligeiro.Checked = false;
            radioButton_Pesado.Checked = false;
            CarregarListaDeMarcasDeCarros();
        }

        private void dataGridView_ConsultaEstoque_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCodigoEstoque.Text = dataGridView_ConsultaEstoque.CurrentRow.Cells[0].Value.ToString();
            listBox_Marcas_De_Carros.Text = dataGridView_ConsultaEstoque.CurrentRow.Cells[2].Value.ToString();
            txtQuantidadeEstoque.Text = dataGridView_ConsultaEstoque.CurrentRow.Cells[3].Value.ToString();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEstoque.Text.Length==0)
            {
                MessageBox.Show("Um Dado de Carro deve ser seleccionado antes da alteracao","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            else  
            {
                DialogResult resultResposta = MessageBox.Show("Tens Certeza Que Desejas Actualizar Este Dado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultResposta == DialogResult.Yes)
	              {
		               
                      estoqueDTO.cod_estoque = int.Parse(txtCodigoEstoque.Text);
                      estoqueDTO.cod_carro= Convert.ToInt32(listBox_Marcas_De_Carros.SelectedValue);
                      estoqueDTO.qtd_estoque= Convert.ToInt32(txtQuantidadeEstoque.Text);
                      estoqueBLL.AlterarEstoqueBLL(estoqueDTO);
                      CarregarDataGrid();
                      LimparCampos();
                      MessageBox.Show("Dados do Carro Actualizados Com sucesso", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
	              }


                else
                  {
                    MessageBox.Show("Operacao Cancelada Pelo Usuario", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                  }
              }

           }

        /*private void comboBox_CategoriaCarro_CadEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //comboBox_CategoriaCarro_CadEstoque.SelectedIndex =- 1;
                //comboBox_CategoriaCarro_CadEstoque.SelectionStart = 1;
                
                if (comboBox_CategoriaCarro_CadEstoque.SelectedIndex>=0)
                {
                    int cod_catCarro = Convert.ToInt32(comboBox_CategoriaCarro_CadEstoque.SelectedValue);
                    lblCod_Categoria_Carro.Text = cod_catCarro.ToString();
                    ListaDeMarcasDeCarros.DataSource = carroBLL.PesquisarCarrosPorCodigoDaCategoriaDoCarroBLL(cod_catCarro);
                    ListaDeMarcasDeCarros.ValueMember = "cod_carro";
                    ListaDeMarcasDeCarros.DisplayMember = "marca_carro";
                    
                }

               
            }
            catch (Exception erro)
            {
                 MessageBox.Show("Erro ao Seleccionar A Categoria De Carro. Detalhes:"   +erro.Message);
            }
            
       }*/


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

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEstoque.Text.Length==0)
            {
                MessageBox.Show("Um Dado de Carro deve ser seleccionado antes da Exclusao","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            else  
            {
                DialogResult resultResposta = MessageBox.Show("Tens Certeza Que Desejas Eliminar Este Dado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultResposta == DialogResult.Yes)
	              {
                      estoqueDTO.cod_estoque = int.Parse(txtCodigoEstoque.Text);
                      estoqueBLL.ExcluirEstoqueBLL(estoqueDTO);
                      CarregarDataGrid();
                      LimparCampos();
                      MessageBox.Show("Dados do Carro Eliminado Com sucesso No Estoque", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
	              }


                else
                  {
                    MessageBox.Show("Operacao Cancelada Pelo Usuario", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                  }
              }
          }
  }

}
