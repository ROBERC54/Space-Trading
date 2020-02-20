using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trading
{
    class StartNewGame
    {//From the MainMenu screen, functionality results from whether the User selects "Play Game", "Resume", "How to", or "Quit."
     //This class will handle the case of "Play Game" when called from within Main_Menu.cs
     //The class functions to start the game off and introduce the character.  It should save progress by the end of the sequence and pass to "Resume.cs"
        public void Run()
        {
             bool quit;
            do
            {
            Console.Clear();
            Console.WriteLine("Starting a new game will lose all your progress...\n");
            Console.WriteLine("Are you sure you wish to continue?");
            Console.WriteLine("\n                       - (Y)ES -                \n");
            Console.WriteLine("\n                        - (N)O -                \n");
            var key = continueSelect();
                quit = UserChoice(key);

            } while (!quit);
        }
        private ConsoleKey continueSelect()
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
                case ConsoleKey.Y: //play game
                    new StartNewGame().Continue();
                    break;

                case ConsoleKey.N:
                    new Resume().Run();
                    break;

            }

            return false;
        }

        public void Continue()
        {
            Console.Clear();
            Console.WriteLine("Hey there, Space Trader!");
            Console.WriteLine("Welcome to the Universe!  Using your handy dandy spaceship, get on down to the customer, wherever they may be across the galaxy!");
            Console.WriteLine("Give them whatever you can find in exchange for currency!");
            Console.WriteLine("Press any key to continue:");
            //TODO!:generate a player Inventory
            //new InventoryClass().RunNPC();
            //TODO!:generate a player stat sheet
            //



            Console.ReadKey();
            Console.Clear();
            new Resume().Run();
        
        }
    }
}
