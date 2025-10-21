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
using System.Drawing.Printing;




namespace dicdesenvol
{
    public partial class FrmCTRL_VersaoImp : Form
    {
        public FrmCTRL_VersaoImp()
        {
            InitializeComponent();
        }

        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

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

        
        private void FrmCTRL_VersaoImp_Load(object sender, EventArgs e)
        {
            var contador = 0;
            //declarando a variavel do tipo StreamWriter
            StreamReader x;

            //Colocando o caminho fisico
            string Caminho = "C:\\Windows\\Temp\\impTeste.txt";

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
            PdfBrush brush1 = PdfBrushes.DodgerBlue;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 24f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("CTRL_Versão", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);

            y = y + font1.MeasureString("CTRL_Versão", format1).Height;
            page.Canvas.DrawString("(impressão)", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);


            PdfStringFormat format2 = new PdfStringFormat(PdfTextAlignment.Left);
            page.Canvas.DrawString("Data: ", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format2);

            page.Canvas.DrawImage(PdfImage.FromFile("c:/temp/LUCSALE_Icone.png"), 10, 10, 50, 50);

            y = y + font1.MeasureString("Country List", format1).Height;

            y = y + 9;

            PdfPen pen = new PdfPen(PdfBrushes.Black, 1);
            page.Canvas.DrawLine(pen, 000, y, page.Canvas.ClientSize.Width, y);
            y = y + 2;

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
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.DodgerBlue;
            table.DataSource = dataSource;
            foreach (PdfColumn column in table.Columns)
            {
                column.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new PointF(0, y));

            ////Save the document to a PDF file 
            doc.SaveToFile("c:/temp/PdfTable.pdf");
            this.pdfViewer1.LoadFromFile("c:/temp/PdfTable.pdf");
        }
    }
}
