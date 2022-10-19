using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入年份:");
			int year = Convert.ToInt32(Console.ReadLine());

			DateTime dateTime = new DateTime(year, 1, 1);
			DateTime lastDay = new DateTime(year, 12, 31);
			DayOfWeek dayOfWeek = dateTime.DayOfWeek;
			int value = (int)dayOfWeek;
			int days = 0;
			if (value - 7 == -7)
			{
				days = 0;
			}
			else
			{
				days = 8 - value; 
			}
			string date = days.ToString();
			for (DateTime i = new DateTime(year, 1, days); i <= lastDay; i=i.AddDays(7))
			{
				Console.WriteLine($"{i:yyyy,MM,dd}");
			}

		}
	}
}
