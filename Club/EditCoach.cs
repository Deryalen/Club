using System;
using System.Windows.Forms;

namespace Club
{
    public partial class EditCoach : Form
    {
        private readonly int _id;
        private readonly bool _edit;

        public EditCoach()
        {
            InitializeComponent();
            _edit = false;
        }

        public EditCoach(int id, string name, int club, string specialization) : this()
        {
            _edit = true;
            _id = id;
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            clubComboBox.Text = club.ToString();
            specializationTextBox.Text = specialization;
            if (specialization == "") noSpecializationCheckBox.Checked = true;
        }

        private void EditCoach_Load(object sender, EventArgs e)
        {
            runningClubDataSet.EnforceConstraints = false;
            coachTableAdapter.Fill(runningClubDataSet.Coach);
            clubTableAdapter.Fill(runningClubDataSet.Club);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (noSpecializationCheckBox.Checked || specializationTextBox.Text == "")
                {
                    if (_edit)
                    {
                        coachTableAdapter.UpdateQuery(_id, nameTextBox.Text, Convert.ToInt32(clubComboBox.SelectedValue),
                            "");
                    }
                    else
                    {
                        coachTableAdapter.UpdateQuery(Convert.ToInt32(idTextBox.Text), nameTextBox.Text,
                            Convert.ToInt32(clubComboBox.SelectedValue),
                            "");
                    }
                }
                else if (!noSpecializationCheckBox.Checked && specializationTextBox.Text != "")
                {
                    if (_edit)
                    {
                        coachTableAdapter.UpdateQuery(_id, nameTextBox.Text, Convert.ToInt32(clubComboBox.SelectedValue),
                            specializationTextBox.Text);
                    }
                    else
                    {
                        coachTableAdapter.UpdateQuery(Convert.ToInt32(idTextBox.Text), nameTextBox.Text,
                            Convert.ToInt32(clubComboBox.SelectedValue),
                            specializationTextBox.Text);
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void noSpecializationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            specializationTextBox.Enabled = !noSpecializationCheckBox.Checked;
        }
    }
}
