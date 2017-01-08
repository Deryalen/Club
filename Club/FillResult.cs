using System;
using System.Linq;
using System.Windows.Forms;

namespace Club
{
    public partial class FillResult : Form
    {
        private readonly int _eId;
        private readonly int _hId;
        private readonly int _pId;
        private readonly string _result;
        private TimeSpan _resSpan;
        private readonly string[] resString;
        private readonly bool _edit;
        public FillResult()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillResult_Load(object sender, EventArgs e)
        {
            eventName.Text = eventTableAdapter1.GetDataBy1(_eId).First().Name;
            heatId.Text = _hId.ToString();
            participantId.Text = _pId.ToString();
            participantName.Text = participantTableAdapter1.GetDataBy3(_pId).First().Name;
        }

        public FillResult(int eId, int hId, int pId, string result):this()
        {
            _eId = eId;
            _hId = hId;
            _pId = pId;
            _result = result;
            if (result != "")
            {
                resString = _result.Split(':');
                _resSpan = new TimeSpan(Convert.ToInt32(resString[0]), Convert.ToInt32(resString[1]),
                    Convert.ToInt32(resString[2]));
                _edit = true;
                maskedTextBox1.Text = _resSpan.Hours.ToString();
                maskedTextBox2.Text = _resSpan.Minutes.ToString();
                maskedTextBox3.Text = _resSpan.Seconds.ToString();
            }
            else
            {
                _edit = false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && maskedTextBox3.Text != "")
            {
                TimeSpan result = new TimeSpan(Convert.ToInt32(maskedTextBox1.Text),
                    Convert.ToInt32(maskedTextBox2.Text), Convert.ToInt32(maskedTextBox3.Text));
                heatParticipantTableAdapter1.UpdateQuery(result.ToString(), _hId, _eId, _pId);
            }
            else
            {
                MessageBox.Show(@"Enter all values");
            }
            Close();
        }
    }
}
