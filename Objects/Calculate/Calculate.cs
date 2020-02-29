using System;
namespace _1_Lab
{
    public class Calculate
    {
        #region Fields
        /// <summary>
        /// Field where the current number is stored.
        /// </summary>
        private double res;
        #endregion

        #region Settors and Gettors
        /// <summary>
        /// Settor and gettor for the res field.
        /// </summary>
        /// <value>
        /// Settors and Gettors
        /// </value>
        public double RES { set => res = value; get => res; }
        #endregion

        #region Multiplication
        /// <summary>
        /// The method returns the product of two numbers.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Multiplication(double b)
        {
            res *= b;
            return res;
        }
        #endregion
        
        #region Division
        /// <summary>
        /// The method returns the division of two numbers.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Division(double b)
        {
            if(res > 0 && b == 0)
                return double.PositiveInfinity;

            if (res < 0 && b == 0)
                return double.NegativeInfinity;
            res /= b;
            return res;

        }
        #endregion
        
        #region Sum
        /// <summary>
        /// The method returns the sum of two numbers.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Sum(double b)
        {
            res += b;
            return res;
        }
        #endregion
        
        #region Diff
        /// <summary>
        /// The method returns the difference of two numbers.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Diff(double b)
        {
            res -= b;
            return res;
        }
        #endregion

        #region Sqrt
        /// <summary>
        /// The method returns the root of the number.
        /// </summary>
        /// <returns></returns>
        public double Sqrt() {
            double temp = Math.Sqrt(res);
            res = temp;
            return temp; 
        }
        
        /// <summary>
        /// The method returns the root of the number. The number is entered from the console.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Sqrt(double b) { 
            res = Math.Sqrt(b);
            return Math.Sqrt(b); 
        }
        #endregion

        #region Sqr
        /// <summary>
        /// The method returns the square of the number.
        /// </summary>
        /// <returns></returns>
        public double Sqr() {
            double temp = Math.Pow(res, 2);
            res = temp;
            return temp; 
        }

        /// <summary>
        /// The method returns the square of the number. The number is entered from the console.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Sqr(double b) {
            res = Math.Pow(b, 2); 
            return Math.Pow(b, 2); 
        }
        #endregion
        
        #region Abs
        /// <summary>
        /// The method returns the number module.
        /// </summary>
        /// <returns></returns>
        public double Abs() {
            double temp = Math.Abs(res);
            res = temp;
            return temp; 
        }
        
        /// <summary>
        /// The method returns the number module. The number is entered from the console.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Abs(double b) { 
            res = Math.Abs(b);
            return Math.Abs(b); }
        #endregion
    }
}