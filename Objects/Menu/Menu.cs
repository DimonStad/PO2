using System;
using System.Text.RegularExpressions;

namespace _1_Lab
{
    /// <summary>
    /// Class Menu add dialog with the user
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Object of the Calculate class.
        /// </summary>
        /// <returns></returns>
        private Calculate calculate = new Calculate();
        

        /// <summary>
        /// Method for working with the console. 
        /// Processes the input string and calls the appropriate method of the Calculate class depending on the context.
        /// </summary>
        public void Start()
        {
            bool flag = true;
            string command;
            do
            {
                Console.WriteLine("Type the command");
                command = Console.ReadLine();

                if (command.Trim() == "help"){
                    Console.WriteLine("\ncls - clear all screen.");
                    Console.WriteLine("stop - close programm.");
                    Console.WriteLine("expression of the form: x + y ; x - y ; x * y ; x / y ; sqrt ; sqr ; abs ; sqrt x ; sqr x.\n");
                }

                if (command.Trim() == "cls"){
                    Console.Clear();
                }

                if (command.Trim() == "stop")
                    flag = false;

                 string[] digits = Regex.Split(command.Trim(), @"\s+");
                if (digits.Length == 3){
                    try{
                        string oper = digits[1];
                        if (oper == "+"){
                            calculate.RES = double.Parse(digits[0]);
                            Console.WriteLine($"{digits[0]} + {digits[2]} = {calculate.Sum(double.Parse(digits[2]))}");
                        }

                        if (oper == "-"){
                            calculate.RES = double.Parse(digits[0]);
                            Console.WriteLine($"{digits[0]} - {digits[2]} = {calculate.Diff(double.Parse(digits[2]))}");
                        }

                        if (oper == "*"){
                            calculate.RES = double.Parse(digits[0]);
                            Console.WriteLine($"{digits[0]} * {digits[2]} = {calculate.Multiplication(double.Parse(digits[2]))}");
                        }

                        if (oper == "/"){
                            calculate.RES = double.Parse(digits[0]);
                            Console.WriteLine($"{digits[0]} / {digits[2]} = {calculate.Division(double.Parse(digits[2])).ToString()}");
                        }
                    }
                    catch (FormatException ex) { Console.WriteLine(ex); }
                }

                if (digits.Length == 2){
                    try{
                        string oper = digits[0];
                        if (oper == "sqr"){
                            Console.WriteLine($"sqr({digits[1]}) = {calculate.Sqr(double.Parse(digits[1]))}");
                        }

                        if (oper == "sqrt"){
                            Console.WriteLine($"sqrt({digits[1]}) = {calculate.Sqrt(double.Parse(digits[1]))}");
                        }

                        if (oper == "abs"){
                            Console.WriteLine($"abs({digits[1]}) = {calculate.Abs(double.Parse(digits[1]))}");
                        }
                    }
                    catch (FormatException ex) { Console.WriteLine(ex); }
                }

                if (digits.Length == 1){
                    try{
                        string oper = digits[0];
                        if (oper == "sqr"){
                            Console.WriteLine($"sqr({calculate.RES}) = {calculate.Sqr()}");
                        }

                        if (oper == "sqrt"){
                            Console.WriteLine($"sqrt({calculate.RES}) = {calculate.Sqrt()}");
                        }

                        if (oper == "abs"){
                            Console.WriteLine($"abs({calculate.RES}) = {calculate.Abs()}");
                        }
                                                    
                    }
                    catch (FormatException ex) { Console.WriteLine(ex); }
                }

            } while (flag);
        }

        
        /// <summary>
        /// Method for passing tests. 
        /// Processes the input string and calls the appropriate method of the Calculate class, depending on the context.
        /// </summary>
        /// <param name="command"></param>
        public void Start(string command)
        {

            if (command.Trim() == "help")
            {
                Console.WriteLine("cls - clear all screen.");
                Console.WriteLine("stop - close programm.");
                Console.WriteLine("expression of the form: x + y ; x - y ; x * y ; x / y ; sqrt ; sqr ; abs ; sqrt x ; sqr x.");
            }
            else
            {
                if (command.Trim() == "cls")
                {
                    Console.Clear();
                }
                else
                {
                    if (command.Trim() == "stop") { }

                    else
                    {
                        string[] digits = Regex.Split(command.Trim(), @"\s+");
                        if (digits.Length == 3)
                        {
                            try
                            {
                                string oper = digits[1];
                                if (oper == "+")
                                {
                                    calculate.RES = double.Parse(digits[0]);
                                    Console.WriteLine($"{digits[0]} + {digits[2]} = {calculate.Sum(double.Parse(digits[2]))}");
                                }
                                if (oper == "-")
                                {
                                    calculate.RES = double.Parse(digits[0]);
                                    Console.WriteLine($"{digits[0]} - {digits[2]} = {calculate.Diff(double.Parse(digits[2]))}");
                                }
                                if (oper == "*")
                                {
                                    calculate.RES = double.Parse(digits[0]);
                                    Console.WriteLine($"{digits[0]} * {digits[2]} = {calculate.Multiplication(double.Parse(digits[2]))}");
                                }
                                if (oper == "/")
                                {
                                    calculate.RES = double.Parse(digits[0]);
                                    Console.WriteLine($"{digits[0]} / {digits[2]} = {calculate.Division(double.Parse(digits[2])).ToString()}");
                                }
                            }
                            catch (FormatException ex) { Console.WriteLine(ex); }
                        }
                        else
                        {
                            if (digits.Length == 2)
                            {
                                try
                                {
                                    string oper = digits[0];
                                    if (oper == "sqr")
                                    {
                                        Console.WriteLine($"sqr({digits[1]}) = {calculate.Sqr(double.Parse(digits[1]))}");
                                    }
                                    if (oper == "sqrt")
                                    {
                                        Console.WriteLine($"sqrt({digits[1]}) = {calculate.Sqrt(double.Parse(digits[1]))}");
                                    }
                                    if (oper == "abs")
                                    {
                                        Console.WriteLine($"abs({digits[1]}) = {calculate.Abs(double.Parse(digits[1]))}");
                                    }
                                }
                                catch (FormatException ex) { Console.WriteLine(ex); }
                            }
                            else
                            {

                                if (digits.Length == 1)
                                {
                                    try
                                    {
                                        string oper = digits[0];
                                        if (oper == "sqr")
                                        {
                                            Console.WriteLine($"sqr({calculate.RES}) = {calculate.Sqr()}");
                                        }
                                        else
                                        {
                                            if (oper == "sqrt")
                                            {
                                                Console.WriteLine($"sqrt({calculate.RES}) = {calculate.Sqrt()}");
                                            }
                                            else
                                            {
                                                if (oper == "abs")
                                                {
                                                    Console.WriteLine($"abs({calculate.RES}) = {calculate.Abs()}");
                                                }
                                                else Console.WriteLine("Incorrect input.");
                                            }
                                        }

                                    }
                                    catch (FormatException ex) { Console.WriteLine(ex); }
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect input.");
                                }

                            }
                        }
                    }
                }
            }


        }
    }
}