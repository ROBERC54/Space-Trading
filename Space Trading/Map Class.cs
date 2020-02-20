﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Space_Trading
{
    public class Map_Class
    {
        StarMap starMap = new StarMap();

        public void Run()
        {
            bool quit;
            int userx = 1;
            int usery = 1;

            do
            {
                // This is where we found inspiration for our map function
                //https://social.msdn.microsoft.com/Forums/en-US/38cecb47-ef2c-47d3-ae1d-e53a1c56e2e9/battle-ship-coding-in-c-using-console-application?forum=csharpgeneral
                Console.Clear();
                Console.WriteLine("\nmovement: left = a | right = d | up = w | down = s | quit = q\n");
                int gridSize = 30;

                int Row;

                int Column;

                //Console.WriteLine("Welcome to the Battleship");

                string[,] grid = new string[gridSize, gridSize];


                for (int j = 0; j < gridSize; j++)
                {
                    for (int i = 0; i < gridSize; i++)
                    {
                        grid[j, i] = ".";

                    }
                }

                StarClass starClass1 = new StarClass();
                List<int> xes = starClass1.getStarXCoord();
                List<int> yses = starClass1.getStarYCoord();
                for (int i = 0; i < xes.Count; i++)
                {
                    grid[xes[i], yses[i]] = "S";
                }

                string characterPos = "<";

                for (Row = 0; Row < gridSize; Row++)
                {

                    Console.WriteLine();

                    for (Column = 0; Column < gridSize; Column++)
                    {
                        Console.Write(grid[Column, Row] + " ");
                    }

                    grid[userx, usery] = characterPos;

                }
                var key = mapScreenSelect();
                (quit, userx, usery) = MoveMent(key, userx, usery);
                for (int i = 0; i < xes.Count; i++)
                {
                    if ((xes[i], yses[i]) == (userx, usery))
                    {
                        var starName = starClass1.StarAt(userx, usery).StarName;
                        starMap.Run(starName);
                    }
                }


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

        public (bool, int, int) MoveMent(ConsoleKey key, int userx, int usery)
        {
            switch (key)
            {
                case ConsoleKey.W: //move up
                    if (usery == 0)
                    {
                        break;
                    }
                    else
                    {
                        usery -= 1;
                        return (false, userx, usery);
                    };

                case ConsoleKey.S: //move down
                    if (usery == 29)
                    {
                        break;
                    }
                    else
                    {
                        usery += 1;
                        return (false, userx, usery);
                    };

                case ConsoleKey.D: //move right
                    if (userx == 29)
                    {
                        break;
                    }
                    else
                    {
                        userx += 1;
                        return (false, userx, usery);
                    };

                case ConsoleKey.A: //move down
                    if (userx == 0)
                    {
                        break;
                    }
                    else
                    {
                        userx -= 1;
                        return (false, userx, usery);
                    };

                case ConsoleKey.Q: //quit
                    return (true, userx, usery);
            }
            return (false, userx, usery);
        }
    }
}