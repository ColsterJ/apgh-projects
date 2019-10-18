using System;
using System.Data;

namespace DataTableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            DataTable dtCalc = new DataTable();
            Object result;

            while (keepRunning)
            {
                Console.WriteLine("Enter your math problem (or 0 to quit):");
                string input = Console.ReadLine();

                if (input != "0")
                {
                    result = dtCalc.Compute(input, "");
                    Console.WriteLine(result);
                }
                else
                {
                    keepRunning = false;
                }
            }
        }
    }
}
