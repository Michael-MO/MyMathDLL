using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMathDLL
{
    public static class MyMath
    {
        /// <summary>
        /// Method "Add"
        /// Sum of x and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Add(int x, int y)
        {
            return x + (y);
        }

        /// <summary>
        /// Method multi Add
        /// Sum of list x of numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int AddMulti(List<int> numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                count += number;
            }
            return count;
        }

        /// <summary>
        /// Method "Subtract"
        /// Subtract y from x
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Subtract(int x, int y)
        {
            return x - (y);
        }


        /// <summary>
        /// Method "Multiply"
        /// Multiply x by y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Method "Divide"
        /// Divide x by y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Divide(int x, int y)
        {
            if (y != 0)
            {
                return x / y;
            }

            return 0;
        }

        /// <summary>
        /// Method to the power of
        /// x to the power of y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int ToThePowerOf(int x, int y)
        {
            return x ^ y;
        }
    }
}
