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
            List<string> Citems = File.ReadAllLines(itemPath).ToList();


            //foreach (string Citem in Citems)
            //{
            //    Console.WriteLine(Citem);

            //}

            List<string> Fitems = File.ReadAllLines(itemPath).ToList();
            foreach (string Fitem in Fitems)
            {
                Console.WriteLine(Fitem);
                //Fitems.Add("Charlie Murphy");


            }

            //items.Add("");



            Console.ReadLine();

            //priceScheme = 
        }
    }
}
