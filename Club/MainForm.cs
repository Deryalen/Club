using System;
using System.Windows.Forms;

namespace Club
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clubTableAdapter1.Fill(runningClubDataSet.Club);
            coachTableAdapter1.Fill(runningClubDataSet.Coach);
            participantTableAdapter1.Fill(runningClubDataSet.Participant);
            sponsorTableAdapter1.Fill(runningClubDataSet.Sponsor);
            distanceTableAdapter1.Fill(runningClubDataSet.Distance);
            eventTableAdapter1.Fill(runningClubDataSet.Event);

            dataGridView1.DataSource = participantBindingSource;
            label1.Text = @"Participants";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = eventBindingSource;
            label1.Text = @"Events";
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = participantBindingSource;
            label1.Text = @"Participants";
        }

        private void coachesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coachBindingSource;
            label1.Text = @"Coaches";
        }

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clubBindingSource;
            label1.Text = @"Clubs";
        }

        private void sponsorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sponsorBindingSource;
            label1.Text = @"Sponsors";
        }

        private void distancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = distanceBindingSource;
            label1.Text = @"Distances";
        }

        private void UpdateDb()
        {
            participantTableAdapter1.Update(runningClubDataSet);
            coachTableAdapter1.Update(runningClubDataSet);
            clubTableAdapter1.Update(runningClubDataSet);
            distanceTableAdapter1.Update(runningClubDataSet);
            eventTableAdapter1.Update(runningClubDataSet);
            sponsorTableAdapter1.Update(runningClubDataSet);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateDb();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDb();
        }

        private void updateSelected_Click(object sender, EventArgs e)
        {
            var instance = new RunningClubDataSet.ParticipantDataTable();
            participantTableAdapter1.FillBy(instance, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object row = instance.Rows[0].ItemArray;
            bool edit = false;

            if (Convert.ToString(dataGridView1.SelectedRows[0].Cells[4]) != "")
            {
                var newItem = new EditParticipant(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                    Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value),
                    dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                newItem.ShowDialog();
                participantTableAdapter1.Fill(runningClubDataSet.Participant);
                runningClubDataSet.AcceptChanges();
                edit = true;
            }
            else
            {
                var newItem = new EditParticipant(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                    Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value),
                    Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value),
                    Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value),
                    "");
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var edit = new EditParticipant();
            edit.ShowDialog();
            participantTableAdapter1.Fill(runningClubDataSet.Participant);
            runningClubDataSet.AcceptChanges();
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void DeleteItem()
        {
            if (label1.Text == @"Participants")
            {
                participantTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                participantTableAdapter1.Fill(runningClubDataSet.Participant);
                runningClubDataSet.AcceptChanges();
            }
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
