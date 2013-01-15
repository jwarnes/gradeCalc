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

        public frmEnterGrades()
        {
            InitializeComponent();
            grades = new List<Grade>();
        }

        private void frmEnterGrades_Load(object sender, EventArgs e)
        {
            btnTestType.AutoCheck = false;
        }

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
        }

        private void btnLabType_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnLabType.Checked = true;
            type = GradeType.Lab;
            weight = 0.4;
            refreshGradesList();
        }

        private void btnDLType_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnDLType.Checked = true;
            type = GradeType.DL;
            weight = 0.2;
            refreshGradesList();
        }

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
            
        }

    }
}
