using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			IDictionary<int, int> notas = new Dictionary<int, int>
			{ {100, 0}, {50, 0}, {20, 0}, {10, 0}, {5, 0}, {2, 0} };

			int nroNotas = notas.Count;
			Console.WriteLine("Diga o valor que deseja sacar.");
			int x;
			x = int.Parse(Console.ReadLine());
			Console.WriteLine("O total de notas sacadas foi: " + notasSacadas(notas, nroNotas, x));
		}

		public static int notasSacadas(IDictionary<int,int> notas, int nroNotas, int saque)
		{
			int[] min = new int[saque + 1];

			for (int i = 0; i < saque; i++)
			{
				foreach (KeyValuePair<int, int> x in notas)
				{
					{
						
					}
					
				}
			}

		}

	}
}
