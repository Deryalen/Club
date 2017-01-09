﻿using System;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Club
{
    public partial class ClubReport : Form
    {
        private int _cId;
        public ClubReport()
        {
            InitializeComponent();
        }

        private void ClubReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runningClubDataSet.HeatParticipants". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runningClubDataSet.Club". При необходимости она может быть перемещена или удалена.
            this.clubTableAdapter.Fill(this.runningClubDataSet.Club);
            try
            {
                var club = club2TableAdapter.GetData(Convert.ToInt32(comboBox1.SelectedValue));
                label8.Text = club2TableAdapter.GetData(club.First().Id).First().Id.ToString();
                label9.Text = club2TableAdapter.GetData(club.First().Id).First().Name;
                label10.Text = club2TableAdapter.GetData(club.First().Id).First().City;
                label11.Text = club2TableAdapter.GetData(club.First().Id).First().Coaches.ToString();
                label12.Text = club2TableAdapter.GetData(club.First().Id).First().Students.ToString();
                label13.Text = club2TableAdapter.ScalarQuery(club.First().Id).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _cId = Convert.ToInt32(comboBox1.SelectedValue);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cId = Convert.ToInt32(comboBox1.SelectedValue);
            try
            {
                var club = club2TableAdapter.GetData(Convert.ToInt32(comboBox1.SelectedValue));
                label8.Text = club2TableAdapter.GetData(club.Single().Id).Single().Id.ToString();
                label9.Text = club2TableAdapter.GetData(club.Single().Id).Single().Name;
                label10.Text = club2TableAdapter.GetData(club.Single().Id).Single().City;
                label11.Text = club2TableAdapter.GetData(club.Single().Id).Single().Coaches.ToString();
                label12.Text = club2TableAdapter.GetData(club.Single().Id).Single().Students.ToString();
                label13.Text = club2TableAdapter.ScalarQuery(club.Single().Id).ToString();
                dataGridView1.DataSource = heatParticipantsTableAdapter.FillBy2(runningClubDataSet.HeatParticipants,
                    club.Single().Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Report.pdf", FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(2);
            PdfPCell header = new PdfPCell(new Phrase(club2TableAdapter.GetData(_cId).Single().Name, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            header.Colspan = 2;
            header.HorizontalAlignment = 1;
            table.AddCell(header);
            var item = club2TableAdapter.GetData(_cId).First();
            if (club2TableAdapter.GetData(_cId).Count != 0)
            {
                var club = club2TableAdapter.GetData(Convert.ToInt32(comboBox1.SelectedValue));
                table.AddCell(@"Id:");
                table.AddCell(item.Id.ToString());
                table.AddCell(@"City:");
                table.AddCell(item.City);
                table.AddCell(@"Number of coaches:");
                table.AddCell(item.Coaches.ToString());
                table.AddCell(@"Number of students:");
                table.AddCell(item.Students.ToString());
                table.AddCell(@"Number of results:");
                table.AddCell(label13.Text = club2TableAdapter.ScalarQuery(club.Single().Id).ToString());
            }
            PdfPCell footer = new PdfPCell(new Phrase(DateTime.Now.ToString()));
            PdfPCell footer2 = new PdfPCell(new Phrase(@"Club president______________"));
            table.AddCell(footer);
            table.AddCell(footer2);
            doc.Add(table);
            doc.Close();
            MessageBox.Show(@"Done!");
        }
    }
}