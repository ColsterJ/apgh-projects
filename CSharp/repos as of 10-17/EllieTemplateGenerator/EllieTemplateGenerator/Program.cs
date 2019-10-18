using System;

namespace TemplateGeneratorExercise
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            ShowMenu();
            string variableNum = Console.ReadLine();

            switch (variableNum)
            {
                case "0":
                    {
                        Zero();
                        break;
                    }

                case "1":
                    {
                        One();
                        break;
                    }
                case "2":
                    {
                        Two();
                        break;
                    }
                case "3":
                    {
                        Three();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option, goodbye.");
                        break;
                    }
            }

        }




        static void ShowMenu()
        {
            Console.WriteLine("Welcome to the template engine! Press 'enter' to begin :)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How many variables would you like to use? (0 - 3) or write 'exit' to exit");
            //Console.WriteLine("Great! Let's figure out what sort of variables you would like to use.");
        }



        static void Zero()
        {
            Console.WriteLine("Really bro? Choose a variable amount!");
        }

        //one variable option
        static void One()
        {
            Console.WriteLine("Please enter a variable type (subject");
            string variableOne = Console.ReadLine();
            Console.WriteLine("Great! Please name a type of " + variableOne + "!");
            string variableOneType = Console.ReadLine();
            BasicTemplate();
            Console.WriteLine("\tYour Template:\nI love skiing! My favorite part is when you can feel the warm [" + variableOne + "] running through your hair!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Now press 'enter' to generate your story!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is your story!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("I love skiing! My favorite part is when you can feel the warm " + variableOneType + " running through your hair!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Haha, hope you enjoyed!");
        }

        //two variable option
        static void Two()
        {
            Console.WriteLine("Please enter your first variable type (subject):");
            string variableOne = Console.ReadLine();
            Console.WriteLine("Please enter your second variable type (subject):");
            string variableTwo = Console.ReadLine();
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Great! Please name a type for " + variableOne + "!");
            string variableOneType = Console.ReadLine();
            Console.WriteLine("Thanks! Now name your type of " + variableTwo + "!");
            string variableTwoType = Console.ReadLine();
            BasicTemplate();
            Console.WriteLine("\tYour Template:\nWhen Harry hit the home run with his lucky [" + variableOne + "], he watched it soar over the fence and straight into a pile of [" + variableTwo + "]!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Now press 'enter' to generate your story!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is your story!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("When Harry hit the home run with his lucky " + variableOneType + ", he watched it soar over the fence and straight into a pile of " + variableTwoType + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Haha, hope you enjoyed!");
        }

        //three variable option
        static void Three()
        {
            Console.WriteLine("Please enter your first variable type (subject):");
            string variableOne = Console.ReadLine();
            Console.WriteLine("Please enter your second variable type (subject):");
            string variableTwo = Console.ReadLine();
            Console.WriteLine("Please enter your third variable type (subject):");
            string variableThree = Console.ReadLine();
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Great! Please name a type for " + variableOne + "!");
            string variableOneType = Console.ReadLine();
            Console.WriteLine("Thanks! Now name your type of " + variableTwo + "!");
            string variableTwoType = Console.ReadLine();
            Console.WriteLine("Thanks! Now name your type of " + variableThree + "!");
            string variableThreeType = Console.ReadLine();
            BasicTemplate();
            Console.WriteLine("\tYour Template:\nFrodo and Sam took the one true [" + variableOne + "] and placed it in the sacred [" + variableTwo + "], \nbefore making thier way to throw the [" + variableOne + "] into a pile of [" + variableThree + "].");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Now press 'enter' to generate your story!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is your story!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Frodo and Sam took the one true " + variableOneType + " and placed it in the sacred " + variableTwoType + ", \nbefore making thier way to throw the  " + variableOneType + " into a pile of " + variableThreeType + ".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Haha, hope you enjoyed!");
        }

        static void BasicTemplate()
        {
            Console.WriteLine("Thanks! Here we go :)");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Creating template...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Creating template...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Creating template...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Here is your template!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
    }

}


