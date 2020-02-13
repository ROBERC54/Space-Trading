using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Trading
{
    public class PlanetClass
    {
        public void Run()
        {
            string PlanetPath = "Planets.txt";
            List<string> Planets = File.ReadAllLines(PlanetPath).ToList();

            foreach (string Planet in Planets)
            {
                Console.WriteLine(Planet);

            }
            //location = Map.GridPnt.random
            //public moon moon1 =
            //inventory =
            //GrossPlanetaryProduct =
            //motivations =
            //laws =
            //inhabitants = list(characters)
            //sectors =
            //seasons = 
        }
    }
}
