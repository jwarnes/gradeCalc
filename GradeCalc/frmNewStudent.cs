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
        private int editIndex;
        
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
        }

        private void control_TextUpdate(object sender, EventArgs e)
        {
            //validation
            btnSave.Enabled = (cbCourse.Text != "" && cbName.Text != "" && cbTerm.Text != "" && cbYear.Text != "" && txtGrade.Text != "" 
                && Validator.isDouble(txtGrade));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ParentFrm.AddStudent(new Student(cbName.Text, cbCourse.Text, Convert.ToInt16(cbYear.Text), cbTerm.Text, Convert.ToDouble(txtGrade.Text)));
        }


    }
}
