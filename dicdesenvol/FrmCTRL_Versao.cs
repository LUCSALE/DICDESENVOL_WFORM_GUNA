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
using System.Data.Odbc;


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
            //////Create word document
            //Document document = new Document();

            //////Create a new paragraph
            //Paragraph paragraph = document.AddSection().AddParagraph();

            //////Append Text
            //paragraph.AppendText("Teste !!!");

            //////Save doc file.
            //document.SaveToFile("Sample.doc", FileFormat.Doc);

            //////Launching the MS Word file.
            //try
            //{
            //    System.Diagnostics.Process.Start("Sample.doc");
            //}

            //catch { }

            ////load the sample PDF file
            //this.pdfViewer1.LoadFromFile("c:/zzz.pdf");

            string connectionString = "DSN=SQL1001_site4now_net;UID=db_ab2460_cadastrodb_admin;PWD=Mag160163@";
            OdbcConnection connection = new OdbcConnection(connectionString);

            OdbcCommand command = new OdbcCommand("SELECT * FROM CTRL_Versao", connection);




            Spire.DataExport.PDF.PDFExport pdfExport1 = new Spire.DataExport.PDF.PDFExport();
            pdfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
            pdfExport1.DataFormats.CultureName = "zh-CN";
            pdfExport1.DataFormats.Currency = "c";
            pdfExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
            pdfExport1.DataFormats.Float = "g";
            pdfExport1.DataFormats.Integer = "g";
            pdfExport1.DataFormats.Time = "H:mm";
            pdfExport1.FileName = "sample.pdf";
            pdfExport1.PDFOptions.DataFont.CustomFont = new System.Drawing.Font("Arial", 10F);
            pdfExport1.PDFOptions.FooterFont.CustomFont = new System.Drawing.Font("Arial", 10F);
            pdfExport1.PDFOptions.HeaderFont.CustomFont = new System.Drawing.Font("Arial", 10F);
            pdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.User;
            pdfExport1.PDFOptions.PageOptions.Height = 11.67;
            pdfExport1.PDFOptions.PageOptions.MarginBottom = 0.78;
            pdfExport1.PDFOptions.PageOptions.MarginLeft = 1.17;
            pdfExport1.PDFOptions.PageOptions.MarginRight = 0.57;
            pdfExport1.PDFOptions.PageOptions.MarginTop = 0.78;
            pdfExport1.PDFOptions.PageOptions.Width = 10.25;
            pdfExport1.PDFOptions.TitleFont.CustomFont = new System.Drawing.Font("Arial", 10F);
            pdfExport1.SQLCommand = command;

            connection.Open();
            pdfExport1.SaveToFile();


        }
    
    }
}
