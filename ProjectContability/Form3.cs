using Newtonsoft.Json;
using ProjectContability.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace ProjectContability
{
    public partial class Form3 : Form
    {
        List<Data> partidas = new List<Data>();
        string partidasFile = "C:\\Users\\Public\\Partidas.json";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if(validarArchivos())
            {
                using (StreamReader rs = new StreamReader(partidasFile))
                {
                    partidas = JsonConvert.DeserializeObject<List<Data>>(rs.ReadToEnd());
                    rs.Close();
                }

                if (partidas == null)
                {
                    partidas = new List<Data>();
                }
            }
            else
            {
                File.Create("C:\\Users\\Public\\Partidas.json");
            }

            Balancedesaldos bs = new Balancedesaldos();
            dataGridView2.DataSource = new BindingList<DataToGeneralBalance>(bs.GenerateBalanceSaldos(partidas));

            GeneralBalance gb = new GeneralBalance();
            dataGridView1.DataSource = new BindingList<DataToGeneralBalance>(gb.GenerateGeneralBalance(partidas));
        }
        protected bool validarArchivos()
        {
            return
                File.Exists(partidasFile);
        }

        protected void balanceSaldosPDF()
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            string Path = "C:\\Users\\Public\\Balance De Saldos.pdf";
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            using (FileStream fs = new FileStream(Path + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 15f, 1f, 1f, 0f);
                PdfWriter.GetInstance(pdfDoc, fs);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                fs.Close();
            }
        }

        protected void balanceGeneralPDF()
        {
            PdfPTable pdfTable2 = new PdfPTable(dataGridView2.ColumnCount);
            pdfTable2.DefaultCell.Padding = 3;
            pdfTable2.WidthPercentage = 30;
            pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable2.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable2.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable2.AddCell(cell.Value.ToString());
                }
            }

            string Path = "C:\\Users\\Public\\Balance General.pdf";
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            using (FileStream fs = new FileStream(Path + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 15f, 1f, 1f, 0f);
                PdfWriter.GetInstance(pdfDoc, fs);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable2);
                pdfDoc.Close();
                fs.Close();
            }
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            this.balanceSaldosPDF();
            this.balanceGeneralPDF();
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void copyAlltoClipboard2()
        {
            dataGridView2.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void excel()
        {
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            excel();
            copyAlltoClipboard2();
            excel();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
