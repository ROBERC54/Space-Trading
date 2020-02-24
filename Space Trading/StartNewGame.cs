using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            string c1 = "Hey there, Space Trader!";
            string c2 = "Welcome to the Universe!  Using your handy dandy spaceship, get on down to the customer, wherever they may be across the galaxy!";
            string c3 = "Give them whatever you can find in exchange for currency!";
            for (int i = 0; i < c1.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(c1.ElementAt(i));
            }
            Console.WriteLine();
            for (int i = 0; i < c2.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(c2.ElementAt(i));
            }
            Console.WriteLine();
            for (int i = 0; i < c3.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(c3.ElementAt(i));
            }
            Console.WriteLine("\nPress any key to continue:");
            //TODO!:generate a player Inventory
            new InventoryClass().RunProtagonist();
            //TODO!:generate a player stat sheet
            //



            Console.Clear(); Console.Clear();
            string lastTime = $"All is well\nYou've got your youth, as you're only 58 years old.\nYour ship is functional and you've 10000 in your wallet.\nYou find yourself outside a local star system...";
            for (int i = 0; i < lastTime.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(lastTime.ElementAt(i));
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            new Map_Class().Run();

        }
    }
}
