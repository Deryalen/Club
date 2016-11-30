using System;
using System.Linq;
using System.Windows.Forms;

namespace Club
{
    public partial class EditEvent : Form
    {
        private readonly int _id;
        private readonly bool _edit;

        public EditEvent()
        {
            InitializeComponent();
            _edit = false;
            idTextBox.Text = (eventTableAdapter.GetData().Last().Id + 1).ToString();
            idTextBox.Enabled = false;
        }

        public EditEvent(int id, string name, DateTime date, int level, string type, int sponsor) : this()
        {
            _edit = true;
            _id = id;
            idTextBox.Text = id.ToString();
            idTextBox.Enabled = true;
            nameTextBox.Text = name;
            dateDateTimePicker.Value = date;
            levelComboBox.Text = level.ToString();
            typeComboBox.Text = type;
            sponsorComboBox.Text = sponsor.ToString();
            if (sponsor.ToString() == "") noSponsorCheckBox.Checked = true;
        }

        private void EditEvent_Load(object sender, EventArgs e)
        {
            sponsorTableAdapter.Fill(runningClubDataSet.Sponsor);
            eventTableAdapter.Fill(runningClubDataSet.Event);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (noSponsorCheckBox.Checked)
                {
                    if (_edit)
                    {
                        eventTableAdapter.UpdateQuery(_id, nameTextBox.Text, dateDateTimePicker.Value.ToString(),
                            Convert.ToInt32(levelComboBox.SelectedValue), typeComboBox.SelectedText, null);
                    }
                    else
                    {
                        eventTableAdapter.UpdateQuery(Convert.ToInt32(idTextBox.Text), nameTextBox.Text,
                            dateDateTimePicker.Value.ToString(),
                            Convert.ToInt32(levelComboBox.SelectedValue), typeComboBox.SelectedText, null);
                    }
                }
                else
                {
                    if (_edit)
                    {
                        eventTableAdapter.UpdateQuery(_id, nameTextBox.Text, dateDateTimePicker.Value.ToString(),
                            Convert.ToInt32(levelComboBox.SelectedValue), typeComboBox.SelectedText,
                            Convert.ToInt32(sponsorComboBox.SelectedValue));
                    }
                    else
                    {
                        eventTableAdapter.UpdateQuery(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, dateDateTimePicker.Value.ToString(),
                            Convert.ToInt32(levelComboBox.SelectedValue), typeComboBox.SelectedText, Convert.ToInt32(sponsorComboBox.SelectedValue));
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void noSponsorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sponsorComboBox.Enabled = !noSponsorCheckBox.Checked;
        }
    }
}
