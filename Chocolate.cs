using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb3_Vidareutveckla
{
	// Ny dryck: Choklad
	internal class Chocolate : IWarmDrink
	{
		public void Consume()
		{
			Console.WriteLine("Chocolattttes is served."); // Utskrift vid konsumtion av varm choklad
		}
	}
}
