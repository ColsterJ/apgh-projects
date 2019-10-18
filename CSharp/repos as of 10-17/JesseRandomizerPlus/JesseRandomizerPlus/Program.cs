using System;
using System.Collections.Generic;

namespace RandomNames
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //random number generator... use Rnd.Next(range) to get a new random number
            Random rnd = new Random();

            //An ordered list of everyone in the class.
            List<string> academyClass = new List<string>();
            academyClass.Add("Jesse");
            academyClass.Add("Mercy");
            academyClass.Add("George");
            academyClass.Add("Ellie");
            academyClass.Add("Josh");
            academyClass.Add("Patrick");
            academyClass.Add("Robin");
            academyClass.Add("Carolyn");
            academyClass.Add("Paul S.");
            academyClass.Add("Drew");
            academyClass.Add("Paul R.");
            academyClass.Add("Liz");
            academyClass.Add("Colin");
            academyClass.Add("Nate");
            academyClass.Add("Phran");
            academyClass.Add("John");
            academyClass.Add("Rachel");
            academyClass.Add("Lewis");

            List<string> groupNames = new List<string>();
            groupNames.Add("Vengeful Giraffe");
            groupNames.Add("Mismatched Porcupine");
            groupNames.Add("Tarnated Hare");
            groupNames.Add("Smooth Horse");
            groupNames.Add("Duckulated Seal");
            groupNames.Add("Reticulated Weasel");
            groupNames.Add("Sauntering Snake");
            groupNames.Add("Goshdarn Wallaby");
            groupNames.Add("Grody Ostrich");
            groupNames.Add("Innocuous Jackrabbit");
            groupNames.Add("Pulsating BananaSlug");
            groupNames.Add("Flickering Human");
            groupNames.Add("Slovenly Tapir");
            groupNames.Add("Uptight Anteater");
            groupNames.Add("Whirling Llama");
            groupNames.Add("Bashful Heron");
            groupNames.Add("Beligerent Platypus");
            groupNames.Add("Juiced Jackal");

            //an array of (eventually) random numbers. Same length as the list of students
            int[] randomValues = new int[academyClass.Count];
            int[] moreRandomValues = new int[groupNames.Count];
            bool runProgramAgain = true; //the program will run until the quit command turns this false

            while (runProgramAgain)
            {

                FillWithDefaultNumbers(randomValues);
                FillWithDefaultNumbers(moreRandomValues);

                GenerateRandomUniqueNumbers(randomValues);
                GenerateRandomUniqueNumbers(moreRandomValues);

                int sizeOfGroup = 0;

                //makes sure user types in a valid number
                while (sizeOfGroup <= 0 || sizeOfGroup > academyClass.Count)
                {
                    Console.WriteLine("How many students per group?");

                    sizeOfGroup = GetValidNumber(Console.ReadLine()); //returns -1 if not a number
                                                                      //this uses a function i built below

                    if (sizeOfGroup <= 0 || sizeOfGroup > academyClass.Count)
                    {
                        Console.WriteLine("Not a valid number.");
                    }
                }

                //print out the names (as many as user types in)
                for (int i = 0; i < academyClass.Count; i++)
                {
                    if ((i + 1) % sizeOfGroup == 0)
                    {
                        Console.WriteLine(academyClass[randomValues[i]]);
                        Console.WriteLine("AKA: " + groupNames[moreRandomValues[i]]);
                        Console.WriteLine();
                    }
                    else if (i == academyClass.Count - 1)
                    {
                        Console.WriteLine(academyClass[randomValues[i]]);
                        Console.WriteLine("AKA: " + groupNames[moreRandomValues[i]]);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(academyClass[randomValues[i]]);
                    }
                }

                //ask if user wants to stay in the program
                Console.WriteLine("\nRun name generator again? (Y/N)");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    runProgramAgain = false;  //exits the loop
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(); //makes a blank space
                }
            } // ends runProgramAgain while loop
        } //ends Main()


        //my method that tests user input
        public static int GetValidNumber(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return -1;
            }
        }

        //method that generates unique numbers
        public static int[] GenerateRandomUniqueNumbers(int[] input)
        {
            Random rnd = new Random();
            //for each element in the random value array...
            for (int i = 0; i < input.Length; i++)
            {
                bool noRandomYet = true;
                while (noRandomYet)
                {
                    //...generate a random number between 0 and the number of students
                    input[i] = rnd.Next(0, input.Length);
                    int numberOfDuplicates = 0;

                    //then check it against every other spot in the array for duplicates
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (i != j)  //except don't want to compare two identical things, cause obviously THEY'LL be the same.
                        {
                            if (input[i] == input[j])
                            {
                                //and if it matches, add one to the "duplicates" counter
                                numberOfDuplicates += 1;
                            }
                        }
                    }

                    //if there ARE duplicates, that's no good! Go back to the top of the loop and try again
                    if (numberOfDuplicates >= 1)
                    {
                        //no code needed, just do nothing and try the loop again
                    }
                    else
                    {
                        //if it's a unique number, great! Stop looping and go to the next thing
                        noRandomYet = false;
                    }
                } //ends noRandomYet while loop. randomValues[i] has a random number
            }//ends bigger for loop. The whole array is filled with unique random numbers
            return input;
        }

        //method that fills in with default number
        public static int[] FillWithDefaultNumbers(int[] input)
        {
            //the random number array starts out filled with -1s
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = -1;
            }
            return input;
        }

    }
}

