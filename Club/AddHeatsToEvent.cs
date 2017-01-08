using System;
using System.Linq;
using System.Windows.Forms;

namespace Club
{
    public partial class AddHeatsToEvent : Form
    {
        private int eId;
        public AddHeatsToEvent()
        {
            InitializeComponent();
        }

        private void AddHeatsToEvent_Load(object sender, EventArgs e)
        {
            eventTableAdapter1.Fill(runningClubDataSet.Event);
            distanceTableAdapter1.Fill(runningClubDataSet.Distance);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            eId = Convert.ToInt32(eventComboBox.SelectedValue);
            int lastId;
            try
            {
                heatTableAdapter1.FillByEvent(runningClubDataSet.Heat, eId);
                lastId = heatTableAdapter1.GetDataBy4(eId).Last().Id;
            }
            catch (InvalidOperationException ex)
            {
                lastId = 0;
            }

            for (int i = lastId + 1; i <= Convert.ToInt32(numberOfHeats.Text) + lastId; i++)
            {
                heatTableAdapter1.Insert(i, eId, Convert.ToInt32(distanceComboBox.SelectedValue));
            }
            MessageBox.Show(@"Successfully added");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
