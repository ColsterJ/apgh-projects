using System;

//Create a grid(an array with two dimensions) that is 8 by 8 (or whatever)

//Let the user try to "shoot" a ship by selecting two coordinates (the column and the row)
//When users shoot an enemy, clear the ship in that cell
//When all enemies are gone, make the "game" end.

// Bonus:
// If user picks a cell next to a ship, say "close!"


// Todo - 

namespace Battleship
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool playing = true;
            int gridSize = 5;
            bool[,] grid = new bool[gridSize+2, gridSize+2];
            bool[,] visibleGrid = new bool[gridSize + 2, gridSize + 2];

            // battleship locations are random
            int ships = 3;
            Random random = new Random();
            grid[random.Next(1, gridSize-1), random.Next(1, gridSize - 2)] = true;
            grid[random.Next(1, gridSize-1), random.Next(1, gridSize - 2)] = true;
            grid[random.Next(1, gridSize-1), random.Next(1, gridSize - 2)] = true;

            while (playing)
            {
                // draw out the grid!
                string numberLine = "  ";
                for (int i = 1; i <= gridSize; i++)
                {
                    numberLine += i + " ";
                }
                Console.WriteLine(numberLine);
                for (int i = 1; i <= gridSize; i++)
                {
                    string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    Console.Write(letters[i-1] + " ");

                    // this part loops over each row
                    // within each row, we want to loop over each column
                    for (int j = 1; j <= gridSize; j++)
                    {
                        // this part represents each spot within the row.
                        if (visibleGrid[i, j])
                        {
                            if (grid[i, j] == true)
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("~ ");
                            }
                        }
                        else {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
                //Console.WriteLine("\nRow to strike (1-" + gridSize + "): ");
                Console.WriteLine("\nRow to strike (A-E): ");
                string rowStr = Console.ReadLine().ToUpper();
                int row;
                // a -> 1
                // b -> 2
                // ...
                // z -> 26
                //int difference = 'a';
                //row = rowStr[0] - difference;
                //// FIXME - not successfully converting letter to number

                switch (rowStr)
                {
                    case "A":
                        row = 1;
                        break;
                    case "B":
                        row = 2;
                        break;
                    case "C":
                        row = 3;
                        break;
                    case "D":
                        row = 4;
                        break;
                    case "E":
                        row = 5;
                        break;
                    default:
                        row = -1;
                        break;
                }

                Console.WriteLine("\nColumn to strike (0-" + gridSize + "): ");
                int column = Convert.ToInt32(Console.ReadLine());

                if(row < 1 || row > gridSize || column < 1 || column > gridSize)
                {
                    Console.WriteLine("Invalid position!");
                }
                else if(grid[row,column] == true)
                {
                    Console.WriteLine("HIT!");
                    grid[row, column] = false;
                    ships--;
                    visibleGrid[row, column] = true;    // Must be valid position, so make visible next grid draw
                }
                else {
                    if(grid[row-1, column-1] == true ||    grid[row, column-1] == true     || grid[row + 1, column-1] == true ||
                            grid[row - 1, column] == true || grid[row + 1, column] == true ||
                            grid[row - 1, column + 1] == true || grid[row, column + 1] == true || grid[row + 1, column + 1] == true)
                    {
                        Console.WriteLine("Close!");
                    }
                    else
                    {
                        Console.WriteLine("\nNothing there!");
                    }
                    visibleGrid[row, column] = true;    // Must be valid position, so make visible next grid draw
                }

                if (ships == 0)
                {
                    Console.WriteLine("\nYOU WIN!");
                    playing = false;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}