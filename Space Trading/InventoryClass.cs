using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Space_Trading
{
    class InventoryClass
    {
        string newItemPath = "New Item List.txt";
        List<Inventory> inventoryList = new List<Inventory>();
        List<Inventory> shopInvList = new List<Inventory>();

        public InventoryClass()
        {
            generateIList(newItemPath, inventoryList);
        }
        public string RunNPCgen()
        {
            //returns the path where NPC inventory file exists on User's system.
            string itemPath = "Item List.txt";

            List<string> items = File.ReadAllLines(itemPath).ToList();
            string NPCPath = "/Users/matthewmoore/Documents/MSSA/Coding/Project/Peer Programming/Space-Trading/Space Trading/Text Files/NPC Inv.txt";
            string TextFilePath = @"Text Files\";//target directory or folder
            //System.IO.File.WriteAllLines($@"{NPCPath}", items);
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo($"{NPCPath}");
            string dirPathName = dirInfo.FullName;
            //Console.WriteLine(dirPathName);  //exists just to show the path as string
            dirPathName = dirPathName.Remove(dirPathName.Length - 35);
            //Console.WriteLine(dirPathName);  //exists just to show the path as string
            System.IO.File.WriteAllLines($@"{dirPathName}{TextFilePath}{NPCPath}", items);
            return $"{dirPathName}{TextFilePath}";
        }
        public void RunNPC()
        {//generates NPC inventories.  Functionality is designed to set an NPC's inventory, save it to .txt file, where you can read from.
            //it may be fruitful to come back and implement such that it starts from a random index of the item list
            string itemPath = "Item List.txt";

            List<string> items = File.ReadAllLines(itemPath).ToList();
            string NPCPath = RunNPCgen() + "NPC Inv.txt";
            List<string> inventory = new List<string>();
            Random prng = new Random();
            for (int i = 0; i < 10;)
            {
                foreach (string item in items)  //goal is to flow through possible items in Item List.txt and grab ten/arbitrary number
                {
                    //int i = 0;
                    if (i < 10)
                    {
                        if (0 == prng.Next(0, 9))
                        {
                            inventory.Add(item);
                            i++;

                        }
                    }
                }
            }
        }

        public void RunProtagonist()
        {   //from game start, initializes an inventory for the player.
            Console.ReadKey();
            string protPath = "Protagonist Inventory.txt";
            List<string> items = generateItemList();
            File.WriteAllLines(newItemPath, items);//writes to newItemPath txt file all the items generated in previous line.
            List<string> inventory = new List<string>();
            Random prng = new Random();
            for (int i = 0; i < 10;)
            {
                foreach (string item in items)  //goal is to flow through possible items in Item List.txt and grab ten/arbitrary number
                {
                    if (i < 10)
                    {
                        if (0 == prng.Next(0, 9))
                        {
                            inventory.Add(item);
                            i++;

                        }
                    }
                }
            }
            string protDocs = "Protagonist Info.txt";
            List<string> info = new List<string>();
            info.Add("18");
            info.Add("10000");
            Console.Clear();
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            info.Add(playerName);
            File.WriteAllLines(protDocs, info);//sets player info
            Console.WriteLine($"Welcome {playerName}!\nPress any key to continue");
            File.WriteAllLines(protPath, inventory);//writes 10 random items to Protagonist Inventory document
            //potential issue.  May need to reset/re-empty ProtInv text file everytime commit to gitHub.  Tests to follow.
            //if you need to see what's in the player's inventory, use this->
                //foreach (string item in inventory)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.ReadLine();
            Console.ReadKey();
            new Resume().Run();
            new Map_Class().Run();
        }
        public List<string> generateItemList()
        {
            List<string> items = new List<string>();
            items.Add("Apple, 10, 12, 10, 15, F"); items.Add("Barley, 21, 15, 18, 29, F"); 
            items.Add("Copper, 36, 40, 35, 31, M"); items.Add("Donut, 2, 2, 3, 3, H"); 
            items.Add("Evergreen, 44, 12, 70, 98, F"); items.Add("Fount, 99, 120, 101, 79, M"); 
            items.Add("Garden gunk, 17, 8, 8, 2, F"); items.Add("Horseshoe, 21, 21, 20, 15, F"); 
            items.Add("Icepack, 4, 25, 4, 4, H"); items.Add("Juniper, 25, 27, 26, 30, F");
            items.Add("Kiosk, 100, 100, 100, 100, H"); items.Add("Lotion, 13, 15, 15, 25, H"); 
            items.Add("Morsel, 2, 4, 3, 8, F"); items.Add("Noms, 4, 8, 7, 16, F"); 
            items.Add("Ocarina, 33, 20, 28, 35, F"); items.Add("Paint, 28, 28, 28, 16, F"); 
            items.Add("Questionable cicada, 18, 15, 24, 10, M"); items.Add("Rusted Ruse, 12, 15, 18, 16, M"); 
            items.Add("Suspect stained glass, 21, 34, 38, 41, M"); items.Add("Tundracycle, 3100, 2500, 2800, 4100, M"); 
            items.Add("Ultraviolet bulb, 89, 62, 99, 130, M"); items.Add("Vellum, 14, 18, 31, 40, H"); items.Add("Water, 21, 43, 20, 20, M");
            items.Add("Water - soluble ion gas, 49, 70, 41, 30, H"); items.Add("Yunicycle, 80, 138, 77, 20, H"); 
            items.Add("Zenith distance tome, 219, 270, 189, 160, H");
            return items;
        }
        public void generateIList(string itemPath, List<Inventory> inventoryList)
        {
            List<string> lines = File.ReadAllLines(itemPath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(", ");
                Inventory newInventory = new Inventory();
                newInventory.ItemName = entries[0];
                newInventory.SpringPrice = int.Parse(entries[1]);
                newInventory.SummerPrice = int.Parse(entries[2]);
                newInventory.AutumnPrice = int.Parse(entries[3]);
                newInventory.WinterPrice = int.Parse(entries[4]);
                newInventory.ArenaSymbol = entries[5];

                inventoryList.Add(newInventory);
            }
        }

        public void buy(string symbol, int season)
        {
            List<Inventory> protInvList = new List<Inventory>();
            List<Inventory> protInfo = new List<Inventory>();
            int money =int.Parse(pullProt(out protInvList));
            genShopInv(symbol);
            
            bool quit;
            int choiceNum=0;
            do
            {
                logoDisp();
                Console.WriteLine("\noptions: buy = b | previous = <- | next = -> | quit = q\n");
                Console.WriteLine("Buy?  Here's what I have:");
                Console.WriteLine("Price:");
                printPrices(season, choiceNum);
                var key = mainMenuSelect();
                (quit, choiceNum) = UserChoice(key, choiceNum);

            } while (!quit);
            Console.WriteLine("Any time!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public void genShopInv(string symbol)
        {
            Random prng = new Random();
            for (int i = 0; i < 10;)
            {
                foreach (Inventory item in inventoryList)  
                {
                    if (i < 10)
                    {
                        if (item.ArenaSymbol == symbol)//if they are supposed to carry item for sale
                        {
                            if (0 == prng.Next(0, 9))
                            {
                                shopInvList.Add(item);
                                i++;

                            }
                        }
                    }
                }
            }
        }
        public void printPrices(int season, int choiceNum)
        {
            string currItem = shopInvList.ElementAt(choiceNum).ItemName;
            int currPrice=0;
            foreach (Inventory item in shopInvList)
            {
                if (season == 0)
                {
                    Console.WriteLine($"{item.SpringPrice}      for {item.ItemName} ");
                    currPrice = shopInvList.ElementAt(choiceNum).SpringPrice;
                }
                else if (season == 1)
                {
                    Console.WriteLine($"{item.SummerPrice}      for {item.ItemName} ");
                    currPrice = shopInvList.ElementAt(choiceNum).SummerPrice;
                }
                else if (season == 2)
                {
                    Console.WriteLine($"{item.AutumnPrice}      for {item.ItemName} ");
                    currPrice = shopInvList.ElementAt(choiceNum).AutumnPrice;
                }
                else if (season == 3)
                {
                    Console.WriteLine($"{item.WinterPrice}      for {item.ItemName} ");
                    currPrice = shopInvList.ElementAt(choiceNum).WinterPrice;
                }
            }
            Console.WriteLine($"Would you like the {currItem} for {currPrice}?");
        }
        public void sell(int season)
        {

        }
        public void logoDisp()
        {
            Console.Clear();
            Console.WriteLine("\n _________  _______   ______     _____    _________");
            Console.WriteLine("|___   ___| | ___   ) | ___  )   | ___ )   |   _____|");
            Console.WriteLine("    | |     | |__)  | | |__)  )  | |  ) )  |  |_____");
            Console.WriteLine("    | |     |    ___| |  ___   ) | |  | | |   _____|");
            Console.WriteLine("    | |     |     )   |  |  )  | | |  | | |  |");
            Console.WriteLine("    | |     |  |)  )  |  |  |  | | |__| | |  |_____");
            Console.WriteLine("    |_|     |__| )__) |__|  |__| |______| |________|\n");
        }
        public void pricescheme()
        {

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

        public (bool, int) UserChoice(ConsoleKey key, int choiceNum)
        {
            switch (key)
            {
                case ConsoleKey.B: //make purchase

                    break;

                case ConsoleKey.LeftArrow: //previous item
                    if (choiceNum == 0)
                    {   choiceNum = 9;
                        return (false, choiceNum);
                    }
                    else if (choiceNum !=0)
                    { choiceNum--; 
                    return (false, choiceNum);}
                    break;

                case ConsoleKey.RightArrow: //next item
                    if (choiceNum == 9)
                    {    choiceNum = 0;
                         return (false, choiceNum);
                    }
                    else if(choiceNum!=9)
                    {   choiceNum++; 
                        return (false, choiceNum);
                    }
                    break;

                case ConsoleKey.Q:
                    Console.Clear();
                    return (true, choiceNum);

            }

            return (false, choiceNum);
        }
        public string pullProt(out List<Inventory> thisprotInvList)
        {
            thisprotInvList = new List<Inventory>();
            string protPath = "Protagonist Inventory.txt";
            string protDocs = "Protagonist Info.txt";
            List<string> info = File.ReadAllLines(protDocs).ToList();
            List<Inventory> protCurrInfo = new List<Inventory>();
            generateIList(protPath, thisprotInvList);
            /*foreach (string line in info)
            {
                Console.WriteLine(line);
                string[] entries = new string[1];
                Inventory newInventory = new Inventory();
                newInventory.ItemName = entries[0];
                Console.WriteLine(entries[0]);
                protCurrInfo.Add(newInventory);
            }*/
            string money = info.ElementAt(1);
            return money;
        }
    }

}
