using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

	class Teste2
	{

		public static void Main(string[] args)
		{
			int[] notas = new int[6] { 100, 50, 20, 10, 5, 2 };
			int nroNotas = notas.Length;
			Console.WriteLine("Diga o valor que deseja sacar.");
			int x;
			x = int.Parse(Console.ReadLine());
			Console.WriteLine("O total de notas sacadas foi: " + notasSacadas(notas, nroNotas, x));
		}

		public static int notasSacadas(int[] notas, int nroNotas, int saque)
		{
			int[] min = new int[saque+1];
			int[] opt = new int[nroNotas];

			min[0] = 0;

			for (int i = 1; i <= saque; i++)
			{
				for(int j = 0; j<opt.Length; j++)
				{
					opt[j] = -1;
				}

				for (int j = 0; j < nroNotas; j++)
				{
					if (notas[j] <= i)
					{
						opt[j] = min[i - notas[j]] + 1;
					}
				}

				min[i] = -1;

				for(int j =0; j<opt.Length; j++)
				{
					if (opt[j] > 0 && (min[i] == -1 || min[i] > opt[j]))
					{
						min[i] = opt[j];


					}
				}
			}

			return min[saque];
		}

	}

}
