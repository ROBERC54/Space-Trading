using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Space_Trading
{
    public class StarMap
    {
        PlanetMapClass planetMap = new PlanetMapClass();
        string star;

        public void Run()
        {
            bool quit;
            int userx = 5;
            int usery = 5;

            do
            {
                Console.Clear();
                Console.WriteLine("\nmovement: left = a | right = d | up = w | down = s | return to star chart = q\n");
                int gridSize = 30;

                int Row;

                int Column;

                string[,] grid = new string[gridSize, gridSize];


                for (int j = 0; j < gridSize; j++)
                {
                    for (int i = 0; i < gridSize; i++)
                    {
                        grid[j, i] = ".";

                    }
                }

                PlanetClass planetClass1 = new PlanetClass();
                //Console.WriteLine("yowassup");
                List<int> xes = planetClass1.getPlanetXCoord();
                List<int> yses = planetClass1.getPlanetYCoord();
                List<string> zses = planetClass1.getPlanetSymbol();
                //Console.ReadLine();
                int numInSys = planetClass1.numPlanets(star);

                for (int i = 0; i < numInSys; i++)
                {
                    grid[xes[i], yses[i]] = zses[i];
                }

                string characterPos = "<";
                grid[userx, usery] = characterPos;
                for (Row = 0; Row < gridSize; Row++)
                {

                    Console.WriteLine();

                    for (Column = 0; Column < gridSize; Column++)
                    {
                        Console.Write(grid[Column, Row] + " ");
                    }


                }

                var key = mapScreenSelect();
                (quit, userx, usery) = MoveMent(key, userx, usery);

                for (int i = 0; i < xes.Count; i++)
                {
                    if ((xes[i], yses[i]) == (userx, usery))
                    {
                        var planetName = planetClass1.PlanetAt(userx, usery).PlanetName;
                        planetMap.Run(planetName);
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
