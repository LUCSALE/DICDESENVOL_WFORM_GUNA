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
using Spire.Pdf.Graphics;
using Spire.Pdf;
using Spire.Pdf.Tables;
using Spire.Pdf.Grid;


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

            //Exemplo: word document
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


            //Exemplo: pdfViewer
            ////load the sample PDF file
            //this.pdfViewer1.LoadFromFile("c:/zzz.pdf");


            //Exemplo: pdfViewer com ODBC
            //string connectionString = "DSN=SQL1001_site4now_net;UID=db_ab2460_cadastrodb_admin;PWD=Mag160163@";
            //OdbcConnection connection = new OdbcConnection(connectionString);

            //OdbcCommand command = new OdbcCommand("SELECT * FROM CTRL_Versao", connection);




            //Spire.DataExport.PDF.PDFExport pdfExport1 = new Spire.DataExport.PDF.PDFExport();
            //pdfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
            //pdfExport1.DataFormats.CultureName = "zh-CN";
            //pdfExport1.DataFormats.Currency = "c";
            //pdfExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
            //pdfExport1.DataFormats.Float = "g";
            //pdfExport1.DataFormats.Integer = "g";
            //pdfExport1.DataFormats.Time = "H:mm";
            //pdfExport1.FileName = "sample.pdf";
            //pdfExport1.PDFOptions.DataFont.CustomFont = new System.Drawing.Font("Arial", 10F);
            //pdfExport1.PDFOptions.FooterFont.CustomFont = new System.Drawing.Font("Arial", 10F);
            //pdfExport1.PDFOptions.HeaderFont.CustomFont = new System.Drawing.Font("Arial", 10F);
            //pdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.User;
            //pdfExport1.PDFOptions.PageOptions.Height = 11.67;
            //pdfExport1.PDFOptions.PageOptions.MarginBottom = 0.78;
            //pdfExport1.PDFOptions.PageOptions.MarginLeft = 1.17;
            //pdfExport1.PDFOptions.PageOptions.MarginRight = 0.57;
            //pdfExport1.PDFOptions.PageOptions.MarginTop = 0.78;
            //pdfExport1.PDFOptions.PageOptions.Width = 10.25;
            //pdfExport1.PDFOptions.TitleFont.CustomFont = new System.Drawing.Font("Arial", 10F);
            //pdfExport1.SQLCommand = command;

            //connection.Open();
            //pdfExport1.SaveToFile();


            //Exemplo: pdf document 
            //Create a pdf document.
            //PdfDocument doc = new PdfDocument();

            // Create one page
            //PdfPageBase page = doc.Pages.Add();

            //Draw the text
            //page.Canvas.DrawString("Hello, World!",
            //                     new PdfFont(PdfFontFamily.Helvetica, 30f),
            //                     new PdfSolidBrush(Color.Black),
            //                     10, 10);

            //Save pdf file.
            //doc.SaveToFile("c:/temp/HelloWorld.pdf");
            //doc.Close();

            //Launching the Pdf file.
            //this.pdfViewer1.LoadFromFile("c:/temp/HelloWorld.pdf");

            ////Exemplo: pdf Grafico
            //// Create a PdfDocument instance
            //PdfDocument pdf = new PdfDocument();

            //// Add a page
            //PdfPageBase page = pdf.Pages.Add();

            //// Save the current graphics state
            //PdfGraphicsState state = page.Canvas.Save();

            //// Specify the PDF font and brush           
            //PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 18f);
            //PdfSolidBrush brush1 = new PdfSolidBrush(Color.Green);
            //PdfSolidBrush brush2 = new PdfSolidBrush(Color.Blue);
            //PdfSolidBrush brush3 = new PdfSolidBrush(Color.Magenta);

            //// Translate the coordinate system by specified coordinates
            //page.Canvas.TranslateTransform(20, 280);

            //// Scale the coordinate system by specified coordinates
            //page.Canvas.ScaleTransform(1f, 0.6f);
            //// Skew the coordinate system axes
            //page.Canvas.SkewTransform(-10, 0);
            //// Draw transformed text on the page
            //page.Canvas.DrawString("A Powerful PDF Processing Library", font, brush1, 0, -30);

            //// Skew the coordinate system axes
            //page.Canvas.SkewTransform(10, 0);
            //// Draw transformed text on the page
            //page.Canvas.DrawString("A Powerful PDF Processing Library", font, brush2, 0, 0);

            ////Scale the coordinate system by specified coordinates
            //page.Canvas.ScaleTransform(1f, -1f);
            //// Draw transformed text on the page
            //page.Canvas.DrawString("A Powerful PDF Processing Library", font, brush3, 0, 0);

            //// Restor graphics state
            //page.Canvas.Restore(state);

            //// Save the result document
            //pdf.SaveToFile("c:/temp/TransformText.pdf");
            //pdf.Close();
            //this.pdfViewer1.LoadFromFile("c:/temp/TransformText.pdf");


            //Exemplo: pdf BÁSICO com adição de TEMPLATE
            //Create a pdf document.
            //PdfDocument doc = new PdfDocument();

            //// Create one page
            //PdfPageBase page = doc.Pages.Add();
            //doc.LoadFromFile("c:/temp/impCTRL_Versao.pdf"); 

            ////Draw the text
            //page.Canvas.DrawString("Hello, World!",
            //                       new PdfFont(PdfFontFamily.Helvetica, 30f),
            //                       new PdfSolidBrush(Color.Black),
            //                       10, 10);

            ////Save pdf file.
            //doc.SaveToFile("c:/temp/HelloWorld.pdf");
            //doc.Close();

            ////Launching the Pdf file.
            //this.pdfViewer1.LoadFromFile("c:/temp/HelloWorld.pdf");

            //Exemplo: pdf em "TABLET"
            //   //Create a pdf document.
            //   PdfDocument doc = new PdfDocument();
            //   PdfSection sec = doc.Sections.Add();
            //   sec.PageSettings.Width = PdfPageSize.A4.Width;
            //   PdfPageBase page = sec.Pages.Add();
            //   float y = 10;
            //   //title
            //   PdfBrush brush1 = PdfBrushes.Black;
            //   PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            //   PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);
            //   page.Canvas.DrawString("Part Sales Information", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);
            //   y = y + font1.MeasureString("Country List", format1).Height;
            //   y = y + 5;

            //   String[] data
            //= {
            //   "PartNo;Description;OnHand;OnOrder;Cost;ListPrice",
            //   "900;Dive kayak;24;16;1356.75;3999.95",
            //   "912;Underwater Diver Vehicle;5;3;504;1680",
            //   "1313;Regulator System;165;216;117.5;250",
            //   "1314;Second Stage Regulator;98;88;124.1;365",
            //   "1316;Regulator System;75;70;119.35;341",
            //   "1320;Second Stage Regulator;37;35;73.53;171",
            //   "1328;Regulator System;166;100;154.8;430",
            //   "1330;Alternate Inflation Regulator;47;43;85.8;260",
            //   "1364;Second Stage Regulator;128;135;99.9;270",
            //   "1390;First Stage Regulator;146;140;64.6;170",
            //   "1946;Second Stage Regulator;13;10;95.79;309",
            //   "1986;Depth/Pressure Gauge Console;25;24;73.32;188",
            //   "2314;Electronic Console;13;12;120.9;390",
            //   "2341;Depth/Pressure Gauge;226;225;48.3;105",
            //   "2343;Personal Dive Sonar;46;45;72.85;235",
            //   "2350;Compass Console Mount;211;300;10.15;29"
            //   };
            //   String[][] dataSource
            //       = new String[data.Length][];
            //   for (int i = 0; i < data.Length; i++)
            //   {
            //       dataSource[i] = data[i].Split(';');
            //   }

            //   PdfTable table = new PdfTable();
            //   table.Style.CellPadding = 2;
            //   table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            //   table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            //   table.Style.HeaderSource = PdfHeaderSource.Rows;
            //   table.Style.HeaderRowCount = 1;
            //   table.Style.ShowHeader = true;
            //   table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            //   table.DataSource = dataSource;
            //   foreach (PdfColumn column in table.Columns)
            //   {
            //       column.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            //   }
            //   table.Draw(page, new PointF(0, y));

            //   doc.SaveToFile("c:/temp/SimpleTable.pdf");

            //   ////Launching the Pdf file.
            //   this.pdfViewer1.LoadFromFile("c:/temp/SimpleTable.pdf");


            //Exemplo: pdf em "GRID"
            //PdfDocument document = new PdfDocument();
            //PdfPageBase page = document.Pages.Add();

            //String[] data
            //   = {
            //        "VendorName;Address;City",
            //        "Cacor Corporation;161 Southfield Rd;Southfield",
            //        "Underwater;50 N 3rd Street;Indianapolis",
            //        "J.W.  Luscher Mfg.;65 Addams Street;Berkely"
            //    };

            //PdfGrid grid = new PdfGrid();
            //for (int r = 0; r < data.Length; r++)
            //{
            //    PdfGridRow row = grid.Rows.Add();
            //}
            //grid.Columns.Add(3);

            //float width = page.Canvas.ClientSize.Width - (grid.Columns.Count + 1);
            //grid.Columns[0].Width = width * 0.15f;
            //grid.Columns[1].Width = width * 0.15f;
            //grid.Columns[2].Width = width * 0.15f;

            //float height = page.Canvas.ClientSize.Height - (grid.Rows.Count + 1);
            //grid.Rows[0].Height = 12.5f;
            //grid.Rows[1].Height = 12.5f;
            //grid.Rows[2].Height = 12.5f;
            //grid.Rows[3].Height = 12.5f;

            ////insert data to grid
            //for (int r = 0; r < data.Length; r++)
            //{
            //    String[] rowData = data[r].Split(';');
            //    for (int c = 0; c < rowData.Length; c++)
            //    {
            //        grid.Rows[r].Cells[c].Value = rowData[c];
            //    }
            //}

            //grid.Rows[0].Style.Font = new PdfTrueTypeFont(new Font("Arial", 8f, FontStyle.Bold), true);

            ////Set borders color to LightBule
            //PdfBorders border = new PdfBorders();
            //border.All = new PdfPen(Color.LightBlue);

            //foreach (PdfGridRow pgr in grid.Rows)
            //{
            //    foreach (PdfGridCell pgc in pgr.Cells)
            //    {
            //        pgc.Style.Borders = border;
            //    }
            //}

            //PdfLayoutResult result = grid.Draw(page, new PointF(10, 30));
            //document.SaveToFile("c:/temp/result.pdf");

            //this.pdfViewer1.LoadFromFile("c:/temp/result.pdf");

            //Exemplo: pdf em "TABLE"
            //Create a PdfDocument object
            PdfDocument doc = new PdfDocument();

            //Add a page
            PdfPageBase page = doc.Pages.Add(PdfPageSize.A4, new PdfMargins(40));

            //Create a PdfTable object
            PdfTable table = new PdfTable();

            //Set font for header and the rest cells
            table.Style.DefaultStyle.Font = new PdfTrueTypeFont(new Font("Times New Roman", 12f, FontStyle.Regular), true);
            table.Style.HeaderStyle.Font = new PdfTrueTypeFont(new Font("Times New Roman", 12f, FontStyle.Bold), true);

            //Crate a DataTable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Department");
            dataTable.Columns.Add("Position");
            dataTable.Columns.Add("Level");
            dataTable.Rows.Add(new string[] { "1", "David", "IT", "Manager", "1" });
            dataTable.Rows.Add(new string[] { "3", "Julia", "HR", "Manager", "1" });
            dataTable.Rows.Add(new string[] { "4", "Sophie", "Marketing", "Manager", "1" });
            dataTable.Rows.Add(new string[] { "7", "Wickey", "Marketing", "Sales Rep", "2" });
            dataTable.Rows.Add(new string[] { "9", "Wayne", "HR", "HR Supervisor", "2" });
            dataTable.Rows.Add(new string[] { "11", "Mia", "Dev", "Developer", "2" });

            //Set the datatable as the data source of table
            table.DataSource = dataTable;

            //Show header(the header is hidden by default)
            table.Style.ShowHeader = true;

            //Set font color and backgroud color of header row
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.Gray;
            table.Style.HeaderStyle.TextBrush = PdfBrushes.White;

            //Set text alignment in header row
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);

            //Set text alignment in other cells
            for (int i = 0; i < table.Columns.Count; i++)
            {
                table.Columns[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }

            //Register with BeginRowLayout event
            //table.BeginRowLayout += Table_BeginRowLayout;

            //Draw table on the page
            table.Draw(page, new PointF(0, 30));

            //Save the document to a PDF file 
            doc.SaveToFile("c:/temp/PdfTable.pdf");

            this.pdfViewer1.LoadFromFile("c:/temp/PdfTable.pdf");


        }
    }




}
