using System;

namespace calculator9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your problem????");
            Console.WriteLine("You can enter math problems like: '4 + 6'");
            string problem = Console.ReadLine();


            //split up the numbers and operators
            string firstNumber = "";
            string secondNumber;
            string myOperator = "";

            // get rid of the spaces so we don't have to worry about them;
            problem = problem.Replace(" ", "");

            // have a current lever state
            // have a current hopper state
            string leverState = "numbers";
            string hopperState = "";
            for (int i = 0; i < problem.Length; i++)
            {
                if (leverState == "numbers")
                {
                    if (hopperState == "" && problem[i] == '-')
                    {
                        hopperState += problem[i];
                    }
                    else if (Char.IsDigit(problem[i]))
                    {
                        hopperState += problem[i];
                    }
                    else
                    {
                        leverState = "operators";
                        if (firstNumber == "")
                        {
                            firstNumber = hopperState;
                        }
                        else
                        {
                            secondNumber = hopperState;
                        }
                        hopperState = "";
                    }
                }
                // look at the next character coming in
                // if we're in numbers
                //      and we have no numbers and it's a minus
                //          put it in the hopper
                //      and it's a number
                //          put it in the hopper
                //      and it's not a number
                //          switch to op state
                //          move what's in the hopper to the final number collection


                if (leverState == "operators")
                {
                    myOperator += problem[i];
                    leverState = "numbers";
                }
                // if we're in ops lever state
                //      then I assume it's an op character
                //          switch to the number state
                //          move this character to the final ops collection

            }
            secondNumber = hopperState;
            hopperState = "";


            Console.WriteLine("first number: " + firstNumber);
            Console.WriteLine("second number: " + secondNumber);
            Console.WriteLine("operator: " + myOperator);


            int answer = 0;
            // choose which operator to use
            if (myOperator == "+")
            {
                answer = Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber);
            }
            else if (myOperator == "-")
            {
                answer = Convert.ToInt32(firstNumber) - Convert.ToInt32(secondNumber);
            }
            Console.WriteLine("Your answer is: " + answer);
        }
    }
}
