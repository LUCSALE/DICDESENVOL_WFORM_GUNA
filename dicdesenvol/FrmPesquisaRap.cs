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

        private void FrmPadrao_Load(object sender, EventArgs e)
        {
            // Atualiza DADOS da aplicação
            toolStripLabel1.Text = "Local: " + InfoApp.local;
            toolStripLabel2.Text = "Sistema: " + InfoApp.sistema;
            
            // Inicializa Tabela em MODO INCLUSÃO
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'db_ab2460_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN'. Você pode movê-la ou removê-la conforme necessário.
                this.hTML_CSS_RADZENTableAdapter.Fill(this.db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN);
                hTMLCSSRADZENBindingSource.AddNew();
                //this.Cursor = Cursors.Default;
                DateTime DataAtual = DateTime.Now;
                string DataFormat = DataAtual.ToString("dd/MM/yyyy");
                string HoraFormat = DataAtual.ToString("HH:mm:ss");


                txtData.Text = DataFormat;
                txtHora.Text = HoraFormat;
                txtLocal.Text = InfoApp.local;
                txtSistema.Text = InfoApp.sistema;
                //cbxUSABILIDADE_OBJETIVO.Focus();

            }
            catch (Exception ex)
            {
                    MessageBox.Show("Erro ao Consultar tabela: Padrao - " + ex.Message);
            }
            //this.Cursor = Cursors.Default;


        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Versão: " + guna2DataGridView1.CurrentRow.Cells[0].Value.ToString() + "\n" +
            //                "Data: " + guna2DataGridView1.CurrentRow.Cells[1].Value.ToString() + "\n" +
            //                "Descrição: " + guna2DataGridView1.CurrentRow.Cells[2].Value.ToString());           
            
            //txtID.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void guna2DataGridView1_Click_1(object sender, EventArgs e)
        {
            //txtID.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtData.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtHora.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();


            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    this.Validate();
            //    this.hTMLCSSUSABILIDADEBindingSource.EndEdit();
            //    this.hTML_CSS_USABILIDADETableAdapter.Update(this.db_ab2460_Usabilidade_DataSet);
            //    MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro ao Salvar: " + ex.Message);
            //}
            this.Close();        
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmPadrao_Shown(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void salvarToolStripButton_Click_1(object sender, EventArgs e)
        {
            
            
            try
            {
                this.Validate();
                
                // Atualiza DADOS da aplicação
                //db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN.Rows[0]["LOCAL"] = InfoApp.local;
                //db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN.Rows[0]["SISTEMA"] = InfoApp.sistema; ---> NÃO FUNCIONA

                this.hTMLCSSRADZENBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.db_HTML_CSS_RADZEN_DataSet);
                                
                MessageBox.Show("Dados salvos com sucesso !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar: " + ex.Message);
            }
            this.Close();
        }

        private void guna2DataGridView1_Click_2(object sender, EventArgs e)
        {
            //txtUsabilidade_Objetivo.Focus();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            //txtUsabilidade_Objetivo.Focus();
        }
    }
}
