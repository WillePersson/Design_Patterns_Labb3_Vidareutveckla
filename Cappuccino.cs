using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb3_Vidareutveckla
{
	// Ny dryck: Cappuccino
	internal class Cappuccino : IWarmDrink
	{
		public void Consume()
		{
			Console.WriteLine("Cappuccinodkjaksdka is served."); // Utskrift vid konsumtion av cappuccino
		}
	}
}
