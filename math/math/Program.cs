using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please input1 to multiply");
			int input1 = Convert.ToInt32(Console.ReadLine());
			int product = input1 * 50;
			Console.WriteLine("input * 50 =" + product.ToString());
			Console.ReadLine();

			Console.WriteLine("Please input2 to add");
			int input2 = Convert.ToInt32(Console.ReadLine());
			int total = input2 + 25;
			Console.WriteLine("input + 25 =" + total.ToString());
			Console.ReadLine();

			Console.WriteLine("Please input3 to divide");
			int input3 = Convert.ToInt32(Console.ReadLine());
			double div = input3 / 12.5;
			Console.WriteLine("input / 12.5 =" + div.ToString());
			Console.ReadLine();

			Console.WriteLine("Please input4 to check > 50");
			int input4 = Convert.ToInt32(Console.ReadLine());
			bool check = input4 > 50;
			Console.WriteLine("input4 is >  =" + check.ToString());
			Console.ReadLine();

			Console.WriteLine("Please input5 to divide by 7 and print remainder");
			int input5 = Convert.ToInt32(Console.ReadLine());
			double div2 = input5 % 7;
			Console.WriteLine("Afer div by 7 remainder =" + div2.ToString());
			Console.ReadLine();


		}
	}
}
