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

                Console.WriteLine("(            (              (");
                Console.WriteLine(" )            )              )");
                Console.WriteLine("(___         (___           (___");
                Console.WriteLine("    )            )              )");
                Console.WriteLine("   (___         (___           (___");
                Console.WriteLine("       )            )              )");
                Console.WriteLine("        You're Spaghettified!\n Press Q to return to the main menu.");
                Console.WriteLine("        (            (              (");
                Console.WriteLine("         )            )              )");
                Console.WriteLine("        (___         (___           (___");
                Console.WriteLine("            )            )              )");
                Console.WriteLine("           (___         (___           (___");
                Console.WriteLine("               )            )              )");
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
