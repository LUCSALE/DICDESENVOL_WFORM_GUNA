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
using System.IO;




namespace dicdesenvol
{
    public partial class FrmUsabilidadeImp : Form
    {
        public FrmUsabilidadeImp()
        {
            InitializeComponent();
        }

        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contador = 0;
            //declarando a variavel do tipo StreamWriter
            StreamReader x;

            //Colocando o caminho fisico
            string Caminho = "C:\\Windows\\Temp\\impUsabilidade.txt";

            //abrindo um arquivo texto
            x = File.OpenText(Caminho);

            
            //Exemplo: pdf em "TABLET"
            //Create a pdf document.
            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 10;
            //title
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);
            page.Canvas.DrawString("Part Sales Information", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);
            y = y + font1.MeasureString("Country List", format1).Height;
            y = y + 5;

            

            
            String[][] dataSource
                   = new String[InfoApp.LinhasImp][];
            //enquanto nao retornar valor booleano true
            while (x.EndOfStream != true)//quer dizer que não chegou no fim do
                                         //arquivo
            {
                //le conteúdo da linha
                string linha = x.ReadLine();
                //escreve na tela o conteúdo da linha
                dataSource[contador] = linha.Split(';');
                contador++;
            }
            //após sair do while, é porque leu todo o conteúdo, então
            //temos que fechar o arquivo texto que está aberto
            x.Close();

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.Rows;
            table.Style.HeaderRowCount = 1;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            table.DataSource = dataSource;
            foreach (PdfColumn column in table.Columns)
            {
                column.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new PointF(0, y));

            ////Save the document to a PDF file 
            doc.SaveToFile("C:/Windows/Temp/impUsabilidade.pdf");
            this.pdfViewer1.LoadFromFile("C:/Windows/Temp/impUsabilidade.pdf");








            //try
            //{
            //    // TODO: esta linha de código carrega dados na tabela 'cTRL_VERSAO_cadastrodbDataSet.CTRL_VERSAO'. Você pode movê-la ou removê-la conforme necessário.
            //    this.cTRL_VERSAOTableAdapter.Fill(this.cTRL_VERSAO_cadastrodbDataSet.CTRL_VERSAO);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro ao Consultar tabela: Padrao - " + ex.Message);
            //}

            //DataTableReader dtr = this.cTRL_VERSAO_cadastrodbDataSet.CreateDataReader();

            ////Exemplo: pdf em "TABLE"
            ////Create a PdfDocument object
            //PdfDocument doc = new PdfDocument();

            ////Add a page
            //PdfPageBase page = doc.Pages.Add(PdfPageSize.A4, new PdfMargins(40));

            ////Create a PdfTable object
            //PdfTable table = new PdfTable();

            ////Set font for header and the rest cells
            //table.Style.DefaultStyle.Font = new PdfTrueTypeFont(new Font("Times New Roman", 12f, FontStyle.Regular), true);
            //table.Style.HeaderStyle.Font = new PdfTrueTypeFont(new Font("Times New Roman", 12f, FontStyle.Bold), true);

            //// Create a new DataTable
            //DataTable myDataTable = new DataTable("MyTable");

            //// Add columns to the DataTable
            //myDataTable.Columns.Add("ID");
            //myDataTable.Columns.Add("Data");
            //myDataTable.Columns.Add("Hora");
            //myDataTable.Columns.Add("Sistema");
            //myDataTable.Columns.Add("Versao");

            //// Populate the DataRow
            //if (dtr.HasRows)
            //{
            //    while (dtr.Read())
            //    {
            //        // Create a new DataRow
            //        DataRow newRow = myDataTable.NewRow();

            //        newRow["ID"] = dtr["ID"].ToString();
            //        newRow["Data"] = dtr["Data"].ToString();
            //        newRow["Hora"] = dtr["Hora"].ToString();
            //        newRow["Sistema"] = dtr["Sistema"].ToString();
            //        newRow["Versao"] = dtr["Versao"].ToString();
            //        myDataTable.Rows.Add(newRow);

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Não há dados");
            //}

            ////Set the datatable as the data source of table
            //table.DataSource = myDataTable;

            ////Show header(the header is hidden by default)
            //table.Style.ShowHeader = true;

            ////Set font color and backgroud color of header row
            //table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.AliceBlue;
            //table.Style.HeaderStyle.TextBrush = PdfBrushes.Black;

            ////Set text alignment in header row
            //table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);

            ////Set text alignment in other cells
            //for (int i = 0; i < table.Columns.Count; i++)
            //{
            //    table.Columns[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            //}

            ////Register with BeginRowLayout event
            ////table.BeginRowLayout += Table_BeginRowLayout;

            ////Draw table on the page
            //table.Draw(page, new PointF(0, 30));

            ////Save the document to a PDF file 
            //doc.SaveToFile("c:/temp/PdfTable.pdf");

            //this.pdfViewer1.LoadFromFile("c:/temp/PdfTable.pdf");

            //Exemplo: HEADER
            //create a PDF document
            //PdfDocument doc = new PdfDocument();
            //    doc.PageSettings.Size = PdfPageSize.A4;

            //    //reset the default margins to 0
            //    doc.PageSettings.Margins = new PdfMargins(0);

            //    //create a PdfMargins object, the parameters indicate the page margins you want to set
            //    PdfMargins margins = new PdfMargins(60, 60, 60, 60);

            //    //create a header template with content and apply it to page template
            //    doc.Template.Top = CreateHeaderTemplate(doc, margins);

            //    //apply blank templates to other parts of page template
            //    doc.Template.Bottom = new PdfPageTemplateElement(doc.PageSettings.Size.Width, margins.Bottom);
            //    doc.Template.Left = new PdfPageTemplateElement(margins.Left, doc.PageSettings.Size.Height);
            //    doc.Template.Right = new PdfPageTemplateElement(margins.Right, doc.PageSettings.Size.Height);

            //    //save the file
            //    doc.SaveToFile("c:/temp/PdfHeader.pdf");
            //    this.pdfViewer1.LoadFromFile("c:/temp/PdfHeader.pdf");


        }

        private void hTML_CSS_RADZENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
        
        }

        static PdfPageTemplateElement CreateHeaderTemplate(PdfDocument doc, PdfMargins margins)
        {
            //get page size
            SizeF pageSize = doc.PageSettings.Size;

            //create a PdfPageTemplateElement object as header space
            PdfPageTemplateElement headerSpace = new PdfPageTemplateElement(pageSize.Width, margins.Top);
            headerSpace.Foreground = false;

            //declare two float variables
            float x = margins.Left;
            float y = 0;

            //draw image in header space 
            PdfImage headerImage = PdfImage.FromFile("c:/temp/LUCSALE_Icone.png");
            float width = headerImage.Width / 3;
            float height = headerImage.Height / 3;
            headerSpace.Graphics.DrawImage(headerImage, x, margins.Top - height - 2, width, height);

            //draw line in header space
            PdfPen pen = new PdfPen(PdfBrushes.Gray, 1);
            headerSpace.Graphics.DrawLine(pen, x, y + margins.Top - 2, pageSize.Width - x, y + margins.Top - 2);

            //draw text in header space
            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Impact", 25f, FontStyle.Bold));
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Left);
            String headerText = "HEADER TEXT";
            SizeF size = font.MeasureString(headerText, format);
            headerSpace.Graphics.DrawString(headerText, font, PdfBrushes.Gray, pageSize.Width - x - size.Width - 2, margins.Top - (size.Height + 5), format);

            //return headerSpace
            return headerSpace;
        }
    }
}
