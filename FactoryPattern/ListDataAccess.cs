using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	public class ListDataAccess : IDataAccess
	{
		public static List<Product> Products = new List<Product>()
		{
			new Product() {Name = "Buns", Price = 499 },
			new Product() {Name = "Beef", Price = 599 },
			new Product() {Name = "Sesame Seeds", Price = 699 },
			new Product() {Name = "Pineapple", Price = 799 },


		};
		public List<Product> LoadData()
		{
			Console.WriteLine("I am reading data from List Data Access.");
			return Products;
		}

		public void SaveData()
		{
			Console.WriteLine("I am saving data from a List Data Access");

		}
	}
}
