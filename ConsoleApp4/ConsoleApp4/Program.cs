using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
		
			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}


// A

//SELECT * FROM TPEOPLE t WHERE age in 
//(SELECT FLOOR (DATEDIFF(DAY, t.CBORN_DATE, GETDATE())/365.25) AS age
//WHERE FLOOR(DATEDIFF(DAY, t.CBORN_DATE, GETDATE())/365.25) > 20); 	


// B

//SELECT* FROM TPEOPLE WHERE CFULL_NAME LIKE '%Rodr%' ORDER BY CPERSON_ID;