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
        private byte res1;
        #endregion

        #region Settors and Gettors
        /// <summary>
        /// Settor and gettor for the res field.
        /// </summary>
        /// <value>
        /// Settors and Gettors
        /// </value>
        public double RES { set => res = value; get => res; }
        public byte RES1 { set => res1 = value; get => res1;}
        #endregion

        #region Multiplication
        /// <summary>
        /// Multiplication enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the product of two numbers.</returns>
        public double Multiplication(double b){
            res *= b;
            return res;
        }

        /// <summary>
        /// Multiplication enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the product of two numbers.</returns>
        public byte Multiplication(byte b){
            res1 *= b;
            return res1;
        }
        #endregion
        
        #region Division
        /// <summary>
        /// Division enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the division of two numbers.</returns>
        public double Division(double b){
            if(res > 0 && b == 0)
                return double.PositiveInfinity;

            if (res < 0 && b == 0)
                return double.NegativeInfinity;
            res /= b;
            return res;
        }

        /// <summary>
        /// Division enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the division of two numbers.</returns>
        public byte Division(byte b){
            res1 /= b;
            return b;
        }
        #endregion
        
        #region Sum
        /// <summary>
        /// Sum enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the sum of two numbers.</returns>
        public double Sum(double b){
            res += b;
            return res;
        }

        /// <summary>
        /// Sum enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the sum of two numbers.</returns>
        public byte Sum(byte b){
            res1 += b;
            return res1;
        }
        #endregion
        
        #region Diff
        /// <summary>
        /// Diff enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the difference of two numbers.</returns>
        public double Diff(double b){
            res -= b;
            return res;
        }

        /// <summary>
        /// Diff enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the difference of two numbers.</returns>
        public byte Diff(byte b){
            res1 -= b;
            return res1;
        }
        #endregion

        #region Sqrt
        /// <summary>
        /// Sqrt result
        /// </summary>
        /// <returns>The method returns the root of the number.</returns>
        public double Sqrt() {
            double temp = Math.Sqrt(res);
            res = temp;
            return res; 
        }
        
        /// <summary>
        /// Sqrt enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the root of the number.</returns>
        public double Sqrt(double b) { 
            res = Math.Sqrt(b);
            return res; 
        }
        #endregion

        #region Sqr
        /// <summary>
        /// Sqr result
        /// </summary>
        /// <returns>The method returns the square of the number.</returns>
        public double Sqr() {
            double temp = Math.Pow(res, 2);
            res = temp;
            return res; 
        }

        /// <summary>
        /// Sqr enter number.
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the square of the number.</returns>
        public double Sqr(double b) {
            res = Math.Pow(b, 2); 
            return res; 
        }
        #endregion
        
        #region Abs
        /// <summary>
        /// Abs result
        /// </summary>
        /// <returns>The method returns the number module.</returns>
        public double Abs() {
            double temp = Math.Abs(res);
            res = temp;
            return res; 
        }
        
        /// <summary>
        /// Abs enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the number module.</returns>
        public double Abs(double b) { 
            res = Math.Abs(b);
            return res; 
        }
        #endregion

        #region Sin
        /// <summary>
        /// Sin result.
        /// </summary>
        /// <returns>The method returns the number sin.</returns>
        public double Sin(){
            double temp = Math.Sin(res);
            res = temp;
            return res;
        }

        /// <summary>
        /// Sin enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the number sin</returns>
        public double Sin(double b){
            res = Math.Sin(b);
            return res;
        }
        #endregion

        #region Cos
        /// <summary>
        /// Cos result.
        /// </summary>
        /// <returns>The method returns the number cos.</returns>
        public double Cos(){
            double temp = Math.Cos(res);
            res = temp;
            return res;
        }

        /// <summary>
        /// Cos enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the number cos.</returns>
        public double Cos(double b){
            res = Math.Cos(b);
            return res;
        }
        #endregion

        #region Tan
        /// <summary>
        /// Tan result.
        /// </summary>
        /// <returns>The method returns the number tan.</returns>
        public double Tan(){
            double temp = Math.Tan(res);
            res = temp;
            return res;
        }
        /// <summary>
        /// Cos enter number
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the number tan.</returns>
        public double Tan(double b){
            res = Math.Tan(b);
            return res;
        }
        #endregion

        #region Exp
        /// <summary>
        /// Exp result.
        /// </summary>
        /// <returns>The method returns the number exp.</returns>
        public double Exp(){
            double temp = Math.Exp(res);
            res = temp;
            return res;
        }

        /// <summary>
        /// Exp enter number.
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the number exp. </returns>
        public double Exp(double b){
            res = Math.Exp(b);
            return res;
        }
        #endregion

        #region Log
        /// <summary>
        /// Log result.
        /// </summary>
        /// <returns>The method returns the number log.</returns>
        public double Log(){
            double temp = Math.Log(res);
            res = temp;
            return res;
        }

        /// <summary>
        /// Log enter number.
        /// </summary>
        /// <param name="b">The number is entered from the console.</param>
        /// <returns>The method returns the number log.</returns>
        public double Log(double b){
            res = Math.Log(b);
            return res;
        }
        #endregion
    }
}