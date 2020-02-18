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
            string planetPath = "Planets.txt";

            List<Planet> planets = new List<Planet>();
            List<string> lines = File.ReadAllLines(planetPath).ToList();
            List<string[]> entriesList = new List<string[]>();
            foreach (var line in lines)
            {
                string[] TheseEntries = line.Split(',');
                entriesList.Add(TheseEntries);
                Planet newPlanet = new Planet();

                newPlanet.PlanetName = TheseEntries[0];
                newPlanet.PlanetStar = TheseEntries[1];
                newPlanet.PlanetInFromStar = int.Parse(TheseEntries[2]);
                newPlanet.PlanetMass = double.Parse(TheseEntries[3]);
                //newPlanet.PlanetXCoord = double.Parse(entries[4]);
                //newPlanet.PlanetYCoord = double.Parse(entries[5]);

                planets.Add(newPlanet);
            }

            foreach (var planet in planets)
            {
                Console.WriteLine($"{ planet.PlanetName } is the { planet.PlanetInFromStar }rd planet from { planet.PlanetStar }, and has a mass of { planet.PlanetMass }.");
            }
            PlanetMass(0);
            void PlanetMass(int index)
            {
                double ThisPlanetMass;
                int thisplanet = index;
                string[] entries = entriesList[thisplanet];
                ThisPlanetMass = double.Parse(entries[3]);
            }

            //foreach (var planet in planets)
            //{
            //    if (planet.
            //}
            Console.ReadLine();



            //public moon moon1 =
            //inventory =
            //GrossPlanetaryProduct =
            //motivations =
            //laws();
            //{
            //taxrate()
            //}
            //inhabitants = list(characters)
            //sectors =
            //seasons = 
        }
    }
}
