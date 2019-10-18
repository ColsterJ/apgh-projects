using System;

namespace HelloWorldSession9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How LONG is your garden box (in feet)?");
            double length = int.Parse(Console.ReadLine());
            Console.WriteLine("How WIDE is your garden box (in feet)?");
            double width = int.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("\nThe AREA of your box is " + area + " feet squared");
            double perimeter = 2 * length + 2 * width;
            Console.WriteLine("The PERIMETER of your box is " + perimeter + " feet squared");


            // In stating how many of a crop can be grown within a space, websites typically use a unit of 4x4 ft square
            // So, you can divide the area (feet squared) by 4*4 (length*width), then multiply that value times the yield for a 4x4 square

            double unit = (4 * 4);

            double carrots_per_unit = 16;
            double carrots = (area / unit) * carrots_per_unit;
            Console.WriteLine("\nYou can plant " + carrots + " carrot plants in your box.");

            double corn_per_unit = 3;
            double corn = (area / unit) * corn_per_unit;
            Console.WriteLine("\nYou can plant " + corn + " ears of corn in your box.");

            double beets_per_unit = 9;
            double beets = (area / unit) * beets_per_unit;
            Console.WriteLine("\nYou can plant " + beets + " beet plants in your box.");
        }
    }
}
