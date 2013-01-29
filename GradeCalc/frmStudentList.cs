using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GradeCalc
{
    public partial class frmStudentList : Form
    {
        private List<Student> students;
        public List<Student> Students
        {
            get { return students; }
        }

        public frmStudentList()
        {
            InitializeComponent();
            students = new List<Student>();
            LoadFromTxt();
        }

        #region Student List 

        public void AddStudent(Student s)
        {
            students.Add(s);
            RefreshStudentList();
            SaveToText();
        }

        public void RemoveStudent(int i)
        {
            students.RemoveAt(i);
            RefreshStudentList();
            SaveToText();
        }

        public void EditStudent(Student s, int i)
        {
            students[i] = s;
            RefreshStudentList();
            SaveToText();
        }

        public void RefreshStudentList()
        {
            lbStudents.Items.Clear();
            foreach (Student s in students)
            {
                lbStudents.Items.Add(s.ToString());
            }
            btnEdit.Enabled = (students.Count > 0 && lbStudents.SelectedIndex != -1);
            btnRemove.Enabled = (students.Count > 0 && lbStudents.SelectedIndex != -1);
        }
        #endregion

        #region Persistant Data

        public void LoadFromTxt(string path = @"StudGradesDB.txt")
        {
            var textDB = File.ReadAllText(path).Trim().Split('\n');

            foreach (var line in textDB)
            {
                var ls = line.Replace("\r", string.Empty).Split('|');

                var s  = new Student
                {
                    Name = ls[0],
                    Course = ls[1],
                    Year = Convert.ToInt16(ls[2]),
                    Term = ls[3],
                    GradeValue = Convert.ToDouble(ls[4])
                };


                AddStudent(s);
            }
        }

        public void SaveToText(string path = @"StudGradesDB.txt")
        {
            string studentString = "";
            foreach (var s in students)
            {
                studentString += s.SaveString();
            }
            File.WriteAllText(path, studentString);
        }

        #endregion

        #region UI Events

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmNewStudent(this).ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveStudent(lbStudents.SelectedIndex);
            RefreshStudentList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new frmNewStudent(this, lbStudents.SelectedIndex).ShowDialog();
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = (students.Count > 0 && lbStudents.SelectedIndex != -1);
            btnRemove.Enabled = (students.Count > 0 && lbStudents.SelectedIndex != -1);
        }
        #endregion

        public Student GetStudent(int i)
        {
            return students[i];
        }


    }
}
