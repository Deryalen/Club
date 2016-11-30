using System;
using System.Windows.Forms;

namespace Club
{
    public partial class EditSponsor : Form
    {
        private readonly int _id;
        private readonly bool _edit;

        public EditSponsor()
        {
            InitializeComponent();
            _edit = false;
        }

        public EditSponsor(int id, string name, decimal funds) :this()
        {
            _edit = true;
            _id = id;
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            fundsTextBox.Text = funds.ToString();
        }

        private void EditSponsor_Load(object sender, EventArgs e)
        {
            sponsorTableAdapter.Fill(runningClubDataSet.Sponsor);
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
                    sponsorTableAdapter.UpdateQuery(_id,
                        nameTextBox.Text,
                        Convert.ToDecimal(fundsTextBox.Text));
                }
                else
                {
                    sponsorTableAdapter.Insert(Convert.ToInt32(idTextBox.Text),
                        nameTextBox.Text,
                        Convert.ToDecimal(fundsTextBox));
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
