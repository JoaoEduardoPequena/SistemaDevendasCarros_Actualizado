using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;
using MySql.Data.MySqlClient;

namespace Interfaces
{
    public partial class TelaDeVendaActualizada : Form
    {
        VendasBLL vendaBLL = new VendasBLL();

        VendaDTO vendaDTO = new VendaDTO();

        Item_VendaBLL itemVendaBLL = new Item_VendaBLL();

        Item_VendaDTO itemVendaDTO = new Item_VendaDTO();

        decimal totalCompra;

        public TelaDeVendaActualizada()
        {
            InitializeComponent();
        }

        private void TelaDeVendaActualizada_Load(object sender, EventArgs e)
        {
           NomearDataGrid();
           lblCodigoVenda.Text= vendaBLL.GerarCodigoVenda().ToString();
        }

        private void NomearDataGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Cod.Carro";

            dataGridView1.Columns[1].Name = "Marca Carro";
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.Columns[2].Name = "Modelo Carro";
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.Columns[3].Name = "Preçco Carro";
            dataGridView1.Columns[4].Name = "Quantidade";
            dataGridView1.Columns[5].Name = "Total";
        }

        private void ConsultarProduto()
        {
            vendaDTO.cod_carro = int.Parse(txtCodCarro.Text);
            MySqlDataReader dr = vendaBLL.ConsultarCarrosParaVenda(vendaDTO.cod_carro);
            
                dr.Read();

                txtMarcaCarro.Text = dr["marca_carro"].ToString();
                txtModeloCarro.Text = dr["modelo_carro"].ToString();
                txtPrecoProduto.Text = dr["preco_venda"].ToString();
        }


        private void GravarVenda()
        {
            try
            {
                  vendaDTO.cod_carro = int.Parse(txtCodCarro.Text);
                  //vendaDTO.data_venda = dateTimePickerDataVenda.Text;
                  vendaDTO.preco_venda = decimal.Parse(txtPrecoProduto.Text);
                  vendaDTO.total_venda = decimal.Parse(txtValorTotalCompra.Text);
                  vendaBLL.InserirNovoVendaBLL(vendaDTO);
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro Ao tentar Efectur Uma Nova Venda. Detalhes:" , erro.Message);
            }

            finally
            {
                InseriItemVenda();
                dataGridView1.Rows.Clear();
                txtValorTotalCompra.Text = String.Empty;
                totalCompra = 0;
            }
        
        }

        private void InseriItemVenda()
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    /*itemVendaDTO.cod_carro = int.Parse(txtCodCarro.Text);
                    itemVendaDTO.id_venda = int.Parse(lblCodigoVenda.Text);
                    itemVendaDTO.quantidade = int.Parse(txtQuantProduto.Text);
                    itemVendaDTO.valorTotal = decimal.Parse(txtValorTotalProduto.Text);*/

                    itemVendaDTO.cod_carro = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    itemVendaDTO.id_venda = int.Parse(lblCodigoVenda.Text.ToString());
                    itemVendaDTO.quantidade = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    itemVendaDTO.valorTotal = decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    itemVendaBLL.InserirItemVendaBLL(itemVendaDTO);
                }
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro Ao tentar Inserir Item da Venda. Detalhes:", erro.Message);
            }
            
        
        }

        private void txtCodCarro_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodCarro.Text != String.Empty)
            {
                ConsultarProduto();
            }

            else
            {
                txtCodCarro.Focus();
            }
        }

        private void txtQuantProduto_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantProduto.Text!= string .Empty)
            {
                txtValorTotalProduto.Text = (decimal.Parse(txtPrecoProduto.Text) * Convert.ToInt32(txtQuantProduto.Text)).ToString();
            }
        }

        private void btAdicionarProdutos_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtCodCarro.Text, txtMarcaCarro.Text, txtModeloCarro.Text, txtPrecoProduto.Text, txtQuantProduto.Text, txtValorTotalProduto.Text);
            totalCompra += decimal.Parse(txtValorTotalProduto.Text);
            txtValorTotalCompra.Text = totalCompra.ToString();
        }

        private void btFinalizarCompra_Click(object sender, EventArgs e)
        {
            GravarVenda();

            lblCodigoVenda.Text = vendaBLL.GerarCodigoVenda().ToString();
        }

        
    }
}
