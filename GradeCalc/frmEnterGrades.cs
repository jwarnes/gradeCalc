using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradeCalc
{
    public partial class frmEnterGrades : Form
    {
        #region Fields
        private List<Grade> grades;
        private GradeType type;
        private double weight;
        #endregion

        #region Construct and Load
        public frmEnterGrades()
        {
            InitializeComponent();
            grades = new List<Grade>();
        }

        private void frmEnterGrades_Load(object sender, EventArgs e)
        {
            btnTestType.AutoCheck = false;
            lblFinalGrade.Text = "";
        }
        #endregion

        #region Ui Events and helper methods
        private void clearButtons()
        {
            btnTestType.Checked = false;
            btnLabType.Checked = false;
            btnDLType.Checked = false;
        }

        private void btnEnterGrade_Click(object sender, EventArgs e)
        {
            Grade g = new Grade(Convert.ToDouble(txtGrade.Text), weight, type);
            grades.Add(g);
            txtGrade.Clear();
            refreshGradesList();
            txtGrade.Focus();
        }

        private void btnTestType_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnTestType.Checked = true;
            type = GradeType.Test;
            weight = 0.4;
            refreshGradesList();
            txtGrade.Focus();
        }

        private void btnLabType_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnLabType.Checked = true;
            type = GradeType.Lab;
            weight = 0.4;
            refreshGradesList();
            txtGrade.Focus();
        }

        private void btnDLType_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnDLType.Checked = true;
            type = GradeType.DL;
            weight = 0.2;
            refreshGradesList();
            txtGrade.Focus();
        }

        private void btnCalcFinal_Click(object sender, EventArgs e)
        {
            double final =
                (CalculateGrade(GradeType.Test) * Weight(GradeType.Test)) + (CalculateGrade(GradeType.Lab) * Weight(GradeType.Lab))
                + (CalculateGrade(GradeType.DL) * Weight(GradeType.DL));
            lblFinalGrade.Text = "Final Grade: " + Math.Round(final, 1).ToString() + " (" + Validator.GetLetter(final) + ")";
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {
            btnEnterGrade.Enabled = (txtGrade.Text != "" && Validator.isDouble(txtGrade) && Validator.inGradeRange(Convert.ToDouble(txtGrade.Text)));
        }
        #endregion

        public void refreshGradesList()
        {

            if (grades.Count < 1)
                return;

            gradeList.Items.Clear();

            foreach (Grade g in grades)
            {
                if (g.Type == type)
                    gradeList.Items.Add(g.GradeValue);
            }
            DisplaySectionGrade();
            IsFinalReady();
            
        }

        private double CalculateGrade(GradeType type)
        {
            double total = 0;
            double count = 0;
            foreach (Grade g in grades)
            {
                if (g.Type == type)
                {
                    total += g.GradeValue;
                    count++;
                }
            }

            return (count > 0) ? total / count : 0;
        }

        private void DisplaySectionGrade()
        {
            txtAvgGrade.Text = Math.Round(CalculateGrade(type), 1).ToString();
            txtWeighted.Text = Math.Round((CalculateGrade(type) * Weight(type)), 1).ToString();
        }

        private double Weight(GradeType type)
        {
            double[] weights = { 0.4, 0.4, 0.2 };
            return weights[(int)type];
        }

        private void IsFinalReady()
        {
            int[] count = { 0, 0, 0 };
            foreach (Grade g in grades)
            {
                count[(int)g.Type]++;
            }

            btnCalcFinal.Enabled = (count[0] > 0 && count[1] > 0 && count[2] > 0);
        }

     
    }
}
