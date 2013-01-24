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

    }
}
