using System;
using System.Linq;
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
            try
            {
                idTextBox.Text = (coachTableAdapter.GetData().Last().Id + 1).ToString();
            }
            catch (InvalidOperationException ex)
            {
                idTextBox.Text = "0";
            }
            idTextBox.Enabled = false;
        }

        public EditCoach(int id, string name, int club, string specialization) : this()
        {
            _edit = true;
            _id = id;
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            clubComboBox.Text = club.ToString();
            if (specialization == "") noSpecializationCheckBox.Checked = true;
        }

        private void EditCoach_Load(object sender, EventArgs e)
        {
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
                if (noSpecializationCheckBox.Checked)
                {
                    if (_edit)
                    {
                        coachTableAdapter.UpdateQuery(_id, nameTextBox.Text, Convert.ToInt32(clubComboBox.SelectedValue),
                            "");
                    }
                    else
                    {
                        coachTableAdapter.Insert(Convert.ToInt32(idTextBox.Text), nameTextBox.Text,
                            Convert.ToInt32(clubComboBox.SelectedValue),
                            "");
                    }
                }
                else if (!noSpecializationCheckBox.Checked && specializationComboBox.Text != "")
                {
                    if (_edit)
                    {
                        coachTableAdapter.UpdateQuery(_id, nameTextBox.Text, Convert.ToInt32(clubComboBox.SelectedValue),
                            specializationComboBox.SelectedItem.ToString());
                    }
                    else
                    {
                        coachTableAdapter.Insert(Convert.ToInt32(idTextBox.Text), nameTextBox.Text,
                            Convert.ToInt32(clubComboBox.SelectedValue),
                            specializationComboBox.Text);
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
            specializationComboBox.Enabled = !noSpecializationCheckBox.Checked;
        }
    }
}
