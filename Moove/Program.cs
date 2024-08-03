using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moove
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Moove";
			int x=0; int y=0;
			Console.Write("■");
			do
			{
				switch (Console.ReadKey().Key)
				{
					case ConsoleKey.W: case ConsoleKey.UpArrow: y--; break;
					case ConsoleKey.S: case ConsoleKey.DownArrow: y++; break;
					case ConsoleKey.A: case ConsoleKey.LeftArrow: x--; break;
					case ConsoleKey.D: case ConsoleKey.RightArrow: x++; break;
				}
				if (x < 0) x = 0;
				if (y < 0) y = 0;
				if(x>Console.WindowWidth-1)x=Console.WindowWidth-1;
				if(y>Console.WindowHeight-1)y=Console.WindowHeight-1;
				Console.Clear();
				Console.SetCursorPosition(x, y);
				Console.Write("■");
			}
			while(true);
		}
	}
}
