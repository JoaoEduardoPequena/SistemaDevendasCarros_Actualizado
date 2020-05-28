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

namespace Interfaces
{
    public partial class frmTelaDeCadastroDeUsuarios : Form
    {
        UsuarioBLL usuariosBLL = new UsuarioBLL();

        UsuariosDTO usuariosDTO = new UsuariosDTO();

        public frmTelaDeCadastroDeUsuarios()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            usuariosDTO.nome_usuario = txtNomeUsuario.Text;
            usuariosDTO.senha_usuario = txtSenhaUsuario.Text;
            usuariosDTO.funcao_usuario = txtFuncao_Usuario.Text;
            usuariosBLL.InserirNovos_UsuariosBLL(usuariosDTO);
            CarregardataGrid(); 
            MessageBox.Show("Dados de Usuarios Inseridos Com Sucesso");
        }

        private void CarregardataGrid()
        {
            dataGridView_Usuarios.DataSource = usuariosBLL.SelecionarUsuario();
        }

        private void frmTelaDeCadastroDeUsuarios_Load(object sender, EventArgs e)
        {
            CarregardataGrid(); 
        }

       
        private void btPesquisarPorCodigo_Click_1(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtPesquisarPorCodigo.Text);
            dataGridView_Usuarios.DataSource = usuariosBLL.PesquisarUsuarioPorCodigo(codigo);
        }
        private void txtPesquisarPorNome_TextChanged(object sender, EventArgs e)
        {
            string nome_pesquisar = txtPesquisarPorNome.Text;
            dataGridView_Usuarios.DataSource= usuariosBLL.PesquisarUsuarioPorNome(nome_pesquisar);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void LimparTela()
        {
          txtCodUsuario.Clear();
          txtNomeUsuario.Clear();
          txtSenhaUsuario.Clear();
          txtFuncao_Usuario.Clear();       
        }

        private void dataGridView_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodUsuario.Text = dataGridView_Usuarios.CurrentRow.Cells[0].Value.ToString();
            txtNomeUsuario.Text = dataGridView_Usuarios.CurrentRow.Cells[1].Value.ToString();
            txtSenhaUsuario.Text = dataGridView_Usuarios.CurrentRow.Cells[2].Value.ToString();
            txtFuncao_Usuario.Text = dataGridView_Usuarios.CurrentRow.Cells[3].Value.ToString();
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            usuariosDTO.cod_usuario = int.Parse(txtCodUsuario.Text);
            usuariosBLL.ExcluirUsuarioBLL(usuariosDTO);
            CarregardataGrid();
            LimparTela();
            MessageBox.Show("Dados Apagado Com Sucesso","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodUsuario.TextLength==0)
            {
                MessageBox.Show("Um Dado de Usuario deve ser seleccionado antes da alteracao", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                DialogResult resultResposta = MessageBox.Show("Tens Certeza Que Desejas Actualizar Este Dado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultResposta == DialogResult.Yes)
                {

                    usuariosDTO.cod_usuario = int.Parse(txtCodUsuario.Text);
                    usuariosDTO.nome_usuario = txtNomeUsuario.Text;
                    usuariosDTO.senha_usuario = txtSenhaUsuario.Text;
                    usuariosDTO.funcao_usuario = txtFuncao_Usuario.Text;
                    usuariosBLL.AlterarUsuarioBLL(usuariosDTO);
                    CarregardataGrid();
                    MessageBox.Show("Dados do usuario Actualizados Com sucesso", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    MessageBox.Show("Operacao cancelada Pelo Usuario", "informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTela();
                }
            }
        }

        private void txtPesquisarPorCodigo_MouseLeave(object sender, EventArgs e)
        {
            if (txtPesquisarPorCodigo.Text.Length==0)
            {
                CarregardataGrid();
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

    }
}
