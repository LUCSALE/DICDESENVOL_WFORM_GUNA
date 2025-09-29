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
            //Exemplo: pdf em "GRID" (outro exemplo)   
            //Create a PdfDocument object
            PdfDocument doc = new PdfDocument();

            //Add a page 
            PdfPageBase page = doc.Pages.Add(PdfPageSize.A4, new PdfMargins(40));

            //Create a PdfGrid
            PdfGrid grid = new PdfGrid();

            //Set cell padding
            grid.Style.CellPadding = new PdfPaddings(1, 1, 1, 1);

            //Set font
            grid.Style.Font = new PdfTrueTypeFont(new Font("Times New Roman", 13f, FontStyle.Regular), true);

            //Add rows
            PdfGridRow row1 = grid.Rows.Add();
            PdfGridRow row2 = grid.Rows.Add();
            PdfGridRow row3 = grid.Rows.Add();
            grid.Columns.Add(5);

            //Set column width
            foreach (PdfGridColumn col in grid.Columns)
            {
                col.Width = 110f;
            }

            //Write data into specific cells
            row1.Cells[0].Value = "Order and Payment Status";
            row2.Cells[0].Value = "Order number";
            row2.Cells[1].Value = "Date";
            row2.Cells[2].Value = "Customer";
            row2.Cells[3].Value = "Paid or not";
            row3.Cells[0].Value = "00223";
            row3.Cells[1].Value = "2022/06/02";
            row3.Cells[2].Value = "Brick Lane Realty";
            row3.Cells[3].Value = "Yes";
            row4.Cells[0].Value = "00224";
            row4.Cells[1].Value = "2022/06/03";
            row4.Cells[3].Value = "No";

            //Span cell across columns
            row1.Cells[0].ColumnSpan = 4;

            //Span cell across rows
            row3.Cells[2].RowSpan = 2;

            //Set text alignment of specific cells
            row1.Cells[0].StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            row3.Cells[2].StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);

            //Set background color of specific cells
            row1.Cells[0].Style.BackgroundBrush = PdfBrushes.Orange;
            row4.Cells[3].Style.BackgroundBrush = PdfBrushes.LightGray;

            //Format cell border
            PdfBorders borders = new PdfBorders();
            borders.All = new PdfPen(Color.Orange, 0.8f);
            foreach (PdfGridRow pgr in grid.Rows)
            {
                foreach (PdfGridCell pgc in pgr.Cells)
                {
                    pgc.Style.Borders = borders;
                }
            }

            //Draw table on the page
            grid.Draw(page, new PointF(0, 30));

            //Save the document to a PDF file
            doc.SaveToFile("c:/temp/PdfGrid.pdf");
            this.pdfViewer1.LoadFromFile("c:/temp/PdfGrid.pdf");



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
