using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Space_Trading
{
    class How_To
    {//From the MainMenu screen, functionality results from whether the User selects "Play Game", "Resume", "How to", or "Quit."
     //This class will handle the case of "How to" when called from within Main_Menu.cs
     //The class will display a short guide to the player, then return to MainMenu screen
        public void Run()
        {
            Console.Clear();
            string r1 = "How To";
            string r2 = "YOU'RE A SPACE TRADER, BOSS!  TRAVERSE THE FARTHEST REACHES OF SPACE AND TRADE SOME GOODS!";
            string r3 = "PIONEER YOUR WAY THROUGH THE GALAXY VIA SPACESHIP, BUT WATCH OUT FOR THOSE BLACK HOLES!";
            string r4 = "BUY! SELL! TRADE! TAKE NO LOSSES ON INVENTORY WHILE STAGING YOUR GETAWAY WITH THE GOODS!";
            string r5 = "WRANGLE UP THOSE BOMB CUSTOMER SATISFACTION SURVEYS AS YOU DROP THEM OFF EXOTIC MISCELLANEA!";
            string r6 = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nPress any key to Continue";
            for (int i = 0; i < r1.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(r1.ElementAt(i));
            }
            Console.WriteLine();
            for (int i = 0; i < r2.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(r2.ElementAt(i));
            }
            Console.WriteLine();
            for (int i = 0; i < r3.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(r3.ElementAt(i));
            }
            Console.WriteLine();
            for (int i = 0; i < r4.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(r4.ElementAt(i));
            }
            Console.WriteLine();
            for (int i = 0; i < r5.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(r5.ElementAt(i));
            }
            Console.WriteLine();
            for (int i = 0; i < r6.Length; i++)
            {
                for (int j = 0; j < 7000000; j++)
                { }
                Console.Write(r6.ElementAt(i));
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            new Main_Menu().Run();
        }
    }
}
