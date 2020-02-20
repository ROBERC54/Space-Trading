using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Space_Trading
{
    class InventoryClass
    {
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
            //inventory.Add($"{Console.ReadLine()}");
            File.WriteAllLines(NPCPath, inventory);
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }

        }

        public void RunProtagonist()
        {
            string itemPath = "Item List.txt";
            string protPath = RunNPCgen() + "Protagonist Inventory.txt";

            List<string> items = File.ReadAllLines(itemPath).ToList();
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
            //inventory.Add($"{Console.ReadLine()}");
            File.WriteAllLines(protPath, inventory);
            //if you need to see what's in the player's inventory, use this->
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        //public void Run()
        //{   //Reads from Protagonist Inventory.txt
        //    string itemPath = "Protagonist Inventory.txt";
        //    List<string> items = File.ReadAllLines(itemPath).ToList();

        //    foreach (string item in items)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    //items.Add("some item");

        //    File.WriteAllLines(itemPath, items);

        //    Console.ReadLine();
        //}

        public void buy()
        {//trying to decide which class is more appropriate to buy/sell from

        }
        public void sell()
        {

        }
        public void pricescheme()
        {

        }
    }

}
