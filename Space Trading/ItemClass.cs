using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Trading
{
    public class ItemClass
    {
        public void Run()
        {
            string itemPath = "Item List.txt";
            List<string> items = File.ReadAllLines(itemPath).ToList();


            foreach (string item in items)
            {
                Console.WriteLine(item);

            }


            Console.ReadLine();

            //priceScheme = 
        }
    }
}
