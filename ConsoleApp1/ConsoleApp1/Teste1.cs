using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Teste1
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Console.WriteLine("Digite a quantidade de numeros.");
			int n;
			if(int.TryParse(Console.ReadLine(), out n)){
				int qtd = n;
				Console.WriteLine("Digite os numeros.");
				List<float> lines = new List<float>();
				while (n != 0){
					lines.Add(float.Parse(Console.ReadLine()));
					n--;
				}
				float media, mediana;
				int meio = qtd / 2;
			    lines.Sort();

				if((qtd%2) == 0){
					mediana = ((lines.ElementAt(meio) + lines.ElementAt((meio - 1))) / 2);
				} else {
					mediana = lines.ElementAt(meio);
				}
				media = lines.Average();
				string conceito;
				if (media < 4.0){
					conceito = "E";
				} else if (media < 6.0 && media >= 4.0) {
					conceito = "D";
				}
				else if (media < 7.5 && media >= 6.0){
					conceito = "C";
				}
				else if (media < 9.0 && media >= 7.5){
					conceito = "B";
				} else {
					conceito = "A";
				}

				Console.WriteLine($"mediana: { mediana} media: {media} conceito: {conceito}");
			}

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
