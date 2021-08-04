using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	public class MongoDataAccess : IDataAccess
	{
		public static List<Product> Products = new List<Product>()
		{
			new Product() {Name = "Lettuce", Price = 499 },
			new Product() {Name = "Ketchup", Price = 599 },
			new Product() {Name = "Mustard", Price = 699 },
			new Product() {Name = "Mayonnaise", Price = 799 },


		};
		public List<Product> LoadData()
		{
			Console.WriteLine("I am reading data from Mongo Data Access.");
			return Products;
		}

		public void SaveData()
		{
			Console.WriteLine("I am saving data from a Mongo Data Access");

		}
	}
}
