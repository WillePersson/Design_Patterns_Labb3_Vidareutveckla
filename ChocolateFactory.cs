using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb3_Vidareutveckla
{
	// Fabrik för Choklad
	internal class ChocolateFactory : IWarmDrinkFactory
	{
		public IWarmDrink Prepare(int total)
		{
			Console.WriteLine($"Gör {total} ml varm choklad."); // Utskrift av mängden varm choklad som görs
			return new Chocolate(); // Returnerar en ny instans av Chocolate
		}
	}
}
