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
    public partial class frmStudentList : Form
    {
        private List<Student> students;

        public frmStudentList()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmNewStudent(this).ShowDialog();
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
            RefreshStudentList();
        }

        public void RemoveStudent(int i)
        {
            students.RemoveAt(i);
            RefreshStudentList();
        }

        public void EditStudent(Student s, int i)
        {
            students[i] = s;
            RefreshStudentList();
        }

        public void LoadFromTxt(string path = @"StudGradesDB.txt")
        {
        }

        public void RefreshStudentList()
        {
            lbStudents.Items.Clear();
            foreach (Student s in students)
            {
                lbStudents.Items.Add(s.ToString());
            }
        }
    }
}
