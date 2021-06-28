using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	class Car : IVehicle
	{
		public bool HasTrunk { get; set; }
		public int NumberOfDoors { get; set; }

		public void Drive()
		{
			Console.WriteLine("Building a car!");
		}

		public void Driving()
		{
			Console.WriteLine("Driving a Car.");
		}
	}
}
