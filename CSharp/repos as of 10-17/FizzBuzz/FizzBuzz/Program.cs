using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // if 3 fizz
            // if 5 buzz
            // if both fizzbuzz

            // CSharp doesn't let you initialize multiple iterators in the first part of for loop
            // So, s must be declared outside for loop. However, both can be iterated in final part.
            string s = "";
            for (int x = 1; x <= 100; x++, s = "")  
            {                                          
                if (x % 3 == 0)
                {
                    s += "fizz";
                }
                if (x % 5 == 0)
                {
                    s += "buzz";
                }
                if (s != "")
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
