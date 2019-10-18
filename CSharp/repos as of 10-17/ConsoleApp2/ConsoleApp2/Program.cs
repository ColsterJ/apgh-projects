using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter your name: ");
            input = Console.ReadLine();

            if (input.ToUpper().Contains("A"))
            {
                Console.WriteLine("Whoa, your name contains an 'a'!");
            }
            if (input.Length > 10)
            {
                Console.WriteLine("Whoa, your name is over 10 characters!");
            }

            Console.WriteLine("\nTell me something. I don't want to hear you say 'no' or 'don't' anywhere though:");
            input = Console.ReadLine();
            if (input.ToUpper().Contains("NO") || input.ToUpper().Contains("DON'T"))
            {
                Console.WriteLine("You said 'no'! What did I tell you!");
                input = input.ToLower().Replace("no", "yes");
                input = input.ToLower().Replace("don't", "do");
                Console.WriteLine("You could've said \'" + input + "\'");
            }

            Console.WriteLine("\nWrite a sentence including both 'rose' and 'flower':");
            input = Console.ReadLine();
            if (input.ToUpper().Contains("ROSE") && input.ToUpper().Contains("FLOWER"))
            {
                Console.WriteLine("Wow, that was beautiful. It really brought to mind both roses and flowers.");
            }
            else
            {
                Console.WriteLine("That lacked a certain something!");
                if (!input.ToUpper().Contains("ROSE"))
                {
                    Console.WriteLine("You didn't mention a rose!");
                }
                if (!input.ToUpper().Contains("FLOWER"))
                {
                    Console.WriteLine("You didn't include 'flower'!");
                }
            }
        }
    }
}
