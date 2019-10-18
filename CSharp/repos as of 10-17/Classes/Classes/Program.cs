using System;

namespace Bertleblip
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Album[] albums = new Album[5];
            int freeSlot = 0;
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Make a selection:");
                Console.WriteLine("1 - Add an album");
                Console.WriteLine("2 - Show all albums");
                Console.WriteLine("0 - Quit");
                int selection = Convert.ToInt32(Console.ReadLine());

                // Option 1 - Allow user to add an album
                if (selection == 1)
                {
                    if (freeSlot == albums.Length)
                    {
                        Console.WriteLine("Ran out of space!");
                    }
                    else
                    {
                        albums[freeSlot] = new Album();
                        Console.WriteLine("Title:");
                        albums[freeSlot].Title = Console.ReadLine();
                        Console.WriteLine("Artist:");
                        albums[freeSlot].Artist = Console.ReadLine();
                        Console.WriteLine("Genre:");
                        albums[freeSlot].Genre = Console.ReadLine();
                        Console.WriteLine("Year:");
                        albums[freeSlot].Year = Convert.ToInt32(Console.ReadLine());

                        freeSlot += 1;
                        if (freeSlot == albums.Length)
                        {
                            Console.WriteLine("Hey there buddy, just to let you know this is it! There's no more room!");
                        }
                    }
                }
                // Option 2 - Show all albums
                if (selection == 2)
                {
                    for (int i = 0; i < freeSlot; i++)
                    {
                        Console.WriteLine(albums[i].ToString());
                    }
                }
                // Option 3 - Quit
                if(selection == 0)
                {
                    keepRunning = false;
                }
                Console.WriteLine();
            }
        }
    }

    public class Album
    {
        public string Title;
        public string Artist;
        public string Genre;
        public int Year;

        public override string ToString()
        {
            string output = "";
            output = "Title: " + Title + "\n";
            output += "Artist: " + Artist + "\n";
            output += "Genre: " + Genre + "\n";
            output += "Year: " + Year + "\n";

            return output;
        }
    }
}
