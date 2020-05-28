using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class frmTela_De_Carregamento : Form
    {
        public frmTela_De_Carregamento()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }

            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frmTela_de_Login frmTela_Login= new frmTela_de_Login();
                frmTela_Login.Show();
            }
        }
    }
}
