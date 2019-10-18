using System;

namespace FieldPaintAgain
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of the circle that you are painting?");
            string answer = Console.ReadLine();
            double radius = Convert.ToDouble(answer);

            //our buckets cover 100 square feet.
            //How many buckets do we buy?

            Console.WriteLine("What color will your circle be?");
            answer = Console.ReadLine().ToLower();
            int paint_coverage, paint_cost;
            switch (answer)
            {
                case "red":
                    paint_coverage = 100;
                    paint_cost = 25;
                    break;
                case "blue":
                    paint_coverage = 120;
                    paint_cost = 28;
                    break;
                case "green":
                    paint_coverage = 90;
                    paint_cost = 33;
                    break;
                case "yellow":
                    paint_coverage = 70;
                    paint_cost = 22;
                    break;
                default:
                    Console.WriteLine("Invalid color! Going with Red");
                    answer = "red";
                    paint_coverage = 100;
                    paint_cost = 25;
                    break;
            }

            double area = Math.PI * Math.Pow(radius, 2);
            double buckets = Math.Ceiling(area / paint_coverage);
            double cost = buckets * paint_cost;

            Console.WriteLine("It will take " + buckets + " buckets of " + answer + " paint to cover your circle");
            Console.WriteLine("This will cost you $" + cost);
        }
    }
}