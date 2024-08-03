#define SQUARE
#define TRIANGLE_1
#define TRIANGLE_2
#define TRIANGLE_3
#define TRIANGLE_4
#define ROMB
#define PLUS
#define CHESS
#define HARD_CHESS


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Geometry";
			Console.Write("Введите размер фигуры: ");
			int n = Convert.ToInt32(Console.ReadLine());
#if SQUARE
           for(int i=0; i<=n; i++) 
            {
                for(int j=0; j<=n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
#endif
#if TRIANGLE_1
			for (int i = 0; i <= n; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
#endif
#if TRIANGLE_2
			for (int i = 0; i <= n; i++)
			{
				for (int j = i; j <= n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
#endif
#if TRIANGLE_3
			for (int i = 0; i <= n; i++)
            {
				for (int j = 0; j < i; j++) Console.Write ("  ");
				for (int j = i; j < n; j++) Console.Write ("* ");
                Console.WriteLine();
			}
#endif
#if TRIANGLE_4
			for (int i = 0; i <= n; i++)
			{
				for (int j = i; j < n; j++) Console.Write("  ");
				for (int j = 0; j < i; j++) Console.Write("* ");
				Console.WriteLine();
			}
#endif
#if ROMB
			for (int i = 0; i < 5; i++)
			{
				for (int j = i; j <5;j++) Console.Write(" ");
				Console.Write("/");
				for (int j = 0; j < i*2; j++) Console.Write(" ");
				Console.Write("\\");
				Console.WriteLine();
			}
			for(int i = 0; i < 5;i++)
			{
				for(int j=0;j<=i;j++) Console.Write(" ");
				Console.Write("\\");
				for (int j = (i + 1) * 2; j < 5 * 2; j++) Console.Write(" ");
				Console.Write("/");
				Console.WriteLine();
			}
#endif
#if PLUS

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if ((i + j) % 2 == 0) Console.Write("+ ");
					else Console.Write("- ");
				}
				Console.Write("\n");
			}
#endif
#if CHESS
			//for (int i = 0; i < 256; i++)
			//{
			//	Console.WriteLine(i+" "+(char)i);
			//}
			for (int i = 0; i <= n + 1; i++)
			{
				for (int j = 0; j <= n + 1; j++)
				{
					if (i == 0 && j == 0) Console.Write("┌");
					else if (i == 0 && j == n + 1) Console.Write((char)172);
					else if (i == n + 1 && j == 0) Console.Write("└");
					else if (i == n + 1 && j == n + 1) Console.Write("┘");
					else if (i == 0 || i == n + 1) Console.Write("─");
					else if (j == 0 || j == n + 1) Console.Write("|");
					else if ((i + j) % 2 == 0) Console.Write("█");//"\x25A0");
					else if ((i + j) % 2 != 0) Console.Write("░");
					else Console.Write(" ");
				}
				Console.Write("\n");
			}
#endif
#if HARD_CHESS
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					for (int k = 0; k < n; k++)
					{
						for (int p = 0; p < n; p++)
						{
							if ((i + k) % 2 == 0) Console.Write("* ");
							else Console.Write("  ");

						}
					}
					Console.WriteLine();
				}
			}
#endif
		}
	}
}
