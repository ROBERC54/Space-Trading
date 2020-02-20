using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Trading
{
    public class BlackHoleClass
    {
        string blackHolePath = "EmptyTextFile.txt";
        List<BlackHole> blackHoles = new List<BlackHole>();


        public void Run()
        {
            blackHoles = new BlackHoleClass().generateBlackHoleList(blackHolePath);


        }

        public List<int> getBlackHoleXCoord()
        {

            blackHoles = new BlackHoleClass().generateBlackHoleList(blackHolePath);
            List<int> blxes = new List<int>();
            foreach (var blackHole in blackHoles)
            {
                blxes.Add(blackHole.BlackHoleXCoord);
            }
            return blxes;
        }
        public List<int> getBlackHoleYCoord()
        {

            blackHoles = new BlackHoleClass().generateBlackHoleList(blackHolePath);
            List<int> blyses = new List<int>();
            foreach (var blackHole in blackHoles)
            {
                blyses.Add(blackHole.BlackHoleYCoord);
            }
            return blyses;
        }

        public List<BlackHole> generateBlackHoleList(string blackHolePath)
        {
            List<string> lines = File.ReadAllLines(blackHolePath).ToList();
            List<BlackHole> blackHoles = new List<BlackHole>();

            foreach (var line in lines)
            {
                string[] entries = line.Split(", ");
                BlackHole newBlackHole = new BlackHole();
                newBlackHole.BlackHoleName = entries[0];
                newBlackHole.BlackHoleMass = double.Parse(entries[1]);
                newBlackHole.BlackHoleXCoord = int.Parse(entries[2]);
                newBlackHole.BlackHoleYCoord = int.Parse(entries[3]);

                blackHoles.Add(newBlackHole);

            }
            return blackHoles;
        }

        internal BlackHole StarAt(int userx, int usery)
        {
            return blackHoles.Where(b => b.BlackHoleXCoord == userx
                                 && b.BlackHoleYCoord == usery)
                        .Single();
        }


    }
}
