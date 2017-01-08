using System;
using System.Windows.Forms;

namespace Club
{
    public partial class FilterCoach : Form
    {
        public string Result;
        public FilterCoach()
        {
            InitializeComponent();
        }

        private void Query()
        {
            int specCounter = 0;
            bool specBool = false;
            string query = "(";

            foreach (Control c in Controls)
            {
                if ((c is CheckBox) && ((CheckBox) c).Checked)
                {
                    switch (c.Text)
                    {
                        case "Sprint":
                            QueryEvaluator(ref specCounter, ref query, "Specialization = 'Sprint'", ref specBool);
                            break;
                        case "Middle":
                            QueryEvaluator(ref specCounter, ref query, "Specialization = 'Middle'", ref specBool);
                            break;
                        case "Long":
                            QueryEvaluator(ref specCounter, ref query, "Specialization = 'Long'", ref specBool);
                            break;
                        case "Long Jump":
                            QueryEvaluator(ref specCounter, ref query, "Specialization = 'Long Jump'", ref specBool);
                            break;
                        case "High Jump":
                            QueryEvaluator(ref specCounter, ref query, "Specialization = 'High Jump'", ref specBool);
                            break;
                        case "Pole Vault":
                            QueryEvaluator(ref specCounter, ref query, "Specialization = 'Pole Vault'", ref specBool);
                            break;

                    }
                }

            }
            query += ")";
            Result = query;
            if (specCounter == 0) Result = string.Empty;
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Query();
            DialogResult = DialogResult.OK;
            MessageBox.Show(Result);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
