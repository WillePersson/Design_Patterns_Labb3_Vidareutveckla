namespace Design_Patterns_Labb3_Vidareutveckla
{
	class Program
	{
		static void Main(string[] args)
		{
			var machine = new WarmDrinkMachine(); // Skapar en instans av WarmDrinkMachine
			bool continueSelecting = true;

			while (continueSelecting)
			{
				IWarmDrink drink = machine.MakeDrink(); // Skapar en dryck
				drink.Consume(); // Konsumerar drycken

				Console.WriteLine("Vill du välja en till dryck? (y/n)"); 
				if (Console.ReadLine().ToLower() != "y")
				{
					continueSelecting = false; 
				}
			}

			Console.WriteLine("Tack för att du använde VarmDrinkStation!");
		}
	}
}
