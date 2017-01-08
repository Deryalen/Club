using System;
using System.Linq;
using System.Windows.Forms;

namespace Club
{
    public partial class RegisterForm : Form
    {
        private int _pId;
        private int _eId;
        private int _hId;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            eventTableAdapter.Fill(runningClubDataSet.Event);
            participantTableAdapter.Fill(runningClubDataSet.Participant);
            heatTableAdapter.FillByEvent(runningClubDataSet.Heat, Convert.ToInt32(eventComboBox.SelectedValue));
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            heatTableAdapter.FillByEvent(runningClubDataSet.Heat, Convert.ToInt32(eventComboBox.SelectedValue));
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                _eId = Convert.ToInt32(eventComboBox.SelectedValue);
                _pId = Convert.ToInt32(participantComboBox.SelectedValue);
                _hId = Convert.ToInt32(heatComboBox.SelectedValue);
                if (heatParticipantTableAdapter1.GetDataBy51(_hId, _eId).Count < 8)
                {
                    heatParticipantTableAdapter1.Insert(_hId, _eId, _pId, null);
                    MessageBox.Show(@"Successfully registered");
                }
                else
                {
                    MessageBox.Show(@"This heat is filled. Choose another one");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
