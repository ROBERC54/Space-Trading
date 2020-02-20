using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Trading
{
    public class Spaghettification
    {
        public void Run()
        {
            bool quit;
            do
            {
                Console.Clear();
                int gridSize = 30;

                string[,] grid = new string[gridSize, gridSize];


                for (int j = 0; j < gridSize; j++)
                {
                    for (int i = 0; i < gridSize; i++)
                    {
                        grid[j, i] = ";";
                    }
                }

                Console.WriteLine("(            (              (\n");
                Console.WriteLine(" )            )              )\n");
                Console.WriteLine("(___         (___           (___\n");
                Console.WriteLine("    )            )              )\n");
                Console.WriteLine("   (___         (___           (___\n");
                Console.WriteLine("       )            )              )\n");
                Console.WriteLine("You're Spaghettified!\n Press Q to return to the main menu.");
                var key = mapScreenSelect();
                (quit) = MoveMent(key);
            } while (!quit);
        }
        private ConsoleKey mapScreenSelect()
        {
            ConsoleKey key;
            key = UserInput();

            return key;
        }

        private ConsoleKey UserInput()
        {
            return Console.ReadKey().Key;
        }

        public bool MoveMent(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Q: //quit
                    Console.Clear();
                    new Main_Menu().Run();
                    return true;
            }
            return false;
        }
    }
}
