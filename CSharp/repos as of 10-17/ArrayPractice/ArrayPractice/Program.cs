using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // assignment!
            // Take in 5 names. Print them all back out.
            int howMany = 5;
            Console.WriteLine("How many names would you like to enter?");
            howMany = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[howMany];
            int[] ages = new int[howMany];

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("\nEnter name " + (i+1) + ", please:");
                names[i] = Console.ReadLine();
                Console.WriteLine("\nEnter " + names[i] + "'s age, please:");
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nLovely, here are the names and ages you entered:");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + ", " + ages[i] + " years of age");
            }
        }
    }
}
