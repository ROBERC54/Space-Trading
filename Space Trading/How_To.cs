using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trading
{
    class How_To
    {//From the MainMenu screen, functionality results from whether the User selects "Play Game", "Resume", "How to", or "Quit."
     //This class will handle the case of "How to" when called from within Main_Menu.cs
     //The class will display a short guide to the player, then return to MainMenu screen
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("How To");
            Console.WriteLine("YOU'RE A SPACE TRADER, BOSS!  TRAVERSE THE FARTHEST REACHES OF SPACE AND TRADE SOME GOODS!");
            Console.WriteLine("PIONEER YOUR WAY THROUGH THE GALAXY VIA SPACESHIP, BUT WATCH OUT FOR THOSE BLACK HOLES!");
            Console.WriteLine("BUY! SELL! TRADE! TAKE NO LOSSES ON INVENTORY WHILE STAGING YOUR GETAWAY WITH THE GOODS!");
            Console.WriteLine("WRANGLE UP THOSE BOMB CUSTOMER SATISFACTION SURVEYS AS YOU DROP THEM OFF EXOTIC MISCELLANEA!");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nPress any key to Continue");
            Console.ReadKey();
            Console.Clear();
            new Main_Menu().Run();
        }
    }
}
