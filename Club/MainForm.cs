using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            participantTableAdapter1.FillWithCoach(runningClubDataSet.Participant);
            distanceTableAdapter1.Fill(runningClubDataSet.Distance);
            eventTableAdapter1.Fill(runningClubDataSet.Event);

            dataGridView1.DataSource = participantBindingSource;
            label1.Text = @"Participants";
            
            dataGridView1.Columns[1].Width = 100;
            searchParticipantComboBox.Visible = true;
            searchClubComboBox.Visible = false;
            searchCoachComboBox.Visible = false;
            searchEventComboBox.Visible = false;
            searchParticipantComboBox.Enabled = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = eventBindingSource;
            label1.Text = @"Events";
            updateSelected.Enabled = true;
            deleteSelected.Enabled = true;
            filterButton.Enabled = true;
            searchParticipantComboBox.Visible = false;
            searchClubComboBox.Visible = false;
            searchCoachComboBox.Visible = false;
            searchEventComboBox.Visible = true;
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            participantTableAdapter1.FillWithCoach(runningClubDataSet.Participant);
            dataGridView1.DataSource = participantBindingSource;
            label1.Text = @"Participants";
            updateSelected.Enabled = true;
            deleteSelected.Enabled = true;
            filterButton.Enabled = true;

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 100;
            searchParticipantComboBox.Visible = true;
            searchClubComboBox.Visible = false;
            searchCoachComboBox.Visible = false;
            searchEventComboBox.Visible = false;
        }

        private void coachesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coachBindingSource;
            label1.Text = @"Coaches";
            updateSelected.Enabled = true;
            deleteSelected.Enabled = true;
            filterButton.Enabled = true;
            searchParticipantComboBox.Visible = false;
            searchClubComboBox.Visible = false;
            searchCoachComboBox.Visible = true;
            searchEventComboBox.Visible = false;
        }

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clubBindingSource;
            label1.Text = @"Clubs";
            updateSelected.Enabled = true;
            deleteSelected.Enabled = true;
            filterButton.Enabled = false;
            searchParticipantComboBox.Visible = false;
            searchClubComboBox.Visible = true;
            searchCoachComboBox.Visible = false;
            searchEventComboBox.Visible = false;
        }

        private void distancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = distanceBindingSource;
            label1.Text = @"Distances";
            updateSelected.Enabled = false;
            deleteSelected.Enabled = false;
            filterButton.Enabled = false;
        }

        private void UpdateDb()
        {
            participantTableAdapter1.Update(runningClubDataSet);
            coachTableAdapter1.Update(runningClubDataSet);
            clubTableAdapter1.Update(runningClubDataSet);
            distanceTableAdapter1.Update(runningClubDataSet);
            eventTableAdapter1.Update(runningClubDataSet);
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
            UpdateItem();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void AddItem()
        {
            if (label1.Text == @"Participants")
            {
                var edit = new EditParticipant();
                edit.ShowDialog();
                participantTableAdapter1.FillWithCoach(runningClubDataSet.Participant);
                runningClubDataSet.AcceptChanges();
            }
            else if (label1.Text == @"Coaches")
            {
                var edit = new EditCoach();
                edit.ShowDialog();
                coachTableAdapter1.Fill(runningClubDataSet.Coach);
                runningClubDataSet.AcceptChanges();
            }
            else if (label1.Text == @"Clubs")
            {
                var edit = new EditClub();
                edit.ShowDialog();
                clubTableAdapter1.Fill(runningClubDataSet.Club);
                runningClubDataSet.AcceptChanges();
            }
            else if (label1.Text == @"Events")
            {
                var edit = new EditEvent();
                edit.ShowDialog();
                eventTableAdapter1.Fill(runningClubDataSet.Event);
                runningClubDataSet.AcceptChanges();
            }
        }

        private void DeleteItem()
        {
            if (label1.Text == @"Participants")
            {
                participantTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                participantTableAdapter1.FillWithCoach(runningClubDataSet.Participant);
                runningClubDataSet.AcceptChanges();
            }
            else if (label1.Text == @"Coaches")
            {
                coachTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                coachTableAdapter1.Fill(runningClubDataSet.Coach);
                runningClubDataSet.AcceptChanges();
            }
            else if (label1.Text == @"Clubs")
            {
                clubTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                clubTableAdapter1.Fill(runningClubDataSet.Club);
                coachTableAdapter1.Fill(runningClubDataSet.Coach);
                runningClubDataSet.AcceptChanges();
            }
            else if (label1.Text == @"Events")
            {
                eventTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                eventTableAdapter1.Fill(runningClubDataSet.Event);
                runningClubDataSet.AcceptChanges();
            }
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void UpdateItem()
        {
            if (label1.Text == @"Participants")
            {
                var instance = new RunningClubDataSet.ParticipantDataTable();
                participantTableAdapter1.FillBy(instance, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                try
                {
                    object row = instance.Rows[0].ItemArray;
                }
                catch (IndexOutOfRangeException ex)
                {
                }
                bool edit = false;

                if (Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value) != "")
                {
                    var newItem = new EditParticipant(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                        dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                        dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                        Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value),
                        dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    newItem.ShowDialog();
                    participantTableAdapter1.FillWithCoach(runningClubDataSet.Participant);
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
                    newItem.ShowDialog();
                    participantTableAdapter1.FillWithCoach(runningClubDataSet.Participant);
                    runningClubDataSet.AcceptChanges();
                    edit = true;
                }
            }

            else if (label1.Text == @"Coaches")
            {
                var instance = new RunningClubDataSet.CoachDataTable();
                coachTableAdapter1.FillBy(instance, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object row = instance.Rows[0].ItemArray;
                bool edit = false;

                if (Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value) != "")
                {
                    var newItem = new EditCoach(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                        dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                        Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value),
                        dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    newItem.ShowDialog();
                    coachTableAdapter1.Fill(runningClubDataSet.Coach);
                    runningClubDataSet.AcceptChanges();
                    edit = true;
                }
                else
                {
                    var newItem = new EditCoach(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                     dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                     Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value),
                     "");
                    newItem.ShowDialog();
                    coachTableAdapter1.Fill(runningClubDataSet.Coach);
                    runningClubDataSet.AcceptChanges();
                    edit = true;
                }
            }

            else if (label1.Text == @"Clubs")
            {
                var instance = new RunningClubDataSet.ClubDataTable();
                clubTableAdapter1.FillBy(instance, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object row = instance.Rows[0].ItemArray;
                bool edit = false;

                var newItem = new EditClub(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value),
                    dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                newItem.ShowDialog();
                clubTableAdapter1.Fill(runningClubDataSet.Club);
                coachTableAdapter1.Fill(runningClubDataSet.Coach);
                runningClubDataSet.AcceptChanges();
                edit = true;
            }
            
            else if (label1.Text == @"Events")
            {
                var instance = new RunningClubDataSet.EventDataTable();
                eventTableAdapter1.FillBy(instance, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object row = instance.Rows[0].ItemArray;
                bool edit = false;

                var newItem = new EditEvent(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), 
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value),
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value),
                    dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                newItem.ShowDialog();
                eventTableAdapter1.Fill(runningClubDataSet.Event);
                runningClubDataSet.AcceptChanges();
                edit = true;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!advancedSearchCheckBox.Checked)
            {
                Search();
            }
            else
            {
                AdvancedSearch();
            }
        }

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (searchByComboBox.Text == "Date of birth")
            {
                searchTextBox.Visible = false;
                searchDateTimePicker.Visible = true;
            }
            else
            {
                searchTextBox.Visible = true;
                searchDateTimePicker.Visible = false;
            }*/
        }

        private void Search()
        {
            if (searchTextBox.Text != "")
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                        {
                            dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[j].Selected = false;
                        }

                        else
                        {
                            dataGridView1.Rows[j].Cells[i].Style.BackColor = default(Color);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        dataGridView1.Rows[j].Cells[i].Style.BackColor = default(Color);

                    }
                }
            }
        }

        private void AdvancedSearch()
        {
            if (searchTextBox.Text != "")
            {
                if (label1.Text == @"Participants")
                {
                    SearchParticipant();
                }
                else if (label1.Text == @"Coaches")
                {
                    SearchCoach();
                }
                else if (label1.Text == @"Clubs")
                {
                    SearchClub();
                }
                else if (label1.Text == @"Events")
                {
                    SearchEvent();
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        dataGridView1.Rows[j].Cells[i].Style.BackColor = default(Color);
                    }
                }
            }
        }

        private void SearchParticipant()
        {
            switch (searchParticipantComboBox.Text)
            {
                case "Id":
                    Regex x = new Regex(@"^[0-9]");
                    if (x.IsMatch(searchTextBox.Text))
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Aquamarine;
                                dataGridView1.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells[0].Style.BackColor = default(Color);
                            }
                        }
                    }
                    break;
                case "Name":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = default(Color);
                        }
                    }
                    break;
                case "Coach":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[5].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                        {
                            dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[5].Style.BackColor = default(Color);
                        }
                    }
                    break;
                case "Date of birth":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                        {
                            dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[3].Style.BackColor = default(Color);
                        }
                    }
                    break;
            }
        }

        private void SearchCoach()
        {
            Regex x;
            switch (searchCoachComboBox.Text)
            {
                case "Id":
                    x = new Regex(@"^[0-9]");
                    if (x.IsMatch(searchTextBox.Text))
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Aquamarine;
                                dataGridView1.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells[0].Style.BackColor = default(Color);
                            }
                        }
                    }
                    break;
                case "Name":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = default(Color);
                        }
                    }
                    break;
                case "Club":
                    x = new Regex(@"^[0-9]");
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[2].Style.BackColor = default(Color);
                        }
                    }
                    break;
                case "Specialization":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[3].Style.BackColor = default(Color);
                        }
                    }
                    break;
            }
        }

        private void SearchClub()
        {
            Regex x;
            switch (searchClubComboBox.Text)
            {
                case "Id":
                    x = new Regex(@"^[0-9]");
                    if (x.IsMatch(searchTextBox.Text))
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Aquamarine;
                                dataGridView1.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells[0].Style.BackColor = default(Color);
                            }
                        }
                    }
                    break;
                case "Name":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = default(Color);
                        }
                    }
                    break;
                case "Foundation date":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[2].Style.BackColor = default(Color);
                        }
                    }
                    break;
                case "City":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[3].Style.BackColor = default(Color);
                        }
                    }
                    break;
            }

        }

        private void SearchEvent()
        {
            Regex x;
            switch (searchEventComboBox.Text)
            {
                case "Id":
                    x = new Regex(@"^[0-9]");
                    if (x.IsMatch(searchTextBox.Text))
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Aquamarine;
                                dataGridView1.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells[0].Style.BackColor = default(Color);
                            }
                        }
                    }
                    break;
                case "Name":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = default(Color);
                        }
                    }
                    break;
                case "Date":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[2].Style.BackColor = default(Color);
                        }
                    }
                    break;
                case "Level":
                    x = new Regex(@"^[0-9]");
                    if (x.IsMatch(searchTextBox.Text))
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[3].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Aquamarine;
                                dataGridView1.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells[3].Style.BackColor = default(Color);
                            }
                        }
                    }
                    break;
                case "Type":
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[4].Value.ToString().Contains(searchTextBox.Text))
                        {
                            dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Aquamarine;
                            dataGridView1.Rows[i].Selected = false;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[4].Style.BackColor = default(Color);
                        }
                    }
                    break;
            }

        }

        private void advancedSearchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchEventComboBox.Enabled = searchParticipantComboBox.Enabled = searchClubComboBox.Enabled = searchCoachComboBox.Enabled =  advancedSearchCheckBox.Checked;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (label1.Text == @"Participants")
            {
                FilterParticipant inst = new FilterParticipant();
                inst.ShowDialog();
                if (inst.DialogResult == DialogResult.OK) participantBindingSource.Filter = inst.Result;
            }
            else if (label1.Text == @"Events")
            {
                FilterEvent inst = new FilterEvent();
                inst.ShowDialog();
                if (inst.DialogResult == DialogResult.OK) eventBindingSource.Filter = inst.Result;
            }
            else if (label1.Text == @"Coaches")
            {
                FilterCoach inst = new FilterCoach();
                inst.ShowDialog();
                if (inst.DialogResult == DialogResult.OK) coachBindingSource.Filter = inst.Result;
            }
        }

        private void getStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stats st = new Stats();
            st.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label1.Text == @"Events")
            {
                var instance = new RunningClubDataSet.EventDataTable();
                eventTableAdapter1.FillBy(instance, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object row = instance.Rows[0].ItemArray;
                bool edit = false;

                var newItem = new EditEvent(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value),
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value),
                    dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                newItem.ShowDialog();
                eventTableAdapter1.Fill(runningClubDataSet.Event);
                runningClubDataSet.AcceptChanges();
                edit = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void addHeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inst = new AddHeatsToEvent();
            inst.ShowDialog();
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inst = new Report();
            inst.ShowDialog();
        }

        private void getClubReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inst = new ClubReport();
            inst.ShowDialog();
        }

        private void getTrainingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inst = new TrainingPlan();
            inst.ShowDialog();
        }
    }
}