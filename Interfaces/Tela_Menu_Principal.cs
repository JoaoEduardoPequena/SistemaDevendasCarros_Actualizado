using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Interfaces
{
    public partial class Tela_Menu_Principal : Form
    {
        public Tela_Menu_Principal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTelaDeCadastroDeUsuarios caUsuario = new frmTelaDeCadastroDeUsuarios();
            caUsuario.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaDeCadastroDeUsuarios caUsuario = new frmTelaDeCadastroDeUsuarios();
            caUsuario.Show();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTela_De_Cadastro_De_Carros cad_Carros = new frmTela_De_Cadastro_De_Carros();
            cad_Carros.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmTela_De_Cadastro_De_Carros cad_Carros = new frmTela_De_Cadastro_De_Carros();
            cad_Carros.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CadEstoque cadEstoque = new CadEstoque();
            cadEstoque.Show();
        }
        // Carrega A Hora e Data Actual Do Sistema
        private void toolStripStatusLabel_Data_Click(object sender, EventArgs e)
        {
            // Carrega A Hora e Data Actual Do Sistema
            toolStripStatusLabel_Data.Text = DateTime.Now.ToString();
        }

        private void Tela_Menu_Principal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel_Data_Click(sender, e);// Faz A leitura da Hora e Data Ao iniciar Apliccao
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEstoque cadEstoque = new CadEstoque();
            cadEstoque.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //Cad_EfectuarVendas cadEfectuarVendas = new Cad_EfectuarVendas();
            //cadEfectuarVendas.ShowDialog();

            TelaDeVendaActualizada telaVenda = new TelaDeVendaActualizada();
            telaVenda.ShowDialog();
        }

        private void efectuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cad_EfectuarVendas cadEfectuarVendas = new Cad_EfectuarVendas();
            //cadEfectuarVendas.ShowDialog();

            TelaDeVendaActualizada telaVenda = new TelaDeVendaActualizada();
            telaVenda.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            DialogResult resultResposta = MessageBox.Show("Tens Certeza Que Desejas Sair Deste Programa?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultResposta == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Operacao Cancelada Pelo Usuario", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }
        
    }
}
