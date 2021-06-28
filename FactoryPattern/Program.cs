using System;

namespace FactoryPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many tires?");
			string userInput = Console.ReadLine();
			int number;
			Int32.TryParse(userInput, out number);
			VehicleFactory factory = new VehicleFactory();
			factory.GetVehicle(number);

		}
	}
}
