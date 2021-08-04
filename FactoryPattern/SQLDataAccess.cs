using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	public class SQLDataAccess : IDataAccess
	{
		public static List<Product> Products = new List<Product>()
		{
			new Product() {Name = "Cheese", Price = 499 },
			new Product() {Name = "Tomato", Price = 599 },
			new Product() {Name = "Pickles", Price = 699 },
			new Product() {Name = "Onion", Price = 799 },


		};
		public List<Product> LoadData()
		{
			Console.WriteLine("I am reading data from SQL Data Access.");
			return Products;
		}

		public void SaveData()
		{
			Console.WriteLine("I am saving data from a SQL Data Access");
			
		}
	}
}
