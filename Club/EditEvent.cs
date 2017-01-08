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

        public EditEvent(int id, string name, DateTime date, int level, string type) : this()
        {
            _edit = true;
            _id = id;
            idTextBox.Text = id.ToString();
            idTextBox.Enabled = true;
            nameTextBox.Text = name;
            dateDateTimePicker.Value = date;
            levelComboBox.Text = level.ToString();
            typeComboBox.Text = type;
            dataGridView1.DataSource = dataTable2TableAdapter1.GetData(_id);
        }

        private void EditEvent_Load(object sender, EventArgs e)
        {
            eventTableAdapter.Fill(runningClubDataSet.Event);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_edit)
                    {
                        eventTableAdapter.UpdateQuery(_id, nameTextBox.Text, dateDateTimePicker.Value.ToString(),
                            Convert.ToInt32(levelComboBox.Text), typeComboBox.Text);
                    }
                else
                {
                    eventTableAdapter.Insert(Convert.ToInt32(idTextBox.Text), nameTextBox.Text,
                            dateDateTimePicker.Value,
                            Convert.ToInt32(levelComboBox.Text), typeComboBox.Text); 
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var inst = new FillResult(_id, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value), dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            inst.ShowDialog();
        }
    }
}
