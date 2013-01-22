using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradeCalc
{
    public static class Validator
    {

        public static bool isDouble(string n)
        {
            try
            {
                Convert.ToDouble(n);
                return true;
            }
            catch { return false; }
        }

        public static bool isDouble(TextBox n)
        {
            return isDouble(n.Text);
        }

        public static bool inGradeRange(double g)
        {
            return (g >= 0 && g <= 200);
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
