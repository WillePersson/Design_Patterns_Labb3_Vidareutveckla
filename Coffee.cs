using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb3_Vidareutveckla
{
	// Ny dryck: Kaffe
	internal class Coffee : IWarmDrink
	{
		public void Consume()
		{
			Console.WriteLine("Cofffeffe is served."); // Utskrift vid konsumtion av kaffe
		}
	}
}
