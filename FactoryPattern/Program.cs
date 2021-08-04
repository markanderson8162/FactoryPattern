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
			Console.WriteLine("What database?");
			Console.WriteLine("\"sql\", \"mongo\", or \"list\"? ");
			var input = Console.ReadLine();
			IDataAccess db = DataAccessFactory.GetDataAccessType(input);
			var products = db.LoadData();
			db.SaveData();
			foreach(var product in products)
			{
				Console.WriteLine($"{product.Name}: ${product.Price}.99");
			}
			
		}
	}
}
