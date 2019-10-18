using System;

namespace MessagingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // menu for saving and retrieving messages
            // when saving, return a # that user can use to retrieve a message
            // when retrieving, enter # you want to retrieve
            string[] messages = new string[5];
            bool keepRunning = true;
            string input;
            int choice, currentMessageIndex = 0;

            // Main application loop
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("\nPlease make a selection:");
                Console.WriteLine("1) Save a message");
                Console.WriteLine("2) Retrieve a message");
                Console.WriteLine("3) List all messages");
                Console.WriteLine("4) Clear messages");
                Console.WriteLine("0) Quit");

                input = Console.ReadLine();
                if (!Int32.TryParse(input, out choice))
                {
                    choice = -1;
                }

                Console.WriteLine();
                if (choice == 1)    // Save a message
                {
                    if (currentMessageIndex == messages.Length)
                    {
                        Console.WriteLine("Message box is full!");
                    }
                    else
                    {
                        Console.WriteLine("Enter your message:");
                        messages[currentMessageIndex] = Console.ReadLine();
                        Console.WriteLine("\nMessage ID # " + currentMessageIndex + " saved");
                    }
                    if (currentMessageIndex < messages.Length)
                    {
                        currentMessageIndex++;
                    }
                    Console.WriteLine("\n\nPress any key to go back to menu...");
                    Console.ReadKey();
                }
                else if (choice == 2)    // Retrieve a message
                {
                    Console.WriteLine("Enter Message ID #:");
                    input = Console.ReadLine();
                    if (!Int32.TryParse(input, out choice) || choice < 0 || choice >= currentMessageIndex)
                    {
                        Console.WriteLine("No message stored with that ID!\n");
                    }
                    else
                    {
                        Console.WriteLine("Message " + choice + " says:");
                        Console.WriteLine(messages[choice]);
                    }
                    Console.WriteLine("\n\nPress any key to go back to menu...");
                    Console.ReadKey();
                }
                else if (choice == 3)    // Retrieve ALL messages
                {
                    for(int i=0; i<currentMessageIndex; i++)
                    {
                        Console.WriteLine("Message #" + i + ":     " + messages[i]);
                    }
                    Console.WriteLine("\n\nPress any key to go back to menu...");
                    Console.ReadKey();
                }
                else if (choice == 4)    // Retrieve ALL messages
                {
                    currentMessageIndex = 0;
                    //messages = new string[5];
                    // ^ Not necessary, because it only interacts with strings up to currentMessageIndex.
                    // If currentMessageIndex is zero, program will assume none are stored and happily write over existing
                    // ones, since user 'deleted' them.
                    Console.WriteLine("AHHHHH Messages have been deleted");
                    Console.WriteLine("\n\nPress any key to go back to menu...");
                    Console.ReadKey();
                }
                else if (choice == 0)
                {
                    keepRunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection!\n");
                    Console.WriteLine("\n\nPress any key to go back to menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
