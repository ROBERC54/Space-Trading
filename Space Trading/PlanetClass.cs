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

        public PlanetClass()
        {
            generatePlanetList(planetPath);
        }

        public void Run()
        {
            Console.ReadLine();
        }

        public List<int> getPlanetXCoord(string starName)
        {
            List<int> xes = new List<int>();
            foreach (var planet in planets)
            {
                if (planet.PlanetStar == starName)
                {
                    xes.Add(planet.PlanetXCoord);
                }
            }
            return xes;
        }

        public List<int> getPlanetYCoord(string starName)
        {
            List<int> yses = new List<int>();
            foreach (var planet in planets)
            {
                if (planet.PlanetStar == starName)
                {
                    yses.Add(planet.PlanetYCoord);
                }
            }
            return yses;
        }

        public List<string> getPlanetSymbol(string starName)
        {
            List<string> zses = new List<string>();
            foreach (var planet in planets)
            {
                if (planet.PlanetStar == starName)
                {
                    zses.Add(planet.PlanetSymbol);
                }
            }
            return zses;
        }

        public int numPlanets(string star)
            => planets.Where(p => p.PlanetStar == star)
                      .Count();
        public int planetsInSys(string starName)
        {
            int count = 0;
            foreach (var planet in planets)
            {
                if (planet.PlanetStar == starName)
                {
                    count++;
                }
            }
            return count;
        }

        public void generatePlanetList(string planetPath)
        {
            List<string> lines = File.ReadAllLines(planetPath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(", ");
                Planet newPlanet = new Planet();
                newPlanet.PlanetName = entries[0];
                newPlanet.PlanetStar = entries[1];
                newPlanet.PlanetInFromStar = int.Parse(entries[2]);
                newPlanet.PlanetMass = double.Parse(entries[3]);
                newPlanet.PlanetXCoord = int.Parse(entries[4]);
                newPlanet.PlanetYCoord = int.Parse(entries[5]);
                newPlanet.PlanetSymbol = entries[6];

                planets.Add(newPlanet);

            }
        }

        internal Planet PlanetAt(int userx, int usery)
        {
            return planets.Where(p => p.PlanetXCoord == userx
                                 && p.PlanetYCoord == usery)
                        .Single();
        }

    }
}
