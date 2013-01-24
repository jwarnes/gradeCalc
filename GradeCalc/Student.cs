using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeCalc
{
    public class Student
    {
        #region Props
        public double GradeValue { get; set; }
        public string GradeLetter
        {
            get  { return Grade.GetLetter(GradeValue); } 
        }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Year { get; set; }
        public string Term { get; set; }
        #endregion

        public Student()
        {
        }

        public Student(string name, string course, int year, string term, double grade)
        {
            Name = name;
            Course = course;
            Year = year;
            Term = term;
            GradeValue = grade;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2} {3}\t{4}", Name, Course, Term, Year, GradeLetter);
        }
    }
}
