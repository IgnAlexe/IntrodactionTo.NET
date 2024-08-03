using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите первое число: ");
			double op1=Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите операцию '+','-','*','/': ");
			char sing= Convert.ToChar(Console.ReadLine());
			Console.WriteLine("Введите второе число: ");
			double op2=Convert.ToDouble(Console.ReadLine());
			if (sing == '+') Console.WriteLine("Ответ :{0} + {1} ="+(op1+op2),op1,op2);
			if (sing == '-') Console.WriteLine("Ответ :{0} - {1} =" + (op1 - op2), op1, op2);
			if (sing=='*') Console.WriteLine("Ответ :{0} * {1} =" + (op1 * op2), op1, op2);
			if (sing == '/')
			{
				if (op1 == 0) Console.WriteLine("Ноль делить нельзя!");
				if (op2 == 0) Console.WriteLine("На Ноль делить нельзя!");
				else Console.WriteLine("Ответ :{0}/{1}=" + (op1 / op2), op1, op2);
			}
		}
	}
}
