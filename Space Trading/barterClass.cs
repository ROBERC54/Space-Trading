using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trading
{
    class barterClass
    {
        string planet;
        string building;
        string symbol;
        int season;
        string seasonName;
        public void Run(string planetName, string buildingName, int seasonNum)
        {
            planet = planetName;
            building = buildingName;
            season = seasonNum;
            if (season == 0)
            {
                seasonName = "Spring";
            }
            else if (season == 1)
            {
                seasonName = "Summer";
            }
            else if (season == 2)
            {
                seasonName = "Autumn";
            }
            else if (season == 3)
            {
                seasonName = "Winter";
            }
            if (buildingName == "Hospital Supply")
            {
                symbol = "H";
            }
            else if(buildingName == "Farm")
            {
                symbol = "F";
            }
            else if(buildingName == "Moisture Farm")
            {
                symbol = "M";
            }
            Run();
        }
        public void Run()
        {
            bool quit;
            do
            {
                Console.Clear();
                Console.WriteLine("\n _________  _______   ______     _____    _________");
                Console.WriteLine("|___   ___| | ___   ) | ___  )   | ___ )   |   _____|");
                Console.WriteLine("    | |     | |__)  | | |__)  )  | |  ) )  |  |_____");
                Console.WriteLine("    | |     |    ___| |  ___   ) | |  | | |   _____|");
                Console.WriteLine("    | |     |     )   |  |  )  | | |  | | |  |");
                Console.WriteLine("    | |     |  |)  )  |  |  |  | | |__| | |  |_____");
                Console.WriteLine("    |_|     |__| )__) |__|  |__| |______| |________|\n");

                Console.WriteLine($"Welcome to the finest {building} on {planet} this cheerful {seasonName}!");
                Console.WriteLine("Would you like to buy or sell?");
                Console.WriteLine("\n                       - (B)UY -                \n");
                Console.WriteLine("\n                      - (S)ELL -                \n");
                Console.WriteLine("\n                       - (Q)UIT -                \n");
                var key = mainMenuSelect();
                quit = UserChoice(key);

            } while (!quit);
            Console.Clear();
            Console.WriteLine("A pleasure to do business with you!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        private ConsoleKey mainMenuSelect()
        {
            ConsoleKey key;

            //PrintUsageOptions();
            key = UserInput();

            return key;
        }

        private ConsoleKey UserInput()
        {
            return Console.ReadKey().Key;
        }

        public bool UserChoice(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.B: //make purchase
                    new InventoryClass().buy(symbol, season);
                    break;

                case ConsoleKey.S: //sell the goods
                    new InventoryClass().sell(season);
                    break;

                case ConsoleKey.Q:
                    return true;

            }

            return false;
        }
    }
}
