using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Space_Trading
{
    class WinConditionClass
    {
        public void Run()
        {
            do
            {
                Console.Clear();
                string lastTime = $"Congratulations: You've put more than 10000 in the bank!  You've won!                             ";
                for (int i = 0; i < lastTime.Length; i++)
                {
                    for (int j = 0; j < 19000000; j++)
                    { }
                    Console.Write(lastTime.ElementAt(i));
                }
            } while (true);
        }
    }
}
