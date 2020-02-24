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
            int runTimes = 3;
            do
            {
                Console.Clear();
                string lastTime = $"Congratulations: You've put more than 10000 in the bank!  You've won!                             ";
                for (int i = 0; i < lastTime.Length; i++)
                {
                    for (int j = 0; j < 19000000; j++)
                    { }
                    Console.Write(lastTime.ElementAt(i));
                }runTimes--;
            } while (runTimes!=0);
            new Main_Menu().Run();
        }
        public void Run(int age, int money)
        {
            int runTimes = 5;
            do
            {
                Console.Clear();
                string lastTime = $"Congratulations: You're more than {age} years old!  You've got {money} in the bank!  Hope you have enough to enjoy retirement!  You've lost!                             ";
                for (int i = 0; i < lastTime.Length; i++)
                {
                    for (int j = 0; j < 19000000; j++)
                    { }
                    Console.Write(lastTime.ElementAt(i));
                }runTimes--;
            } while (runTimes!=0);
            new Main_Menu().Run();
        }
    }
}
