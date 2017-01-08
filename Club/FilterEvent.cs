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
    public partial class FilterEvent : Form
    {
        public string Result;

        public FilterEvent()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Query();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Query()
        {
            int levelCounter = 0;
            int typeCounter = 0;
            bool levelBool = false;
            bool typeBool = false;
            string query = "(";

            foreach (Control c in Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    switch (c.Text)
                    {
                        case "I":
                            QueryEvaluator(ref levelCounter, ref query, "Level=1",
                                ref levelBool,
                                ref typeBool);
                            break;
                        case "II":
                            QueryEvaluator(ref levelCounter, ref query, "Level=2",
                                ref levelBool,
                                ref typeBool);
                            break;
                        case "III":
                            QueryEvaluator(ref levelCounter, ref query, "Level=3",
                                ref levelBool,
                                ref typeBool);
                            break;
                        case "IV":
                            QueryEvaluator(ref levelCounter, ref query, "Level=4", ref levelBool,
                                ref typeBool);
                            break;
                        case "Championship":
                            QueryEvaluator(ref typeCounter, ref query, "Type='Чемпионат'",
                                ref typeBool,
                                ref levelBool);
                            break;
                        case "Cup":
                            QueryEvaluator(ref typeCounter, ref query, "Type='Кубок'", ref typeBool,
                                ref levelBool);
                            break;
                        case "Run":
                            QueryEvaluator(ref typeCounter, ref query, "Type='Пробег'", ref typeBool,
                                ref levelBool);
                            break;
                        case "Marathon":
                            QueryEvaluator(ref typeCounter, ref query, "Type='Марафон'", ref typeBool, ref levelBool);
                            break;
                    }
            }
            query += ")";
            Result = query;
            if (levelCounter == 0 && typeCounter == 0) Result = string.Empty;
        }

        private void QueryEvaluator(ref int counter, ref string filterString, string toAdd, ref bool currentBool, ref bool nextBool)
        {
            if (nextBool && counter == 0)
            {
                filterString += ") AND (";
            }
            if (counter >= 1)
            {
                filterString += " OR ";
            }
            counter ++;
            filterString += toAdd;
            currentBool = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
