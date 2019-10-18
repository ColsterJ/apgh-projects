using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        /*
        Numbers assignment!
        Bonus: more than two numbers                // for this, pieces could be 3, 5, 7... (so pieces.Length-1 % 2 == 0), no order of operations check, while loop
        Bonus: new operators: exponents             // done, I used '^'
        Don't do this bonus: parentheses
        Don't do this bonus: correct order of operations with more than two numbers                                                                                      
        */
        static void Main(string[] args)
        {
            bool keepRunning = true;

            Intro();
            while (keepRunning)
            {
                Console.WriteLine("Enter your math problem (or 0 to quit):");
                string input = Console.ReadLine();

                if (input != "0")
                {
                    ProcessInput(input);
                }
                else
                {
                    keepRunning = false;
                }
            }
        }

        private static void Intro()
        {
            Console.WriteLine("Please enter your calculations in this format:");
            Console.WriteLine("2 + 2");
            Console.WriteLine("-2.5 * 15.89");
            Console.WriteLine("2 ^ 3");
            Console.WriteLine("Must have spaces between the numbers and your operator!");
            Console.WriteLine("Only two numbers and the operators + - * / ^ are supported\n\n");
        }

        private static void ProcessInput(string input)
        {
            bool showError = false;
            List<double> numbers = new List<double>();
            double answer = 0;

            // Make sure there are at least two numbers
            string[] pieces = input.Split(' ');
            showError = true;
            if (pieces.Length-1 % 2 == 0)                               // length minus one should be divisible by 2 (length should be 3,5,7,9, -1 would be 2,4,6,8)
            {
                // while still a number to find - check 0, 2, 4, 6
                for(int i=0; i < pieces.Length-1; i+=2)
                {
                    double newNumber;
                    double.TryParse(pieces[0], out newNumber);
                    numbers.Add(newNumber);
                }
                for (int i = 0; i < numbers.Count; i++)
                {

                }
                showError = false;
                answer = 0;
                switch (pieces[1])      // Operation
                {
                    case "+":
                        answer = firstNumber + secondNumber;
                        break;
                    case "-":
                        answer = firstNumber - secondNumber;
                        break;
                    case "*":
                        answer = firstNumber * secondNumber;
                        break;
                    case "/":
                        answer = firstNumber / secondNumber;
                        break;
                    case "^":
                        answer = Math.Pow(firstNumber, secondNumber);
                        break;
                    default:
                        showError = true;
                        break;
                }
                if (!showError)
                {
                    Console.WriteLine(" = " + answer + "\n");
                }
            }
            if (showError)
            {
                Console.WriteLine("Invalid input!\n");
            }
        }
    }
}
