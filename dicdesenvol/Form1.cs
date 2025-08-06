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
            //this.Validate();
            //this.uSUARIOSBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.db_ab2460_USUARIOS_dbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN'. Você pode movê-la ou removê-la conforme necessário.
            this.hTML_CSS_RADZENTableAdapter.Fill(this.db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN);




            // TODO: esta linha de código carrega dados na tabela 'db_ab2460_USUARIOS_dbDataSet.USUARIOS'. Você pode movê-la ou removê-la conforme necessário.
            //this.uSUARIOSTableAdapter.Fill(this.db_ab2460_USUARIOS_dbDataSet.USUARIOS);

        }

        private void hTML_CSS_RADZENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


            // Atualiza DADOS da aplicação
            db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN.Rows[0]["LOCAL"] = InfoApp.local;
            db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN.Rows[0]["SISTEMA"] = InfoApp.sistema;

            this.hTML_CSS_RADZENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_HTML_CSS_RADZEN_DataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DateTime DataAtual = DateTime.Now;
            string DataFormat = DataAtual.ToString("dd/MM/yyyy");
            string HoraFormat = DataAtual.ToString("HH:mm:ss");


            txtData.Text = DataFormat;
            txtHora.Text = HoraFormat;
            
            

        }
    }
}
