using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Club.RunningClubDataSetTableAdapters;

namespace Club
{
    public partial class TrainingPlan : Form
    {
        public TrainingPlan()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SqlCommand sql1 = new SqlCommand("SELECT COUNT(dbo.Participant.Id) FROM dbo.Participant WHERE Gender='male'");
        }

        private void TrainingPlan_Load(object sender, EventArgs e)
        {

        }


        /*public Dictionary<int, string> GetTrainings(int? participantId)
        {

        }*/
    }
}
