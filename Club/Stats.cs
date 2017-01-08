using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Club.RunningClubDataSetTableAdapters;

namespace Club
{
    public partial class Stats : Form
    {
        private int _eId;
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runningClubDataSet.Club". При необходимости она может быть перемещена или удалена.
            this.clubTableAdapter.Fill(this.runningClubDataSet.Club);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runningClubDataSet.Heat". При необходимости она может быть перемещена или удалена.
            this.heatTableAdapter1.Fill(this.runningClubDataSet.Heat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runningClubDataSet.Distance". При необходимости она может быть перемещена или удалена.
            this.distanceTableAdapter1.Fill(this.runningClubDataSet.Distance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "runningClubDataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter1.Fill(this.runningClubDataSet.Event);
            _eId = Convert.ToInt32(comboBox1.SelectedValue);
            try
            {
                label8.Text = heatParticipantTableAdapter1.CountEventParticipants(_eId).ToString();
                label9.Text = heatParticipantTableAdapter1.CountByGender("Male", _eId).ToString();
                label10.Text = heatParticipantTableAdapter1.CountByGender("Female", _eId).ToString();
                label11.Text = heatParticipantTableAdapter1.CountNotNullResults(_eId).ToString();
                label38.Text = heatTableAdapter1.GetDataBy4(_eId).First().Distance.ToString();
                label40.Text = heatTableAdapter1.DistancesCount(_eId).ToString();
                DistanceStatsFill();
                Club1TableAdapter club1TableAdapter = new Club1TableAdapter();
                mostActiveId.Text = club1TableAdapter.GetData().First().Id.ToString();
                leastActiveId.Text = club1TableAdapter.GetData().Last().Id.ToString();
                mostPopularId.Text = club1TableAdapter.GetDataBy().First().Name;
                leastPopularId.Text = club1TableAdapter.GetDataBy().Last().Name;
                mostPopularParticipants.Text = club1TableAdapter.GetDataBy().First().Participants.ToString();
                leastPopularParticipants.Text = club1TableAdapter.GetDataBy().Last().Participants.ToString();
                mostActiveName.Text = club1TableAdapter.GetData().First().Id.ToString();
                leastActiveName.Text = club1TableAdapter.GetData().Last().Id.ToString();
                mostPopularName.Text = club1TableAdapter.GetDataBy().First().Name;
                leastPopularName.Text = club1TableAdapter.GetDataBy().Last().Name;
                mostActiveResults.Text = club1TableAdapter.GetData().First().Results.ToString();
                leastActiveResults.Text = club1TableAdapter.GetData().Last().Results.ToString();
                Coach1TableAdapter coach1TableAdapter = new Coach1TableAdapter();
                mostPopularCoachId.Text = coach1TableAdapter.GetData().First().Id.ToString();
                mostPopularCoachStudents.Text = coach1TableAdapter.GetData().First().Participants.ToString();
                mostPopularCoachName.Text = coach1TableAdapter.GetData().First().Name;
                leastPopularCoachId.Text = coach1TableAdapter.GetData().Last().Id.ToString();
                leastPopularCoachStudents.Text = coach1TableAdapter.GetData().Last().Participants.ToString();
                leastPopularCoachName.Text = coach1TableAdapter.GetData().Last().Name;
                mostActiveCoachId.Text = coach1TableAdapter.GetDataBy().First().Id.ToString();
                mostActiveCoachResults.Text = coach1TableAdapter.GetDataBy().First().Results.ToString();
                mostActiveCoachName.Text = coach1TableAdapter.GetDataBy().First().Name;
                leastActiveCoachId.Text = coach1TableAdapter.GetDataBy().Last().Id.ToString();
                leastActiveCoachResults.Text = coach1TableAdapter.GetDataBy().Last().Results.ToString();
                leastActiveCoachName.Text = coach1TableAdapter.GetDataBy().Last().Name;


            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (StrongTypingException ex)
            {
                mostActiveResults.Text = "0";
                leastActiveResults.Text = "0";
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            _eId = Convert.ToInt32(comboBox1.SelectedValue);
            try
            {
                label8.Text = heatParticipantTableAdapter1.CountEventParticipants(_eId).ToString();
                label9.Text = heatParticipantTableAdapter1.CountByGender("Male", _eId).ToString();
                label10.Text = heatParticipantTableAdapter1.CountByGender("Female", _eId).ToString();
                label11.Text = heatParticipantTableAdapter1.CountNotNullResults(_eId).ToString();
                label38.Text = heatTableAdapter1.GetDataBy4(_eId).First().Distance.ToString();
                label40.Text = heatTableAdapter1.DistancesCount(_eId).ToString();
            }
            catch (InvalidOperationException ex)
            {
                label38.Text = "0";
                label9.Text = "0";
                label10.Text = "0";
                label11.Text = "0";
                label40.Text = "0";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void DistanceStatsFill()
        {
            _eId = Convert.ToInt32(comboBox2.SelectedValue);
            label35.Text = heatParticipantTableAdapter1.CountDistanceParticipants(1, _eId).ToString();
            label34.Text = heatParticipantTableAdapter1.CountDistanceParticipants(3,_eId).ToString();
            label33.Text = heatParticipantTableAdapter1.CountDistanceParticipants(5, _eId).ToString();
            label32.Text = heatParticipantTableAdapter1.CountDistanceParticipants(10, _eId).ToString();

            label31.Text = heatParticipantTableAdapter1.CountDistanceParticipants(21, _eId).ToString();
            label30.Text = heatParticipantTableAdapter1.CountDistanceParticipants(42, _eId).ToString();
            label29.Text = heatParticipantTableAdapter1.CountDistanceParticipants(60, _eId).ToString();
            label28.Text = heatParticipantTableAdapter1.CountDistanceParticipants(100, _eId).ToString();

            label27.Text = heatParticipantTableAdapter1.CountDistanceParticipants(200, _eId).ToString();
            label26.Text = heatParticipantTableAdapter1.CountDistanceParticipants(400, _eId).ToString();
            label25.Text = heatParticipantTableAdapter1.CountDistanceParticipants(800, _eId).ToString();
            label24.Text = heatParticipantTableAdapter1.CountDistanceParticipants(1500, _eId).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DistanceStatsFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }
    }
}
