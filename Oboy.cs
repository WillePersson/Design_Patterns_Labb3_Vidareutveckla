using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb3_Vidareutveckla
{
	//ny dryck: oboy
	internal class Oboy : IWarmDrink
	{
		public void Consume()
		{
			Console.WriteLine("Oböoooooöööyyy is served."); // Utskrift vid konsumtion av vatten
		}
	}
}
