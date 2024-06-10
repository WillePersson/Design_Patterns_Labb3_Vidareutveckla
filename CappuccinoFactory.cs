using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb3_Vidareutveckla
{
	// Fabrik för Cappuccino
	internal class CappuccinoFactory : IWarmDrinkFactory
	{
		public IWarmDrink Prepare(int total)
		{
			Console.WriteLine($"Förbereder {total} ml krämig cappuccino."); // Utskrift av mängden cappuccino som förbereds
			return new Cappuccino(); // Returnerar en ny instans av Cappuccino
		}
	}
}
