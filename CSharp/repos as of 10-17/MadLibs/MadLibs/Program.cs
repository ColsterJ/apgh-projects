using System;
using System.Collections.Generic;

namespace MadLibs
{
    class Program
    {
        // fixme: doesn't replace in order as expected
        // todo: break sections of Main() into functions
        // todo: two loops engaging with curly braces could maybe be one function?
        // todo: 
        static void Main(string[] args)
        {
            int position = 0;
            int braceStart = 0;
            int braceEnd = 0;
            int lastPosition = 0;
            string storyTemplate = "";
            string completedStory = "";
            string braceText = "";
            bool insideBrace = false;
            List<string> wordDescriptionList = new List<string>();
            List<string> userWordList = new List<string>();

            //string storyTemplate = "{author} died from drinking {something you shouldn't drink} and was sad in the afterlife.";
            //string storyTemplate = "There was once a {conscious being} from {location}, who always ate {favorite food} on {day of the week} with his friend {person's name} at the local restaurant called {restaurant name}. Amazing! {doodlebug} is a {cooltown}.";
            //string storyTemplate = "The most {adjective} thing in my life so far has been {person or creature's name}. They've always been {adjective}, even when they didn't feel like it that day. I personally think that there's nothing like a good {noun}, and they agree with me.";

            // Let the user enter a story
            Console.WriteLine("Enter a story. For each word that's interchangeable, enter a description between brackets, like this:");
            Console.WriteLine("  {person's name} was a very {adjective} person. They died young.\n\n");
            storyTemplate = Console.ReadLine();

            // For any string, collect all word descriptions between curly braces {}
            //CollectWordDescriptions(); 
            position = storyTemplate.IndexOf('{', position);   // cursor becomes position of next '{'
            while (position != -1)
            {
                if (!insideBrace)
                {
                    position = storyTemplate.IndexOf('{', position);           // cursor becomes position of next '{'
                    if (position != -1)
                    {
                        braceStart = position;
                        insideBrace = true;
                    }
                }
                else
                {
                    position = storyTemplate.IndexOf('}', position);   // cursor becomes position of next '}'
                    if (position != -1)   // found a closing brace
                    {
                        braceEnd = position;
                        braceText = storyTemplate.Substring(braceStart, (braceEnd-braceStart)+1);
                        wordDescriptionList.Add(braceText);
                            // could just use Console.ReadLine() right here to ask user for the word, then in-place replace the brace in the string
                            // TODO
                        insideBrace = false;
                    }
                }
            }

            // Then, for each required word, ask user to enter a value
            Console.WriteLine("\n\nNow, please enter each of these word types:");
            foreach(string word in wordDescriptionList)
            {
                Console.WriteLine(word.Substring(1,word.Length-2) + ":");
                userWordList.Add(Console.ReadLine());
            }

            // GenerateStory();
            // Finally, show the story text with the user's entered words in place of the word descriptions
            //      ^ To do this, use IndexOf to find next descriptions with what the user entered
            //      If you use Replace, you may wind up with multiple nouns with one value when they should
            //          be distinct
            position = 0;
            braceStart = 0;
            braceEnd = 0;
            insideBrace = false;
            position = storyTemplate.IndexOf('{', position);   // cursor becomes position of next '{'
            completedStory += storyTemplate.Substring(lastPosition, (position - lastPosition));
            while (position != -1)
            {
                lastPosition = position;
                if (!insideBrace)
                {
                    position = storyTemplate.IndexOf('{', position);           // cursor becomes position of next '{'
                    if (position != -1)
                    {
                        braceStart = position;
                        completedStory += storyTemplate.Substring(lastPosition, (position - lastPosition));
                        insideBrace = true;
                    }
                }
                else
                {
                    position = storyTemplate.IndexOf('}', position);   // cursor becomes position of next '}'
                    if (position != -1)   // found a closing brace
                    {
                        braceEnd = position;
                        braceText = storyTemplate.Substring(braceStart, (braceEnd - braceStart) + 1);
                        completedStory += userWordList[wordDescriptionList.IndexOf(braceText)];
                        insideBrace = false;
                        position++;   // Ensures we don't show the second curly brace in the final output
                    }
                }
            }
            completedStory += storyTemplate.Substring(lastPosition, storyTemplate.Length - lastPosition);

            Console.WriteLine("\n\nHere's your story:");
            Console.WriteLine(completedStory);
        }
    }
}
