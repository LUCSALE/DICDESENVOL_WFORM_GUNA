using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;


namespace dicdesenvol
{
    public partial class FrmCTRL_Versao : Form
    {
        public FrmCTRL_Versao()
        {
            InitializeComponent();
        }

        private void FrmPadrao_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'db_ab2460_cadastrodbDataSet.Padrao'. Você pode movê-la ou removê-la conforme necessário.
                this.cTRL_VERSAOTableAdapter.Fill(this.cTRL_VERSAO_cadastrodbDataSet.CTRL_VERSAO);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Consultar tabela: Padrao - " + ex.Message);
            }



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
            DateTime DataAtual = DateTime.Now;
            string DataFormat = DataAtual.ToString("dd/MM/yyyy");
            string HoraFormat = DataAtual.ToString("HH:mm:ss");
            txtData.Text = DataFormat;
            txtHora.Text = HoraFormat;

            try
            {
                this.Validate();
                this.cTRLVERSAOBindingSource.EndEdit();
                this.cTRL_VERSAOTableAdapter.Update(this.cTRL_VERSAO_cadastrodbDataSet);
                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtSistema.Focus();
        }

        private void guna2DataGridView1_Click_3(object sender, EventArgs e)
        {
            txtSistema.Focus();
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            //Create word document
            Document document = new Document();

            //Create a new paragraph
            Paragraph paragraph = document.AddSection().AddParagraph();

            //Append Text
            paragraph.AppendText("Hello World!");

            //Save doc file.
            document.SaveToFile("Sample.doc", FileFormat.Doc);

            //Launching the MS Word file.
            try
            {
                System.Diagnostics.Process.Start("Sample.doc");
            }

            catch { }
        }
    }
}
