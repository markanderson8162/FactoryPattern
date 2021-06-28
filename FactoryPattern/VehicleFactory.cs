using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	public class VehicleFactory
	{
		public void GetVehicle(int tires)
		{
			if(tires == 2)
			{
				Console.WriteLine("Motorcycle");
			}
			else if (tires == 4) 
			{
				Console.WriteLine("Car");
			}
			else if(tires == 1)
			{
				Console.WriteLine("Cannot create unicycle");
			}
			else
			{
				Console.WriteLine("Incorrect number of tires");
			}

		}

	}
}
