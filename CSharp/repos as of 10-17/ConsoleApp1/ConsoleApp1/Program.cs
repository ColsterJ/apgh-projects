using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Enter your number to be converted (or nothing to quit): ");
                input = Console.ReadLine();
                int userInt;
                if (input != "")
                {
                    userInt = Convert.ToInt32(input);
                }
                else
                {
                    break;
                }

                string result = ConvertToRoman(userInt);
                Console.WriteLine(input + " written in Roman Numerals is " + result + "\n");
            } while (input != "");
        }

        static string ConvertToRoman(int number)
        {
            string roman = "";
            while (number >= 1000)
            {
                number = number - 1000;
                roman = roman + "M";
            }
            while (number >= 500)
            {
                number = number - 500;
                roman = roman + "D";
            }

            while (number >= 100)
            {
                number = number - 100;
                roman = roman + "C";
            }
            if (number >= 90)
            {
                number = number - 90;
                roman = roman + "XC";
            }
            if (number >= 50)
            {
                number = number - 50;
                roman = roman + "L";
            }
            if (number >= 40)
            {
                number = number - 40;
                roman = roman + "XL";
            }
            while (number >= 10)
            {
                number = number - 10;
                roman = roman + "X";
            }
            if (number >= 9)
            {
                number = number - 9;
                roman = roman + "IX";
            }
            if (number >= 5)
            {
                number = number - 5;
                roman = roman + "V";
            }
            if (number >= 4)
            {
                number = number - 4;
                roman = roman + "IV";
            }
            while (number >= 1)
            {
                number = number - 1;
                roman = roman + "I";
            }
            return roman;
        }
    }
}
