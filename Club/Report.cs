using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Club
{
    public partial class Report : Form
    {
        private int _eId;
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runningClubDataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this.runningClubDataSet.Event);
            _eId = Convert.ToInt32(comboBox1.SelectedValue);
            dataTable1TableAdapter.FillResult(runningClubDataSet.DataTable1, _eId);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _eId = Convert.ToInt32(comboBox1.SelectedValue);
            dataTable1TableAdapter.FillResult(runningClubDataSet.DataTable1, _eId);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Protocol.pdf", FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(7);
            PdfPCell header = new PdfPCell(new Phrase(eventTableAdapter.GetDataBy1(_eId).First().Name, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            header.Colspan = 7;
            header.HorizontalAlignment = 1;
            table.AddCell(header);
            if (dataTable1TableAdapter.GetDataBy(_eId, 1).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("1 km"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                table.AddCell(@"Id");
                table.AddCell(@"Name");
                table.AddCell(@"Coach");
                table.AddCell(@"Club");
                table.AddCell(@"Heat");
                table.AddCell(@"Distance");
                table.AddCell(@"Result");
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 1))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 3).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("3 km"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 3))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 5).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("5 km"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 5))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 10).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("10 km"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 10))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 21).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("21 km"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 21))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 42).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("42 km"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 42))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 60).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("60 m"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 60))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 100).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("100 m"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 100))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 200).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("200 m"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 200))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 400).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("400 m"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 400))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 800).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("800 m"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 800))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }
            if (dataTable1TableAdapter.GetDataBy(_eId, 1500).Count != 0)
            {
                PdfPCell header2 = new PdfPCell(new Phrase("1500 m"));
                header2.Colspan = 7;
                header2.HorizontalAlignment = 1;

                table.AddCell(header2);
                foreach (var item in dataTable1TableAdapter.GetDataBy(_eId, 1500))
                {
                    table.AddCell(item.Id.ToString());
                    table.AddCell(item.Name);
                    table.AddCell(item.Coach);
                    table.AddCell(item.Club);
                    table.AddCell(item.Heat.ToString());
                    table.AddCell(item.Distance.ToString());
                    table.AddCell(item.Result.ToString());
                }
            }

            PdfPCell footer = new PdfPCell(new Phrase("Chief refferee_____________"));
            footer.Colspan = 3;
            PdfPCell footer2 = new PdfPCell(new Phrase("Chief secretary___________"));
            footer2.Colspan = 4;
            table.AddCell(footer);
            table.AddCell(footer2);
            doc.Add(table);
            doc.Close();
            MessageBox.Show(@"Done!");
        }
    }
}