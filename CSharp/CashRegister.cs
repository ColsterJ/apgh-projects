using System;

namespace cashRegister
    {
        class MainClass
        {
            public static void Main(string[] args)
            {

                string quote = "";
                int howMany = 0;

                Console.WriteLine("Enter the total cost: ");
                double cost = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How much did they pay?: ");
                double amountPaid = Convert.ToDouble(Console.ReadLine());
                double change = amountPaid - cost;


                Console.WriteLine("Your change is " + change);

                howMany = 0;
                while (change >= 100)
                {
                    change -= 100;
                    howMany += 1;
                }
                quote += howMany + " hundred dollar bill(s), ";

                howMany = 0;
                while (change >= 50)
                {
                    change -= 50;
                    howMany += 1;
                }
                quote += howMany + " fifty dollar bill(s), ";

                howMany = 0;
                while (change >= 20)
                {
                    change -= 20;
                    howMany += 1;
                }
                quote += howMany + " twenty dollar bill(s), ";

                howMany = 0;
                while (change >= 10)
                {
                    change -= 10;
                    howMany += 1;
                }
                quote += howMany + " ten dollar bill(s), ";

                howMany = 0;
                while (change >= 5)
                {
                    change -= 5;
                    howMany += 1;

                }
                quote += howMany + " five dollar bill(s), ";

                howMany = 0;
                while (change >= 1)
                {
                    change -= 1;
                    howMany += 1;
                }
                quote += howMany + " one dollar bill(s), ";

                howMany = 0;
                while (change >= 0.25)
                {
                    change -= 0.25;
                    howMany += 1;
                }
                quote += howMany + " Quarter(s), ";

                howMany = 0;
                while (change >= 0.10)
                {
                    change -= 0.10;
                    howMany += 1;
                }
                quote += howMany + " dime(s), ";

                howMany = 0;
                while (change >= 0.05)
                {
                    change -= 0.05;
                    howMany += 1;
                }
                quote += howMany + " nickle(s), ";

                howMany = 0;
                while (change >= 0.01)
                {
                    change -= 0.01;
                    howMany += 1;
                }
                quote += howMany + " penny(s), ";


                Console.WriteLine("you will need " + quote);
            }
        }
    
}
