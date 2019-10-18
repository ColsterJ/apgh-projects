using System;
using System.Collections.Generic;   // <-- need this line to use Lists

namespace ListAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[3];
            List<string> myList = new List<string>();

            // Filling an array with strings
            Console.WriteLine("Array elements:");
            myArray[0] = "one";
            myArray[1] = "two";
            myArray[2] = "three";

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            // Filling a list with strings. Use myList.Add(item) instead of myArray[number] = item
            Console.WriteLine("\n\nList items:");
            myList.Add("a");
            myList.Add("b");
            myList.Add("c");
            myList.Add("d");

            for (int i = 0; i < myList.Count; i++)      // To get number of items in list, use myList.Count instead of myArray.Length
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
