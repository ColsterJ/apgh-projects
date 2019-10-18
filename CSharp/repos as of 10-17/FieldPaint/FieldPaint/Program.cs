using System;

namespace gardenboxes9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Garden boxes!
            // ask the user for the length and width of the boxen
            // tell them the area and perimeter
            // tell them how many corn, beet, and carrot plants they can plant in that area.
            //    carrots = 16 per 4x4
            //    corn = 3 per 4x4
            //    beet = 9 per 4x4


            // I want to treat length & width as numbers so I can do math operations
            int length;
            int width;
            // Ask for the length:
            Console.WriteLine("What is the length in feet of your garden box? (0 to quit)");
            // programming order of operations here says that you do the most inside-est of parentheses first. So FIRST we'll ReadLine. THEN, we'll convert. THEN, we'll assign.
            // so if the user types in 23, this becomes:
            // length = Convert.ToInt32("23"); // and then
            // length = 23;
            // this currently doesn't do anything good with an error - our program crashes
            length = Convert.ToInt32(Console.ReadLine());

            // Ask for the width
            Console.WriteLine("What is the width in feet of your garden box?");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nI got: length " + length + " and width " + width);



            // print out the area
            int gardenArea = length * width;
            Console.WriteLine("\nThe area of your gardenbox is " + gardenArea);
            // print out the perimeter
            Console.WriteLine("The perimeter of your gardenbox is " + (2 * length + 2 * width));
            // note: it's very important to have some expectations about right answers. "not crashing" doesn't mean your code does what you want.



            // How many vegetables fit in here?
            // show debugging here! vocabulary: breakpoint
            // we could make all our variables doubles to deal with fractions
            Console.WriteLine("\nWhat crop would like to see? Enter 'corn', 'carrots' or 'beets':");
            string crop = Console.ReadLine().ToLower();
            Console.WriteLine("");

            double carrotsPerFoot = 16 / 16; // 16 in 4x4. 16 in 16
            double carrots = gardenArea * carrotsPerFoot;
            double cornsPerFoot = 3.0 / 16;
            double corns = gardenArea * cornsPerFoot;
            double beetsPerFoot = 9.0 / 16;
            double beets = gardenArea * beetsPerFoot;
            if (crop.Contains("carrot"))
            {
                Console.WriteLine("You can plant: ");
                Console.WriteLine(Math.Floor(carrots) + " carrots");
            }
            else if (crop.Contains("corn"))
            {
                Console.WriteLine("You can plant: ");
                Console.WriteLine(Math.Floor(corns) + " corn");
            }
            else if (crop.Contains("beet"))
            {
                Console.WriteLine("You can plant: ");
                Console.WriteLine(Math.Floor(beets) + " beets");
            }
            else
            {
                Console.WriteLine("You didn't enter a valid crop! Showing what I can:");
                Console.WriteLine(Math.Floor(carrots) + " carrots");
                Console.WriteLine(Math.Floor(corns) + " corn");
                Console.WriteLine(Math.Floor(beets) + " beets");
            }



            // or we could also do the math in a slightly different order.
            //carrots = gardenArea * 16 / 16;
            //corns   = gardenArea * 3 / 16;
            //beets   = gardenArea * 9 / 16;

            // it's weird to have a half beet.... let's round it.
            //Console.WriteLine("You can plant: ");
            //Console.WriteLine(Math.Floor(carrots) + " carrots");
            //Console.WriteLine(Math.Floor(corns) + " corn");
            //Console.WriteLine(Math.Floor(beets) + " beets");
        }
    }
}