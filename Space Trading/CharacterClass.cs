using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Space_Trading
{
    class CharacterClass
    {
        string name;
        string Species;
        string Job;
        string Spaceship;
        List<string> Friends;
        List<string> Enemies;
        List<string> myInventory = new List<string>();
        
        int money=10000;
        int Health=100;
        

        

        //methods
        public void Run()
        {//Instantiates a protagonist and prints his 'name' to console
            //myInventory.Add("");
            CharacterClass Protagonist= new CharacterClass("OurHero", myInventory, 167);
            Protagonist.getMoreMoney();
            string hisname=
            Protagonist.getName();
            Console.WriteLine(hisname);

            //use Species
            string hisSpecies = Species;//Protagonist.getSpecies();
            //use Job
            Protagonist.getJob();
            //use Spaceship
            Protagonist.getSpaceship();
            //use Friends
            Protagonist.getFriends();
            //use Enemies
            Protagonist.getEnemies();
            //use health
            Protagonist.getHealth();
        }

        public CharacterClass()
        {//currently trying to run some new CharacterClass().Run(); must necessarily call the default constructor to call Run's overloaded usage
            name = "char1";
            Species = "someanimal";
            Job = "nonEmployment";
            Spaceship = "Galactic bucket";
            Friends = new List<string>();
            Enemies = new List<string>();
        }
        public CharacterClass(string charName, List<string> charInventory, int charMoney)
        {
            name = charName;
            
            myInventory = charInventory;
            
            money = charMoney;
            
            new InventoryClass().RunNPC();


        }

        public string getName()
        { return name; }

        public string getSpecies()
        { return Species; }

        public string getJob()
        { return Job; }

        public string getSpaceship()
        { return Spaceship; }

        public List<string> getFriends()
        { return Friends; }

        public List<string> getEnemies()
        { return Enemies; }
        public List<string> getInventory()
        { return myInventory; }
        public int getMoney()
        { return money; }

        public int getHealth()
        { return Health; }
        public void getMoreMoney()
        { money += 10000; }

        public (int, List<string>) buy(string item, int price, int money)
        {
            if (money >= price)
            {
                myInventory.Add(item);
                money -= price;
            }
            else
            {
                Console.WriteLine("You can't afford that!");
            }
            return (money, myInventory);
        }

        public (int, List<string>) sell(List<string> charInventory, string itemtosell, int price, int money)
        {

            List<string> newInventory= new List<string>();
            bool soldItem = false;
            foreach (string item in myInventory)
            {
                if (soldItem == false)
                {
                    if (itemtosell != item)
                    {
                        newInventory.Add(item);
                    }
                    else
                    {
                        soldItem = true;
                    }
                }
                else
                    {
                        newInventory.Add(item);
                    }

                 
            }
            money += price;
            return (money, newInventory);
        }
        
    }
}
