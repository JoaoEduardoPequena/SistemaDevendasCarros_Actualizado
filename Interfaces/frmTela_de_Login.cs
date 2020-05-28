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
    public partial class frmTela_de_Login : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        UsuariosDTO usuariosDTO = new UsuariosDTO();

        Tela_Menu_Principal tela_Menu_Principal = new Tela_Menu_Principal();

        public frmTela_de_Login()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretendes Sair da Aplicação", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string nome_usuario= txtNomeLogin.Text;
            string senha_usuario = txtSenhaLogin.Text;

            int usuario_retornado = usuarioBLL.Login_UsuarioBLL(nome_usuario,senha_usuario);
            
            if (usuario_retornado != 0)
            {
                this.Visible = false;
                tela_Menu_Principal.Show();
            }
            else
            {
                MessageBox.Show("Nome ou Senha Inválido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeLogin.Text = "";
                txtSenhaLogin.Text = "";
            }
        }
    }
}
