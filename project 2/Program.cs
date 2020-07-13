using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
	class Program
	{
		static void Main(string[] args)
		{
			double num1, num2, num3,avg,d;
			Console.WriteLine("Enter the 3 values you need");
			num1 = Convert.ToDouble(Console.ReadLine());
			num2 = Convert.ToDouble(Console.ReadLine());
			num3 = Convert.ToDouble(Console.ReadLine());
			d = num1 + num2 + num3;
			avg = d / 3;
			Console.WriteLine($"The Average of {num1}, {num2} and {num3} is {avg}");
		}
	}
}
