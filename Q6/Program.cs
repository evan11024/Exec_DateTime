using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入日期:");
			String input = Console.ReadLine();	

			DateTime dateTime = Convert.ToDateTime(input);
			int days = dateTime.Day;


			if (days <= 10)
			{
				Console.WriteLine("上旬");
			}
			else if (days <= 20)
			{
				Console.WriteLine("中旬");
			}
			else
			{
				Console.WriteLine("下旬");
			}

		}
	}
}
