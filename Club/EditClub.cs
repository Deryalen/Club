using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club
{
    public partial class EditClub : Form
    {
        private readonly int _id;
        private readonly bool _edit;

        public EditClub()
        {
            InitializeComponent();
            _edit = false;
        }

        public EditClub(int id, string name, DateTime foundationDate, string city) : this()
        {
            _edit = true;
            _id = id;
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            foundationDateDateTimePicker.Value = foundationDate;
            cityTextBox.Text = city;
        }

        private void EditClub_Load(object sender, EventArgs e)
        {
            runningClubDataSet.EnforceConstraints = false;
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
                if (_edit)
                {
                    clubTableAdapter.UpdateQuery(_id, nameTextBox.Text, foundationDateDateTimePicker.Value.ToString(),
                        cityTextBox.Text);
                }
                else
                {
                    clubTableAdapter.Insert(Convert.ToInt32(idTextBox.Text),
                        nameTextBox.Text,
                        foundationDateDateTimePicker.Value,
                        cityTextBox.Text);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
