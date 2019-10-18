using System;
namespace CashierApp
{
    class Program
    {
        // What are John/Jean's favorite test cases for cashier app?

        private static int countDenomination(decimal amount, decimal denom)
        {
            int howMany = 0;
            while (amount >= denom)
            {
                amount -= denom;
                howMany += 1;
            }
            return howMany;
        }
        private static string makeQuote(decimal amount)
        {
            int howMany;
            string quote = "";

            howMany = countDenomination(amount, 100);
            if (howMany > 0)
            {
                quote += howMany + " hundred dollar bill(s)\n";
            }
            amount -= howMany * 100;

            howMany = countDenomination(amount, 50);
            if (howMany > 0)
            {
                quote += howMany + " fifty dollar bill(s)\n";
            }
            amount -= howMany * 50;

            howMany = countDenomination(amount, 20);
            if (howMany > 0)
            {
                quote += howMany + " twenty dollar bill(s)\n";
            }
            amount -= howMany * 20;

            howMany = countDenomination(amount, 10);
            if (howMany > 0)
            {
                quote += howMany + " ten dollar bill(s)\n";
            }
            amount -= howMany * 10;

            howMany = countDenomination(amount, 5);
            if (howMany > 0)
            {
                quote += howMany + " five dollar bill(s)\n";
            }
            amount -= howMany * 5;

            howMany = countDenomination(amount, 1);
            if (howMany > 0)
            {
                quote += howMany + " one dollar bill(s)\n";
            }
            amount -= howMany * 1;

            // trying Math.Round() on all change
            //amount = Math.Round(amount, 2);

            howMany = countDenomination(amount, 0.25m);
            if (howMany > 0)
            {
                quote += howMany + " quarter(s)\n";
            }
            amount -= howMany * 0.25m;

            howMany = countDenomination(amount, 0.10m);
            if (howMany > 0)
            {
                quote += howMany + " dime(s)\n";
            }
            amount -= howMany * 0.10m;

            howMany = countDenomination(amount, 0.05m);
            if (howMany > 0)
            {
                quote += howMany + " nickel(s)\n";
            }
            amount -= howMany * 0.05m;

            howMany = countDenomination(amount, 0.01m);
            if (howMany > 0)
            {
                quote += howMany + " penny(s)\n";
            }
            amount -= howMany * 0.01m;

            //howMany = countDenomination(Math.Round(amount, 2), 0.01);
            //if (howMany > 0)
            //{
            //    quote += howMany + " penny(s)\n";
            //}
            //amount -= howMany * 0.01;
            // 
            // ^ the rounding will lead to an accumulation of error

            // quote += Math.Round(amount, 2) * 100 + " penny(s)\n";
            // ^ seems to give correct number, but not written consistent with how we calculated other denominations


            //quote += amount * 100 + " penny(s)\n";
            // ^ gives partial pennies

            return quote;
        }
        static void Main(string[] args)
        {
            //ask for amount
            //return amount
            //ask how much they gave
            //return change
            //return specific denonminations
            Console.WriteLine("What is the cost of the item?");
            decimal itemCost = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How much money did they give?");
            decimal amtPaid = Convert.ToDecimal(Console.ReadLine());

            decimal change = amtPaid - itemCost;
            Console.WriteLine($"Your change is {change:C}.");

            Console.WriteLine(makeQuote(change));
        }

    }
}
