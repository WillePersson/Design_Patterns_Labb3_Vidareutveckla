using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb3_Vidareutveckla
{
	//Fabrik för Oboy
	internal class OboyFactory : IWarmDrinkFactory
	{
		public IWarmDrink Prepare(int total)
		{
			Console.WriteLine($"Förbereder {total} ml Oboy."); // Utskrift av mängden Oboy som förbereds
			return new Cappuccino(); // Returnerar en ny instans av Oboy
		}
	}
}
