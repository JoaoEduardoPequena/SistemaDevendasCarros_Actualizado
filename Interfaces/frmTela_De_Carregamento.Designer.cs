namespace Interfaces
{
    partial class frmTela_De_Carregamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTela_De_Carregamento));
            this.panel_Tela_de_Carregamento = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Tela_de_Carregamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Tela_de_Carregamento
            // 
            this.panel_Tela_de_Carregamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Tela_de_Carregamento.BackgroundImage")));
            this.panel_Tela_de_Carregamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Tela_de_Carregamento.Controls.Add(this.progressBar1);
            this.panel_Tela_de_Carregamento.Controls.Add(this.label2);
            this.panel_Tela_de_Carregamento.Controls.Add(this.label1);
            this.panel_Tela_de_Carregamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Tela_de_Carregamento.Location = new System.Drawing.Point(0, 0);
            this.panel_Tela_de_Carregamento.Name = "panel_Tela_de_Carregamento";
            this.panel_Tela_de_Carregamento.Size = new System.Drawing.Size(744, 360);
            this.panel_Tela_de_Carregamento.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(215, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema De Gestão Para Venda De Carros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(3, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciando Modulos . . .";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 350);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(741, 10);
            this.progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTela_De_Carregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 360);
            this.Controls.Add(this.panel_Tela_de_Carregamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTela_De_Carregamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregamento do Sistema";
            this.panel_Tela_de_Carregamento.ResumeLayout(false);
            this.panel_Tela_de_Carregamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Tela_de_Carregamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}