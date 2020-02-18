using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Trading
{
    public class Main_Menu
    {
        public void Run()
        {
            bool quit;
            do
            {
                Console.WriteLine("\n _________  _______   ______     _____    _________");
                Console.WriteLine("|___   ___| | ___   ) | ___  )   | ___ )   |   _____|");
                Console.WriteLine("    | |     | |__)  | | |__)  )  | |  ) )  |  |_____");
                Console.WriteLine("    | |     |    ___| |  ___   ) | |  | | |   _____|");
                Console.WriteLine("    | |     |     )   |  |  )  | | |  | | |  |");
                Console.WriteLine("    | |     |  |)  )  |  |  |  | | |__| | |  |_____");
                Console.WriteLine("    |_|     |__| )__) |__|  |__| |______| |________|\n");

                Console.WriteLine("\n                       - (P)LAY -                \n");
                Console.WriteLine("\n                      - (R)ESUME -                \n");
                Console.WriteLine("\n                      - (H)OW TO -                \n");
                Console.WriteLine("\n                       - (Q)UIT -                \n");
                var key = mainMenuSelect();
                quit = UserChoice(key);

            } while (!quit);
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
                case ConsoleKey.P: //play game
                    //playGame();
                    break;

                case ConsoleKey.R:
                    //resumeGame();
                    break;

                case ConsoleKey.H:
                    //howTo();
                    break;

                case ConsoleKey.Q:
                    return true;

            }

            return false;
        }
    }
}
