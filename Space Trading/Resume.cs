using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Space_Trading
{
	class Resume
	{//From the MainMenu screen, functionality results from whether the User selects "Play Game", "Resume", "How to", or "Quit."
	 //This class will handle the case of "Resume" when called from within Main_Menu.cs
	 //The class functions to pick up a save state to initiate a playthrough rather than starting from scratch.
	 //All transitions to other portions of the game will originate from 'Resume' at this point in the game sequence.
		public void Run()
		{
			Console.Clear();
			string lastStarSys = getLastStarSys();
			string lastTime = $"Last time on (SPACE)TRADERS, you were in {lastStarSys} star system...";
			for (int i = 0; i < lastTime.Length; i++)
			{
				for (int j = 0; j < 7000000; j++)
				{ }
				Console.Write(lastTime.ElementAt(i));
			}
			Console.WriteLine();
			Console.ReadKey();
			new Map_Class().Run();
		}
		public string getLastStarSys()
		{	//exists at line 0
			string lastStarSys = getSaveData(0);
			return lastStarSys;


		}
		public string getSaveData(int lineNum)
		{
			string saveDataPath = "Save Data.txt";
			List<string> lines = File.ReadAllLines(saveDataPath).ToList();
			foreach (string line in lines)
			{	
				int i = 0;
				if (lineNum == i)
				{
					return line;
				}
			}
			return saveDataPath;
		}
	}
}
