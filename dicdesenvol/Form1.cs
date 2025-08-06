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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN'. Você pode movê-la ou removê-la conforme necessário.
            this.hTML_CSS_RADZENTableAdapter.Fill(this.db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN);
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

        private void hTML_CSS_RADZENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.hTML_CSS_RADZENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_HTML_CSS_RADZEN_DataSet);

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
    }
}
