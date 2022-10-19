using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime borrow = DateTime.Now;
			DateTime re = borrow.AddMonths(1);
			Console.WriteLine(re);
		}
	}
}
