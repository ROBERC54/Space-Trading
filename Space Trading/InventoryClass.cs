﻿using System;
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
        }

        public void RunProtagonist()
        {   //from game start, initializes an inventory for the player.
            Console.ReadKey();
            string itemPath = "New Item List.txt";
            string protPath = "Protagonist Inventory.txt";
            List<string> items = File.ReadAllLines(itemPath).ToList();
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

            new Resume().Run();
            new Map_Class().Run();
        }

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
