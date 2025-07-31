using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicdesenvol
{
    public partial class FrmSenha : Form
    {
        public FrmSenha()
        {
            InitializeComponent();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FrmSenha_Load(object sender, EventArgs e)
        {
            txtSenha.Text = InfoSenha.Senha.Trim(); 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            InfoSenha.Senha = txtSenha.Text.Trim();
            if (InfoSenha.Senha.Length > 0)
            {
                // Fecha o formulário
                this.Close();
            }
            else
            {
                // Exibe mensagem de erro
                MessageBox.Show("A senha não pode ser vazia !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}
