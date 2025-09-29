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
    public partial class FrmCTRL_VersaoImp : Form
    {
        public FrmCTRL_VersaoImp()
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
                // TODO: esta linha de código carrega dados na tabela 'cTRL_VERSAO_cadastrodbDataSet.CTRL_VERSAO'. Você pode movê-la ou removê-la conforme necessário.
                this.cTRL_VERSAOTableAdapter.Fill(this.cTRL_VERSAO_cadastrodbDataSet.CTRL_VERSAO);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Consultar tabela: Padrao - " + ex.Message);
            }

            DataTableReader dtr = this.cTRL_VERSAO_cadastrodbDataSet.CreateDataReader();

            if (dtr.HasRows)
            {
                while (dtr.Read())
                {
                    MessageBox.Show(dtr["Versao"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Não há dados");
            }

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

            String[] data
         = {
               "PartNo;Description;OnHand;OnOrder;Cost;ListPrice",
               "900;Dive kayak;24;16;1356.75;3999.95"
               //"912;Underwater Diver Vehicle;5;3;504;1680",
               //"1313;Regulator System;165;216;117.5;250",
               //"1314;Second Stage Regulator;98;88;124.1;365",
               //"1316;Regulator System;75;70;119.35;341",
               //"1320;Second Stage Regulator;37;35;73.53;171",
               //"1328;Regulator System;166;100;154.8;430",
               //"1330;Alternate Inflation Regulator;47;43;85.8;260",
               //"1364;Second Stage Regulator;128;135;99.9;270",
               //"1390;First Stage Regulator;146;140;64.6;170",
               //"1946;Second Stage Regulator;13;10;95.79;309",
               //"1986;Depth/Pressure Gauge Console;25;24;73.32;188",
               //"2314;Electronic Console;13;12;120.9;390",
               //"2341;Depth/Pressure Gauge;226;225;48.3;105",
               //"2343;Personal Dive Sonar;46;45;72.85;235",
               //"2350;Compass Console Mount;211;300;10.15;29"
               };
            MessageBox.Show(data.Count().ToString());
            
            String[][] dataSource
                = new String[data.Length][];
            
            for (int i = 0; i < data.Length; i++)
            {
                dataSource[i] = data[i].Split(';');
            }

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

            doc.SaveToFile("c:/temp/SimpleTable.pdf");

            ////Launching the Pdf file.
            this.pdfViewer1.LoadFromFile("c:/temp/SimpleTable.pdf");
                     



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
