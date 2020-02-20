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
        string planetPath = "Planets.txt";
        List<Planet> planets = new List<Planet>();

        public void Run()
        {
            planets = new PlanetClass().generatePlanetList(planetPath);

            foreach (var planet in planets)
            {
                Console.WriteLine($"{ planet.PlanetName } is the { planet.PlanetInFromStar }rd planet from { planet.PlanetStar }, and has a mass of { planet.PlanetMass }.");
            }


            Console.ReadLine();

        }


        public List<int> getPlanetXCoord()
        {

            planets = new PlanetClass().generatePlanetList(planetPath);
            List<int> xes = new List<int>();
            foreach (var planet in planets)
            {
                xes.Add(planet.PlanetXCoord);
                Console.WriteLine($"This planet's xcoord is: {planet.PlanetXCoord}");
            }
            return xes;
        }
        public List<int> getPlanetYCoord()
        {

            planets = new PlanetClass().generatePlanetList(planetPath);
            List<int> yses = new List<int>();
            foreach (var planet in planets)
            {
                yses.Add(planet.PlanetYCoord);
                Console.WriteLine($"This planet's xcoord is: {planet.PlanetXCoord}");
            }
            return yses;
        }
        public int numPlanets(string star)
        {
            List<string> lines = File.ReadAllLines(planetPath).ToList();
            List<Planet> planets = new List<Planet>();
            int numInSys = 0;

            foreach (var line in lines)
            {
                string[] entries = line.Split(",");
                if (entries[1] == star)
                {
                    numInSys++;
                }
            }
            return numInSys;

        }
        public List<Planet> generatePlanetList(string planetPath)
        {
            List<string> lines = File.ReadAllLines(planetPath).ToList();
            List<Planet> planets = new List<Planet>();

            foreach (var line in lines)
            {
                string[] entries = line.Split(",");
                Planet newPlanet = new Planet();
                newPlanet.PlanetName = entries[0];
                newPlanet.PlanetStar = entries[1];
                newPlanet.PlanetInFromStar = int.Parse(entries[2]);
                newPlanet.PlanetMass = double.Parse(entries[3]);
                newPlanet.PlanetXCoord = int.Parse(entries[4]);
                newPlanet.PlanetYCoord = int.Parse(entries[5]);

            }
            return planets;
        }

    }
}
