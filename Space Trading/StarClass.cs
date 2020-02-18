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
        public void Run()
        {
            string starPath = "Stars .txt";
            List<Star> stars = new List<Star>();
            List<string> lines = File.ReadAllLines(starPath).ToList();


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

            foreach (var star in stars)
            {
                Console.WriteLine($"{star.StarName} is on our game map at ({star.StarXCoord},{star.StarYCoord}), with a mass of {star.StarMass}");
            }


            Console.ReadLine();
        }
    }
}
