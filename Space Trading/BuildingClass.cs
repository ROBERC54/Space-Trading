using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Trading
{
    public class BuildingClass
    {
        string buildingPath = "Buildings.txt";
        List<Building> buildings = new List<Building>();

        public BuildingClass()
        {
            generateBuildingList(buildingPath);
        }

        public void Run()
        {
            Console.ReadLine();
        }

        public List<int> getBuildingXCoord()
        {
            List<int> xes = new List<int>();
            foreach (var building in buildings)
            {
                xes.Add(building.BuildingXCoord);
            }
            return xes;
        }

        public List<int> getBuildingYCoord()
        {
            List<int> yses = new List<int>();
            foreach (var building in buildings)
            {
                yses.Add(building.BuildingYCoord);
            }
            return yses;
        }

        public int numBuildings(string planet)
            => buildings.Where(b => b.BuildingPlanets == planet)
                        .Count();

        public void generateBuildingList(string buildingPath)
        {
            List<string> lines = File.ReadAllLines(buildingPath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(", ");
                Building newBuilding = new Building();
                newBuilding.BuildingName = entries[0];
                newBuilding.BuildingPlanets = entries[1];
                newBuilding.BuildingSymbol = entries[2];
                newBuilding.BuildingXCoord = int.Parse(entries[3]);
                newBuilding.BuildingYCoord = int.Parse(entries[4]);
                newBuilding.BuildingLength = int.Parse(entries[5]);
                newBuilding.BuildingWidth = int.Parse(entries[6]);

                buildings.Add(newBuilding);
            }
        }

        internal Building BuildingAt(int userx, int usery)
        {
            return buildings.Where(b => b.BuildingXCoord == userx
                                 && b.BuildingYCoord == usery)
                        .Single();
        }
    }
}
