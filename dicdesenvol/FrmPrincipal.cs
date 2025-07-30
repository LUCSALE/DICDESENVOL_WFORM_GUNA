using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicdesenvol
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            
            frm.TopLevel = false;
            pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AtualizaVersao()
        {
            //define a string de conexao com provedor caminho e nome do banco de dados
            string strProvider = "Data Source=SQL1001.site4now.net;Initial Catalog=db_ab2460_cadastrodb;Persist Security Info=True;User ID=db_ab2460_cadastrodb_admin;PassWord=Mag160163@";

            //define a instrução SQL
            string strSql = "SELECT VERSAO FROM CTRL_VERSAO WHERE SISTEMA = 'DICDESENVOL_WFORM_GUNA' ";

            try
            {
                // Estabelecer a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(strProvider))
                {
                    connection.Open();

                    // Criar o comando SQL
                    using (SqlCommand command = new SqlCommand(strSql, connection))
                    {
                        // Criar o objeto de leitura
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Verificar se existem resultados
                            if (reader.HasRows)
                            {
                                // Percorrer os resultados
                                while (reader.Read())
                                {
                                    // Acessar o campo "nome_campo" e exibir na tela
                                    string nomeCampo = reader["VERSAO"].ToString(); // Ou reader.GetString(0)
                                    lblVersao.Text = "Versão: " + nomeCampo;


                                }
                            }
                            else
                            {
                                MessageBox.Show("Nenhum resultado encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Lê definição do APP para definição dos parâmetros
            StreamReader csv = new StreamReader(@"C:\dicdesenvol.cfg");
            string linha = "";
            string[] campos;

            linha = csv.ReadLine();
            campos = linha.Split(';');

            // Atualiza DADOS da aplicação
            InfoApp.sistema = campos[1];
            InfoApp.local = campos[0];
            InfoApp.dirfoto = campos[2];
            lblLocal.Text = "Local: " + InfoApp.local;
            lblSistema.Text = "Sistema: " + InfoApp.sistema;
            lblDir_Foto.Text = "Dir_Foto: " + InfoApp.dirfoto;

            AtualizaVersao();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FormShow(new FrmPadraoClient());
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            AtualizaVersao();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            FormShow(new FrmUsabilidade());
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            FormShow(new FrmUsuarios());
        }

        private void guna2GradientButton5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            FormShow(new FrmUsuarios());
        }

        private void guna2GradientButton5_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
