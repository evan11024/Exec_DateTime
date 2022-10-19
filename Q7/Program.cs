using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			if (hour > 4 && hour <= 10)
			{
				Console.WriteLine("早安");
			}
			else if (hour > 10 && hour < 17)
			{
				Console.WriteLine("午安");
			}
			else
			{
				Console.WriteLine("晚安");
			}
		}
	}
}
