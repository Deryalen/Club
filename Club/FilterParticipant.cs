using System;
using System.Windows.Forms;

namespace Club
{
    public partial class FilterParticipant : Form
    {
        public string Result;
        public FilterParticipant()
        {
            InitializeComponent();
        }

        private void Query()
        {
            int genderCounter = 0;
            bool genderBool = false;
            string query = "(";

            foreach (Control c in Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    switch (c.Text)
                    {
                        case "Male":
                            QueryEvaluator(ref genderCounter, ref query, "Gender='male'", ref genderBool);
                            break;
                        case "Female":
                            QueryEvaluator(ref genderCounter, ref query, "Gender='female'", ref genderBool);
                            break;
                    }
                }
            }

            query += ")";
            Result = query;
            if (genderCounter == 0) Result = string.Empty;
        }

        private static void QueryEvaluator(ref int counter, ref string filterString, string toAdd, ref bool currentBool)
        {
            if (counter >= 1)
            {
                filterString += " OR ";
            }
            counter++;
            filterString += toAdd;
            currentBool = true;
        }

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            Query();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FilterParticipant_Load(object sender, EventArgs e)
        {

        }
    }
}
