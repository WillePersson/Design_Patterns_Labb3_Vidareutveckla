using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb3_Vidareutveckla
{
	// Fabrik för Kaffe
	internal class CoffeeFactory : IWarmDrinkFactory
	{
		public IWarmDrink Prepare(int total)
		{
			Console.WriteLine($"Brygger {total} ml varmt kaffe."); // Utskrift av mängden kaffe som bryggs
			return new Coffee(); // Returnerar en ny instans av Coffee
		}
	}
}
