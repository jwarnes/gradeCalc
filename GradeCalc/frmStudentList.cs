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

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmNewStudent(this).ShowDialog();
        }

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

        public void LoadFromTxt(string path = @"StudGradesDB.txt")
        {
            var textDB = File.ReadAllText(path).Trim().Split('\n');

            foreach (var line in textDB)
            {
                var ls = line.Trim().Split('|');
                var s = new Student(ls[0], ls[1], Convert.ToInt16(ls[3]), ls[2], Convert.ToDouble(ls[4]));

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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveStudent(lbStudents.SelectedIndex);
            RefreshStudentList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new frmNewStudent(this, lbStudents.SelectedIndex).ShowDialog();
        }

        public Student GetStudent(int i)
        {
            return students[i];
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = (students.Count > 0 && lbStudents.SelectedIndex != -1);
            btnRemove.Enabled = (students.Count > 0 && lbStudents.SelectedIndex != -1);
        }
    }
}
