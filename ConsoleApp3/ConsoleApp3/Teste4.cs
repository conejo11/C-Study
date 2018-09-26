using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Teste4
	{
		static void Main(string[] args)
		{
			List<int> test = new List<int>();

			//int x = GetFirstErrado(test);
			//int x = GetFirstMaisCorreto(test);
			//int x = GetFirstMaisCorreto(test);
			//int x = GetFirstMenosCorreto1(test);
			int x = GetFirstMenosCorreto2(test);

			Console.WriteLine("FIRST IS: " + x);  
			
		}

		public static int GetFirstMaisCorreto(List<int> x)
		{
			return x.FirstOrDefault();
		}

		public static int GetFirstErrado(List<int> x)
		{
			return x.First();
		}

		public static int GetFirstMenosCorreto1(List<int> x)
		{
			if (x.Any())
				return x.First();
		}

		public static int GetFirstMenosCorreto2(List<int> x)
		{
			if (x != null)
			{
				if(x.Count > 0)
				{
					return x[0];
				}
			}
		}
	}
}
