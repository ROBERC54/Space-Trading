using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Trading
{
    public class StarClass
    {
        string starPath = "Stars .txt";
        List<Star> stars = new List<Star>();

        public void Run()
        {
            stars = new StarClass().generateStarList(starPath);



            foreach (var star in stars)
            {
                Console.WriteLine($"{star.StarName} is on our game map at ({star.StarXCoord},{star.StarYCoord}), with a mass of {star.StarMass}");
            }


            Console.ReadLine();
        }

        public List<int> getStarXCoord()
        {

            stars = new StarClass().generateStarList(starPath);
            List<int> xes = new List<int>();
            foreach (var star in stars)
            {
                xes.Add(star.StarXCoord);
            }
            return xes;
        }
        public List<int> getStarYCoord()
        {

            stars = new StarClass().generateStarList(starPath);
            List<int> yses = new List<int>();
            foreach (var star in stars)
            {
                yses.Add(star.StarYCoord);
            }
            return yses;
        }

        public List<Star> generateStarList(string starPath)
        {
            List<string> lines = File.ReadAllLines(starPath).ToList();
            List<Star> stars = new List<Star>();

            foreach (var line in lines)
            {
                string[] entries = line.Split(",");
                Star newStar = new Star();
                newStar.StarName = entries[0];
                newStar.StarMass = double.Parse(entries[1]);
                newStar.StarXCoord = int.Parse(entries[2]);
                newStar.StarYCoord = int.Parse(entries[3]);

                stars.Add(newStar);

            }
            return stars;
        }
    }
}
