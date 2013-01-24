using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeCalc
{
    public enum GradeType
    {
        Test,
        Lab,
        DL

    }

    class Grade
    {
        #region Fields

        private double grade;
        private double weight;
        private GradeType type;
        #endregion

        #region Properties

        public double GradeValue
        {
            get { return grade; }
            set { grade = value; }
        }

        public string GradeLetter
        {
            get { return "TODO"; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public GradeType Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion

        public Grade(double grade, double weight, GradeType type)
        {
            this.grade = grade;
            this.weight = weight;
            this.type = type;
        }

        public static string GetLetter(double g)
        {
            string l = "F";
            if (g > 70)
                l = "D";
            if (g > 76)
                l = "C";
            if (g > 84)
                l = "B";
            if (g > 92)
                l = "A";

            return l;
        }
    }
}
