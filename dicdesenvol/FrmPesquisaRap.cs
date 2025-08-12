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
    public partial class FrmPesquisaRap : Form
    {
        public FrmPesquisaRap()
        {
            InitializeComponent();
        }

        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'db_ab2460_USABILIDADE.HTML_CSS_USABILIDADE'. Você pode movê-la ou removê-la conforme necessário.
                this.hTML_CSS_USABILIDADETableAdapter.Fill(this.db_ab2460_USABILIDADE.HTML_CSS_USABILIDADE);

                // TODO: esta linha de código carrega dados na tabela 'db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN'. Você pode movê-la ou removê-la conforme necessário.
                //this.hTML_CSS_RADZENTableAdapter.Fill(this.db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN);
                this.hTML_CSS_RADZENBindingSource.AddNew();

                DateTime DataAtual = DateTime.Now;
                string DataFormat = DataAtual.ToString("dd/MM/yyyy");
                string HoraFormat = DataAtual.ToString("HH:mm:ss");

                // Atualiza DADOS da aplicação
                txtData.Text = DataFormat;
                txtHora.Text = HoraFormat;
                txtLocal.Text = InfoApp.local;
                toolStripLabel1.Text = "Local: " + InfoApp.local;
                txtSistema.Text = InfoApp.sistema;
                toolStripLabel2.Text = "Sistema: " + InfoApp.sistema;
                hTML_CSS_RADZENBindingNavigatorSaveItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao CONECTAR AO BANCO DE DADOS: " + ex.Message);
            }

        }

        private void hTML_CSS_RADZENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.hTML_CSS_RADZENBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.db_HTML_CSS_RADZEN_DataSet);
                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar: " + ex.Message);
            }
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DateTime DataAtual = DateTime.Now;
            string DataFormat = DataAtual.ToString("dd/MM/yyyy");
            string HoraFormat = DataAtual.ToString("HH:mm:ss");

            // Atualiza DADOS da aplicação
            txtData.Text = DataFormat;
            txtHora.Text = HoraFormat;
            txtLocal.Text = InfoApp.local;
            txtSistema.Text = InfoApp.sistema;



        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DateTime DataAtual = DateTime.Now;
            string nomeArquivo = "IMG_" + DataAtual.ToString("yyyyMMdd_HHmmss") + ".png";

            //openFileDialog1.InitialDirectory = @InfoApp.local;
            //openFileDialog1.Filter = "Arquivos de Imagem (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|Todos os Arquivos (*.*)|*.*";
            //openFileDialog1.Title = "Selecione uma Imagem";
            //openFileDialog1.ShowDialog();
            //fOTO_ARQUIVOTextBox.Text = openFileDialog1.FileName;

            if (string.IsNullOrEmpty(txtFoto_Arquivo.Text))
            {
                txtFoto_Arquivo.Text = nomeArquivo;
                Clipboard.SetText(nomeArquivo);
            }
            else
            {
                DialogResult result = MessageBox.Show("Já existe um nome de arquivo definido !!!", "IMAGEM: ", MessageBoxButtons.OK);

            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoto_Arquivo.Text))
            {
                DialogResult result = MessageBox.Show("Arquivo INDEFINIDO !!!", "IMAGEM: ", MessageBoxButtons.OK);
            }
            else
            {
                System.Diagnostics.Process.Start(InfoApp.dirfoto + txtFoto_Arquivo.Text);


            }
        }
    }
}
