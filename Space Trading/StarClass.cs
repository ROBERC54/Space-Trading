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

        public StarClass()
        {
            generateStarList(starPath);
        }

        public void Run()
        {

            Console.ReadLine();
        }

        public List<int> getStarXCoord()
        {
            List<int> xes = new List<int>();
            foreach (var star in stars)
            {
                xes.Add(star.StarXCoord);
            }
            return xes;
        }
        public List<int> getStarYCoord()
        {
            List<int> yses = new List<int>();
            foreach (var star in stars)
            {
                yses.Add(star.StarYCoord);
            }
            return yses;
        }

        public List<string> getStarSymbol()
        {
            List<string> zses = new List<string>();
            foreach (var star in stars)
            {
                zses.Add(star.StarSymbol);
            }
            return zses;
        }

        public int numStars(string symbol)
        {
            return stars.Where(s => s.StarSymbol == symbol)
                               .Count();
        }

        public void generateStarList(string starPath)
        {
            List<string> lines = File.ReadAllLines(starPath).ToList();
            List<Star> stars = new List<Star>();

            foreach (var line in lines)
            {
                string[] entries = line.Split(", ");
                Star newStar = new Star();
                newStar.StarName = entries[0];
                newStar.StarMass = double.Parse(entries[1]);
                newStar.StarXCoord = int.Parse(entries[2]);
                newStar.StarYCoord = int.Parse(entries[3]);
                newStar.StarSymbol = entries[4];

                stars.Add(newStar);

            }
        }

        internal Star StarAt(int userx, int usery)
        {
            return stars.Where(s => s.StarXCoord == userx
                                 && s.StarYCoord == usery)
                        .Single();
        }
    }
}
