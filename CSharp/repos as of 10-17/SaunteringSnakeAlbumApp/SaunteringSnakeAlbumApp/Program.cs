using System;

namespace Albums
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

                        foreach (Song song in albums[freeSlot].Songs)
                        {
                            Console.WriteLine("Song Title: ");
                            song.Title = Console.ReadLine();
                        }
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
                    Console.WriteLine("Would you like to see track listings? Y or N.");
                    string Tracklist = Console.ReadLine().ToUpper();

                    for (int i = 0; i < freeSlot; i++)
                    {
                        Console.WriteLine(albums[i].ToString());
                        if (Tracklist == "Y")
                        {
                            Console.WriteLine(albums[i].GetSongList());
                        }
                    }
                }
                // Option 3 - Quit
                if (selection == 0)
                {
                    keepRunning = false;
                }
                Console.WriteLine();
            }
        }
    }
    public class Song
    {
        public string Title;
        public string Length;
        public string Composer;

        public override string ToString()
        {
            string output = "";
            output = "Title: " + Title + "\n";
            output = "Length: " + Length + "\n";
            output = "Composer: " + Composer + "\n";

            return output;
        }
    }
    public class Album
    {
        public string Title;
        public string Artist;
        public string Genre;
        public int Year;
        public Song[] Songs = new Song[2];

        public Album()
        {
            for (int i = 0; i < Songs.Length; i++)
            {
                Songs[i] = new Song();
            }
        }
        public override string ToString()
        {
            string output = "";
            output = "Title: " + Title + "\n";
            output += "Artist: " + Artist + "\n";
            output += "Genre: " + Genre + "\n";
            output += "Year: " + Year + "\n";


            return output;
        }

        public string GetSongList()
        {
            string Tracklist = "";
            foreach (Song song in Songs)
            {
                Tracklist += song.Title + "\n";
            }
            return Tracklist;
        }
    }
}
