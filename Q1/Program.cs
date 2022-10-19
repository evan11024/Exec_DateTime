using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime borrow = DateTime.Now;
			DateTime re   =  borrow.AddDays(3);

			Console.WriteLine(re);

		}
	}
}
