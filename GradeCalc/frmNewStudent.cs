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
    public partial class frmNewStudent : Form
    {
        public frmStudentList ParentFrm { get; set; }
        private int editIndex = -1;
        
        public frmNewStudent(frmStudentList parent)
        {
            InitializeComponent();
            ParentFrm = parent;
            
        }
        public frmNewStudent(frmStudentList parent, int editIndex)
        {
            InitializeComponent();
            ParentFrm = parent;
            this.editIndex = editIndex;
            LoadStudent(parent.GetStudent(editIndex));
        }

        private void control_TextUpdate(object sender, EventArgs e)
        {
            //validation
            btnSave.Enabled = (cbCourse.Text != "" && cbName.Text != "" && cbTerm.Text != "" && cbYear.Text != "" && txtGrade.Text != "" 
                && Validator.isDouble(txtGrade));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student(cbName.Text, cbCourse.Text, Convert.ToInt16(cbYear.Text), cbTerm.Text, Convert.ToDouble(txtGrade.Text));

            if (editIndex == -1)
                ParentFrm.AddStudent(student);
            else
                ParentFrm.EditStudent(student, editIndex);

            Close();
        }

        public void SetGrade(double grade)
        {
            txtGrade.Text = grade.ToString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            new frmEnterGrades(this).ShowDialog();
        }

        private void LoadStudent(Student s)
        {
            cbName.Text = s.Name;
            cbCourse.Text = s.Course;
            cbYear.Text = s.Year.ToString();
            cbTerm.Text = s.Term;
            txtGrade.Text = s.GradeValue.ToString();
        }

        private void LoadStudentList()
        {
            foreach (var s in ParentFrm.Students)
            {
                cbName.Items.Add(s.Name);
            }
        }


    }
}
