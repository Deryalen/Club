using System;
using System.Globalization;
using System.Windows.Forms;

namespace Club
{
    public partial class EditParticipant : Form
    {
        private readonly int _id;
        private readonly bool _edit;

        public EditParticipant()
        {
            InitializeComponent();
            _edit = false;
        }

        public EditParticipant(int id, string name, string gender, DateTime dateOfBirth, string coach) : this()
        {
            _edit = true;
            _id = id;
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            genderComboBox.Text = gender;
            dateOfBirthDateTimePicker.Value = dateOfBirth;
            coachComboBox.SelectedValue = Convert.ToInt32(coach);
            if (coach == "") noCoachCheckBox.Checked = true;
        }

        private void EditParticipant_Load(object sender, EventArgs e)
        {
            coachTableAdapter.Fill(runningClubDataSet.Coach);
            participantTableAdapter.Fill(runningClubDataSet.Participant);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (noCoachCheckBox.Checked || coachComboBox.Text == "")
                {
                    if (_edit)
                    {
                        participantTableAdapter.UpdateQuery(_id,
                            nameTextBox.Text,
                            genderComboBox.Text,
                            dateOfBirthDateTimePicker.Value.ToString(),
                            null);
                    }
                    else
                    {
                        participantTableAdapter.Insert(Convert.ToInt32(idTextBox.Text), nameTextBox.Text,
                            genderComboBox.Text, dateOfBirthDateTimePicker.Value, null);
                    }
                }
                else if (!noCoachCheckBox.Checked && noCoachCheckBox.Text != "")
                {
                    if (_edit)
                    {
                        participantTableAdapter.UpdateQuery(_id,
                            nameTextBox.Text,
                            genderComboBox.Text,
                            dateOfBirthDateTimePicker.Value.ToString(),
                            Convert.ToInt32(coachComboBox.SelectedValue));
                       }
                    else
                    {
                        participantTableAdapter.Insert(Convert.ToInt32(idTextBox.Text), nameTextBox.Text,
                            genderComboBox.Text, dateOfBirthDateTimePicker.Value, Convert.ToInt32(coachComboBox.SelectedValue));
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }         
        }

        private void noCoachCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            coachComboBox.Enabled = !noCoachCheckBox.Checked;
        }
    }
}
