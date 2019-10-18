using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        /*
         * Get user input****
         * search string and identify numbers vs operators
         * 
         * read until operator or space
         * before operater as a int
         * operator replaced with a function
         * after operator as a int
         * 
         * if it contains operator symbol with function
         * 
         * add, subtract, multiply,divide
         * display input string & output answer
         */
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\t\tOperators\n([+]Add,[-]Subtract,[/]Divide,[*]Multiply\n\n\tEnter Equation");
            string userInput = Console.ReadLine();
            string[] equation = userInput.Split();
            int firstNumber = Convert.ToInt32((equation[0].ToString()));
            int secondNumber = Convert.ToInt32((equation[2].ToString()));


            for (int i = 0; i < equation.Length; i++)

                if (equation[1] == "+")
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }
                else if (equation[1] == "-")
                {
                    Console.WriteLine(firstNumber - secondNumber);
                }
                else if (equation[1] == "*")
                {
                    Console.WriteLine(firstNumber * secondNumber);
                }
                else if (equation[1] == "/")
                {
                    Console.WriteLine(firstNumber / secondNumber);
                }
                else
                {
                    Console.WriteLine("Invalid Response");
                }
            //switch (equation[1])

            //{
            //    case "+":
            //        Console.WriteLine((firstNumber) + (secondNumber));
            //        break;
            //    case "-":
            //        Console.WriteLine((firstNumber) - (secondNumber));
            //        break;
            //    case "*":
            //        Console.WriteLine((firstNumber) * (secondNumber));
            //        break;
            //    case "/":
            //        Console.WriteLine((firstNumber) / (secondNumber));
            //        break;
            //}

            Console.ReadLine();
        }
    }
}
