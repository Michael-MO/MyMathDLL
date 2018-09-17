using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMathDLL
{
    public static class MyMath
    {
        // Method "Add"
        // Sum of x and y
        public static int Add(int x, int y)
        {
            return x + (y);
        }

        // Method "Subtract"
        // Subtract y from x
        public static int Subtract(int x, int y)
        {
            return x - (y);
        }

        // Method "Multiply"
        // Multiply x by y
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Method "Divide"
        // Divide x by y
        public static double Divide(int x, int y)
        {
            return x / y;
        }
    }
}
