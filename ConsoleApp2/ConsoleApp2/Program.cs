using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			double Zone1(int price)
			{
				return price + (price * .25);
			}

			double Zone2(int price)
			{
				return price + (price * .12) + 25;
			}
			Rates r1;
			string val = Console.ReadLine();
			if (val == "z1")
			{
				r1 = new Rates(Zone1);
				Console.WriteLine(r1(100));
			}
			else
			{
				r1 = new Rates(Zone2);
				Console.WriteLine(r1(100));
			}
			Console.ReadKey();
		}

		public delegate double Rates(int price);

		

	}
}
